using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FATX_Browser.FATX
{
    public class FATXDrive
    {
        public string DumpPath = "";
        FATX.Misc r = new FATX.Misc();
        private bool isUSB = false;
        private int deviceID;
        private long dSize;
        private string sizeConverted;
        public FATX.Info.DriveType DriveType;
        public Folder[] Partitions;
        private IO.HDDFATX io;
        public FATX_Browser.FATX.IOReader br;
        public FATX_Browser.FATX.IOWriter bw;
        private PartitionInfo[] partinfo;

        private bool dump;
        /// <summary>
        /// Provides information about a specific Xbox 360 Drive
        /// </summary>
        public FATXDrive(int ID, Info.DriveType dtype)
        {
            deviceID = ID;
            DriveType = dtype;
            ReadSize();
        }

        public FATXDrive(string dumpPath, Info.DriveType dtype)
        {
            if (dtype == Info.DriveType.Backup)
            {
                IsDump = true;
            }
            else if (dtype == Info.DriveType.USB)
            {
                isUSB = true;
            }
            DriveType = dtype;
            DumpPath = dumpPath;
            ReadSize();
        }

        public void ReadSize()
        {
            GetIO();
            if (IsDump)
            {
                dSize = io.GetDriveSize();
            }
            else if (isUSB)
            {
                dSize = br.BaseStream.Length;
            }
            else
            {
                dSize = io.GetDriveSize(DeviceID);
            }
            sizeConverted = r.ByteConversion(dSize);
        }

        internal FATX_Browser.FATX.IOReader GetIO()
        {
            if (DriveType == Info.DriveType.HDD)
            {
                try
                {
                    io.Close();
                    br.Close();
                }
                catch { }
                io = new IO.HDDFATX(false, null);
                br = io.br_diskReader(DeviceID);
            }
            else if (DriveType == Info.DriveType.Backup)
            {
                try
                {
                    io.Close();
                }
                catch{}
                try
                {
                    br.Close();
                }
                catch{}
                try
                {
                    bw.Close();
                }
                catch { }
                io = new IO.HDDFATX(true, DumpPath);
                br = io.br_dumpReader();
            }
            else if (DriveType == Info.DriveType.USB)
            {
                try
                {
                    io.Close();
                }
                catch { }
                try
                {
                    br.Close();
                }
                catch { }
                try
                {
                    bw.Close();
                }
                catch { }
                System.IO.FileInfo[] fi = new System.IO.DirectoryInfo(DumpPath).GetFiles();
                string[] FilePaths = new string[fi.Length];
                for (int i = 0; i < FilePaths.Length; i++)
                {
                    FilePaths[i] = fi[i].FullName;
                }
                br = new IOReader(FilePaths);
            }
            return br;
        }

        internal FATX_Browser.FATX.IOWriter GetWriterIO()
        {
            if (DriveType == Info.DriveType.HDD)
            {
                try
                {
                    io.Close();
                }
                catch { }
                try
                {
                    br.Close();
                }
                catch { }
                try
                {
                    bw.Close();
                }
                catch { }
                io = new IO.HDDFATX(false, null);
                bw = io.bw_diskWriter(DeviceID);
            }
            else if (DriveType == Info.DriveType.Backup)
            {
                try
                {
                    io.Close();
                }
                catch{}
                try
                {
                    br.Close();
                }
                catch{}
                try
                {
                    bw.Close();
                }
                catch { }
                io = new IO.HDDFATX(true, DumpPath);
                bw = io.bw_dumpWriter();
            }
            else if (DriveType == Info.DriveType.USB)
            {
                try
                {
                    io.Close();
                }
                catch { }
                try
                {
                    br.Close();
                }
                catch { }
                try
                {
                    bw.Close();
                }
                catch { }
                System.IO.FileInfo[] fi = new System.IO.DirectoryInfo(DumpPath).GetFiles();
                string[] FilePaths = new string[fi.Length];
                for (int i = 0; i < FilePaths.Length; i++)
                {
                    FilePaths[i] = fi[i].FullName;
                }
                bw = new IOWriter(FilePaths);
            }
            return bw;
        }

        public bool IsDump
        {
            get { return dump; }
            set { dump = value; }
        }

        public bool IsUSB
        {
            get { return isUSB; }
            set { isUSB = value; }
        }

        public void ReadData()
        {
            Partitions = new FATX.Partitions().Get(this);
        }

        /// <summary>
        /// ID for the device (used for the Win32 API)
        /// </summary>
        public int DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        /// <summary>
        /// Drive size in bytes
        /// </summary>
        public long DriveSize
        {
            get { return dSize; }
        }

        /// <summary>
        /// Drive size converted to KB/MB/GB
        /// </summary>
        public string DriveSizeConverted
        {
            get { return sizeConverted; }
        }

        public bool Close()
        {
            try
            {
                io.Close();
                bw.Close();
                br.Close();
                return true;
            }
            catch { return true; }
        }

        public PartitionInfo[] GetPartInfo
        {
            get
            {
                return partinfo;
            }

            set
            {
                partinfo = value;
            }
        }

        public bool BackupDrive(string savePath)
        {
            long garbage = 0;
            return BackupDrive(ref garbage, savePath);
        }

        public bool BackupDrive(ref long Progress, string savePath)
        {
            FATX_Browser.FATX.IOWriter fileWriter = null;
            FATX_Browser.FATX.IOReader driveReader = null;
            try
            {
                long driveSize =DriveSize;
                fileWriter = new FATX_Browser.FATX.IOWriter(new System.IO.FileStream(savePath, System.IO.FileMode.Create));
                driveReader = this.GetIO();
                for (long i = 0; i < driveSize; i += 0x4000, Progress += 0x4000)
                {
                    byte[] buffer = driveReader.ReadBytes(0x4000);
                    fileWriter.Write(buffer);
                }
                fileWriter.Close();
                driveReader.Close();
                return true;
            }
            catch { try { fileWriter.Close(); driveReader.Close(); } catch { } return false; }
        }
    }
}
