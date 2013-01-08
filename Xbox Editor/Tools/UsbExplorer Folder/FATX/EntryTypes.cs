using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FATX_Browser.FATX
{
    public struct EntryData
    {
        /// <summary>
        /// Size of the name
        /// </summary>
        public byte FileNameSize;
        /// <summary>
        /// Entry flags
        /// </summary>
        public byte Flags;
        /// <summary>
        /// Entry name
        /// </summary>
        public string FileName;
        /// <summary>
        /// Beginning cluster (block) for the entry
        /// </summary>
        public UInt32 StartingCluster;
        /// <summary>
        /// Size of the entry (0x00 for folders)
        /// </summary>
        public UInt32 Size;
        public UInt16 CreationDate;
        public UInt16 CreationTime;
        public UInt16 AccessDate;
        public UInt16 AccessTime;
        public UInt16 ModifiedDate;
        public UInt16 ModifiedTime;
        /// <summary>
        /// Offset for the entry
        /// </summary>
        public long EntryOffset;
    }

    public class Partition
    {
        PartitionInfo partInfo = new PartitionInfo();

        public PartitionInfo PartInfo
        {
            get { return partInfo; }
            set { partInfo = value; }
        }
    }

    public class Entry
    {
        public EntryData EData = new EntryData();
        /// <summary>
        /// Information about the partition in which the file is located
        /// </summary>
        public PartitionInfo PartInfo;
        internal Entries e;
        internal Misc Misc;
        private FATX.FATXDrive drive;
        internal uint[] blocksOCCUPADO;
        internal bool isfolder;
        private bool isDeleted;

        /// <summary>
        /// Device ID (used for the FATXDrive)
        /// </summary>
        public int DeviceID
        {
            get { return Drive.DeviceID; }
        }

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        /// <summary>
        /// Name of the folder
        /// </summary>
        public string Name
        {
            get { return EData.FileName; }
            set { EData.FileName = value; }
        }

        /// <summary>
        /// Offset of the first block
        /// </summary>
        public long BaseOffset
        {
            get { return Misc.GetBlockOffset(Block, this); }
        }

        /// <summary>
        /// Root block
        /// </summary>
        public uint Block
        {
            get { return (uint)EData.StartingCluster; }
        }

        /// <summary>
        /// All blocks that the object occupies
        /// </summary>
        public virtual uint[] BlocksOccupied
        {
            get {
                if (!IsDeleted)
                {
                    if (blocksOCCUPADO == null)
                    {
                        blocksOCCUPADO = e.GetBlocksOccupied(Block);
                    }
                }
                else
                {
                    if (blocksOCCUPADO == null)
                    {
                        if (IsFolder)
                        {
                            blocksOCCUPADO = new uint[] { Block };
                        }
                    }
                }
                return blocksOCCUPADO;
            }
            set
            {
                blocksOCCUPADO = value;
            }
        }

        public bool BlocksLoaded
        {
            get { if (blocksOCCUPADO == null) { return false; } else { return true; } }
        }

        /// <summary>
        /// Offset for the entry in the file's folder
        /// </summary>
        public long EntryOffset
        {
            get { return EData.EntryOffset; }
        }

        public FATXDrive Drive
        {
            get { return drive; }
            set { drive = value; }
        }

        public bool IsFolder
        {
            get { return isfolder; }
        }

        public string EntryType
        {
            get
            {
                if (IsFolder && IsDeleted)
                {
                    return "Deleted Folder";
                }
                else if (IsFolder)
                {
                    return "File Folder";
                }
                else if (!IsFolder && IsDeleted)
                {
                    return "Deleted File";
                }
                else
                {
                    return "File";
                }
            }
        }
    }
    
    public sealed class Folder : Entry
    {
        private Folder[] subFolders;
        private File[] files;
        bool DeletedEntriesLoaded = false;

        public Folder(FATXDrive DRIVE, PartitionInfo partition)
        {
            PartInfo = partition;
            e = new Entries(this);
            Drive = DRIVE;
            Misc = new Misc();
            isfolder = true;
        }

        public void ReloadData(bool DoDeletedEntries)
        {
            Entries e = new Entries(this);
            //This will get our blocks occupied
            BlocksOccupied = e.GetBlocksOccupied(BlocksOccupied[0]);
            //This will get the files and folders
            Files(DoDeletedEntries);
        }

        /// <summary>
        /// Extracts each subfolder and file in this folder recursively
        /// </summary>
        /// <param name="path">Path to extract to</param>
        /// <param name="updateFolder">Current file being extracted</param>
        /// <param name="updateText">Current file being extracted</param>
        /// <param name="progress">The number of blocks that have been read/written</param>
        /// <param name="maxVal">File size</param>
        /// <param name="CreateRoot">Create root folder</param>
        public bool ExtractRecursive(string path, ref string updateFolder, ref string updateText, ref long progress, ref long maxVal, bool CreateRoot, bool DoDeletedEntries)
        {
            bool result = false;
            try
            {
                updateFolder = Name;
                if (CreateRoot == true)
                {
                    System.IO.Directory.CreateDirectory(path + "\\" + Name);
                    path += "\\" + EData.FileName;
                }

                File[] ourFiles = Files(DoDeletedEntries);
                if (ourFiles.Length != 0)
                {
                    foreach (File f in ourFiles)
                    {
                        updateText = f.Name;
                        e.ExtractFile(f, path + "\\" + f.Name, ref progress, ref maxVal);
                    }
                }

                Folder[] subFolders = SubFolders(DoDeletedEntries);
                if (subFolders.Length != 0)
                {
                    foreach (Folder f in subFolders)
                    {
                        updateFolder = f.Name;
                        result = f.ExtractRecursive(path, ref updateFolder, ref updateText, ref progress, ref maxVal ,true, DoDeletedEntries);
                    }
                }
                return true;
            }
            catch (Exception E) { MessageBox.Show(E.Message); return false; }
        }

        /// <summary>
        /// Returns an array of files that this folder holds
        /// </summary>
        public File[] Files(bool ShowDeletedEntries)
        {
            if (BlocksOccupied != null)
            {
                goto _Load;
            }
            else { blocksOCCUPADO = e.GetBlocksOccupied(Block); goto _Load; }
        _Load:
            {
                //This function gets files and folders in one fair swoop
                object[] objects = e.LoadEntries(this, ShowDeletedEntries);
                files = (File[])objects[1];
                subFolders = (Folder[])objects[0];
                DeletedEntriesLoaded = ShowDeletedEntries;
                if (!ShowDeletedEntries)
                {
                    List<File> fl = new List<File>();
                    List<Folder> ffl = new List<Folder>();
                    foreach (File f in files)
                    {
                        if (!f.IsDeleted)
                        {
                            fl.Add(f);
                        }
                    }
                    foreach (Folder f in subFolders)
                    {
                        if (!f.IsDeleted)
                        {
                            ffl.Add(f);
                        }
                    }
                    files = fl.ToArray();
                    subFolders = ffl.ToArray();
                }
            }
            if (ShowDeletedEntries != DeletedEntriesLoaded)
            {
                goto _Load;
            }
            return files;
        }

        /// <summary>
        /// Returns an array of subfolders that this folder holds
        /// </summary>
        public Folder[] SubFolders(bool ShowDeletedEntries)
        {
            if (BlocksOccupied != null)
            {
                goto _Load;
            }
            else { blocksOCCUPADO = e.GetBlocksOccupied(Block); goto _Load; }
        _Load:
            {
                //This function gets files and folders in one fair swoop
                object[] objects = e.LoadEntries(this, ShowDeletedEntries);
                files = (File[])objects[1];
                subFolders = (Folder[])objects[0];
                DeletedEntriesLoaded = ShowDeletedEntries;
                if (!ShowDeletedEntries)
                {
                    List<File> fl = new List<File>();
                    List<Folder> ffl = new List<Folder>();
                    foreach (File f in files)
                    {
                        if (!f.IsDeleted)
                        {
                            fl.Add(f);
                        }
                    }
                    foreach (Folder f in subFolders)
                    {
                        if (!f.IsDeleted)
                        {
                            ffl.Add(f);
                        }
                    }
                    files = fl.ToArray();
                    subFolders = ffl.ToArray();
                }
            }
            if (ShowDeletedEntries != DeletedEntriesLoaded)
            {
                goto _Load;
            }
            return subFolders;
        }

        public bool InjectFile(string FilePath)
        {
            Write w = new Write(Drive);
            return w.WriteNewFile(this, FilePath);
        }

        public bool InjectFolder(string FolderPath)
        {
            Write w = new Write(Drive);
            return w.NewFolder(FolderPath, this);
        }

        public bool OverWriteFolder(string FolderPath)
        {
            return true;
            DeleteSubFolders();
            DeleteSubFiles();
        }

        public bool Delete()
        {
            Write w = new Write(Drive);
            return w.Delete(this);
        }

        public bool DeleteSubFolders()
        {
            return true;
        }

        public bool DeleteSubFiles()
        {
            return true;
        }

        public bool NewFolder(string FolderName)
        {
            Write w = new Write(Drive);
            return w.NewFolder(FolderName, this);
        }
    }

    public sealed class File : Entry
    {
        public File(FATXDrive DRIVE, PartitionInfo partition)
        {
            PartInfo = partition;
            e = new Entries(this);
            Drive = DRIVE;
            Misc = new Misc();
        }

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        public long Size
        {
            get { return EData.Size; }
        }

        public bool Delete()
        {
            Write w = new Write(Drive);
            return w.Delete(this);
        }

        public bool Delete(ref long ProgressUpdate, ref long ProgressMax, ref string CurrentFile)
        {
            Write w = new Write(Drive);
            return w.Delete(this, ref ProgressUpdate, ref ProgressMax, ref CurrentFile);
        }

        public bool OverWrite(string NewFilePath)
        {
            Write w = new Write(Drive);
            return w.OverWriteFile(this, NewFilePath);
        }

        public override uint[] BlocksOccupied
        {
            get {
                if (!IsDeleted)
                {
                    if (blocksOCCUPADO == null)
                    {
                        blocksOCCUPADO = e.GetBlocksOccupied(Block);
                    }
                }
                else
                {
                    if (blocksOCCUPADO == null)
                    {
                        long size = Size;
                        size = new Misc().UpToNearestCluster(size, this.PartInfo.ClusterSize);
                        uint[] blocks = new uint[size / PartInfo.ClusterSize];
                        blocks[0] = Block;
                        for (uint i = 1; i < blocks.Length; i++)
                        {
                            blocks[i] = blocks[0] + i;
                        }
                        blocksOCCUPADO = blocks;
                    }
                }
                return blocksOCCUPADO;
            }
            set
            {
                blocksOCCUPADO = value;
            }
        }
    }
}
