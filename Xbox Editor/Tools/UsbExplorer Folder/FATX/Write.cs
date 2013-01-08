using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FATX_Browser.FATX;

namespace FATX_Browser.FATX
{
    class Write
    {
        FATXDrive ourDrive;
        Misc m;
        public Write(FATXDrive drive)
        {
            ourDrive = drive;
            m = new Misc();
        }

        public bool NewFolder(string name, Folder root)
        {
            //If the file name is valid
            if (m.CheckFileName(name))
            {
                EntryData EData = GetNewEntryData(root, name);
                Folder f = new Folder(ourDrive, root.PartInfo);
                f.EData = EData;
                CreateNewEntry(EData);
                WriteFATChain(f.BlocksOccupied, f);
                //root.ReloadData();
                return true;
            }
            return false;
        }

        public bool CreateNewEntry(EntryData Edata)
        {
            FATX_Browser.FATX.IOReader br = ourDrive.GetIO();
            //Set our position so that we can read the entry location
            br.BaseStream.Position = m.DownToNearest200(Edata.EntryOffset);
            byte[] buffer = br.ReadBytes(0x200);
            br.Close();
            //Create our binary writer
            FATX_Browser.FATX.IOWriter bw = new FATX_Browser.FATX.IOWriter(new System.IO.MemoryStream(buffer));
            //Set our position to where the entry is
            long EntryOffset = Edata.EntryOffset - m.DownToNearest200(Edata.EntryOffset);
            bw.BaseStream.Position = EntryOffset;
            //Write our entry
            bw.Write(Edata.FileNameSize);
            bw.Write(Edata.Flags);
            bw.Write(Encoding.ASCII.GetBytes(Edata.FileName));
            bw.BaseStream.Position = EntryOffset + 0x2C;
            //Right here, we need to make everything a byte array, as it feels like writing
            //everything in little endian for some reason...
            byte[] StartingCluster = BitConverter.GetBytes(Edata.StartingCluster);
            Array.Reverse(StartingCluster);
            bw.Write(StartingCluster);
            byte[] Size = BitConverter.GetBytes(Edata.Size);
            Array.Reverse(Size);
            bw.Write(Size);
            //Write out the creation date 6 times
            byte[] CreationDate = BitConverter.GetBytes(Edata.CreationDate);
            byte[] CreationTime = BitConverter.GetBytes(Edata.CreationTime);
            Array.Reverse(CreationDate);
            Array.Reverse(CreationTime);
            for (int i = 0; i < 3; i++)
            {
                bw.Write(CreationDate);
                bw.Write(CreationTime);
            }
            //Close our writer
            bw.Close();
            //Get our IO
            bw = ourDrive.GetWriterIO();
            bw.BaseStream.Position = m.DownToNearest200(Edata.EntryOffset);
            //Write out our buffer
            bw.Write(buffer);
            return true;
        }

        private bool WriteFATChain(uint[] blocksOccupied, Entry e)
        {
            //Foreach block in our blocks occupied
            for (int i = 0; i < blocksOccupied.Length; i++)
            {
                //Get the value of the block
                uint block = blocksOccupied[i];
                //Create our byte array for our pointer to the next block
                byte[] Bytes = new byte[0];
                //If we have reached the last block in the array...
                if (i == blocksOccupied.Length - 1)
                {
                    //We need to write out that it's the last block, so we do so by writing 0xFF (in accordance to entry size)
                    if (e.PartInfo.EntrySize == Info.PartitionBit.FATX16)
                    {
                        //EOB (end of blocks) for FATX16...
                        Bytes = new byte[] { 0xFF, 0xFF };
                    }
                    else
                    {
                        //EOB for FATX32
                        Bytes = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF };
                    }
                }
                //We have not reached the end block
                else
                {
                    Bytes = BitConverter.GetBytes(blocksOccupied[i + 1]);
                    //Reverse the array so that it will be big endian
                    Array.Reverse(Bytes);
                }

                #region Bascially the WriteBlock Function, modified to check for the next block within the same buffer
                //Write out our next block's byte array at the block's position in the FAT
                //Create our binary reader
                FATX_Browser.FATX.IOReader br = ourDrive.GetIO();
                //Set our position to the block offset in the FAT
                br.BaseStream.Position = m.DownToNearest200(m.BlockToFATOffset(block, e));
                //Get our position in the buffer
                long OffsetInBuffer = m.BlockToFATOffset(block, e) - br.BaseStream.Position;
                //Read our buffer
                byte[] buffer = br.ReadBytes(0x200);
                //Close our binary reader - we're done with it for the drive for now
                br.Close();
                //Create our binary writer for writing to the buffer
                FATX_Browser.FATX.IOWriter bw = new FATX_Browser.FATX.IOWriter(new System.IO.MemoryStream(buffer));
                //Set our position 
                bw.BaseStream.Position = OffsetInBuffer;
                //Write our block
                bw.Write(Bytes);
                bw.Close();
                if (!m.EOF(Bytes, false))
                {
                    i += CheckWriteBuff(ref buffer, m.DownToNearest200(m.BlockToFATOffset(block, e)), blocksOccupied, i + 1, e);
                }
                //Re-open our binary writer in the drive
                bw = ourDrive.GetWriterIO();
                //Set our position
                bw.BaseStream.Position = m.DownToNearest200(m.BlockToFATOffset(block, e));
                //Write our buffer
                bw.Write(buffer);
#endregion
            }
            return true;
        }

        private int CheckWriteBuff(ref byte[] Buffer, long BufferOffset, uint[] allBlocks, int index, Entry e)
        {
            //This will be our return value so that we can tell our other function how
            //many blocks were written
            int blocksWritten = 0;
            //If the offset for the next block's buffer is the same as our current buffer's offset
            if (m.DownToNearest200(m.BlockToFATOffset(allBlocks[index], e)) == BufferOffset)
            {
                //Get our offset in our buffer for the block we're writing to
                long OffsetinBuffer = m.BlockToFATOffset(allBlocks[index], e) - BufferOffset;
                //Create our binary writer
                FATX_Browser.FATX.IOWriter bw = new FATX_Browser.FATX.IOWriter(new System.IO.MemoryStream(Buffer));
                //Go to the offset in the buffer
                bw.BaseStream.Position = OffsetinBuffer;
                //Create our byte array (we do new byte[1] just as a placeholder)
                byte[] BlocktoWrite = new byte[1];
                //If we're on the last block...
                if (index == allBlocks.Length-1)
                {
                    //If we're on a 2-byte block entry
                    if (e.PartInfo.EntrySize == Info.PartitionBit.FATX16)
                    {
                        //Our block to write is the ending block
                        BlocktoWrite = new byte[] { 0xFF, 0xFF };
                    }
                    else
                    {
                        //Our block to write is the ending block
                        BlocktoWrite = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF };
                    }
                }
                    //If we're not on the last block...
                else
                {
                    //Get the next block's value as a byte array
                    BlocktoWrite = BitConverter.GetBytes(allBlocks[index + 1]);
                    //Reverse the array so that it's now in bigendian
                    Array.Reverse(BlocktoWrite);
                }

                //Write out our array
                bw.Write(BlocktoWrite);
                //Close our writer
                bw.Close();
                //If we didn't just write the last block...
                if (index != allBlocks.Length - 1)
                {
                    //Repeat
                    blocksWritten += CheckWriteBuff(ref Buffer, BufferOffset, allBlocks, index + blocksWritten, e);
                }
            }
            return blocksWritten;
        }

        private object[] CheckIfBlocksNeeded(Folder f)
        {
            //Create our object array that will hold our Bool and Entry for if
            //we need an open block, and if there's a deleted file

            //Create our entry reader so that we can get a return of entries...
            Entries e = new Entries(f);
            //Get our entries in the last block
            EntryData[] eData = e.GetEntries(f.BlocksOccupied[f.BlocksOccupied.Length - 1]);
            //Files span upon multiple blocks... Here we go to the last block that it occupies
            //(the most recent block created), and check if it has any open entries
            
            //Check for deleted entries
            foreach (EntryData E in eData)
            {
                if (E.FileNameSize == (byte)Info.FileFlags.Deleted)
                {
                    return new object[] { true, E };
                }
            }
            //We didn't find a deleted entry, but we have room in the last block of the folder
            //for a new entry
            if (eData.Length < 100)
            {
                EntryData newEntry = new EntryData();
                newEntry.EntryOffset = eData[eData.Length - 1].EntryOffset + 0x40;
                newEntry.StartingCluster = eData[eData.Length - 1].StartingCluster;
                return new object[] { false, newEntry };
            }
            //We don't have any deleted entries, and don't have enough room in the last block,
            //so let's create a new block, add it to the FAT chain, etc.

            //Get our new block...
            uint nextBlock = new FATStuff(f).GetFreeBlocks(1, f.BlocksOccupied[f.BlocksOccupied.Length - 1], 0, false)[0];
            //Write the fat chain
            WriteFATChain(new uint[] { f.BlocksOccupied[f.BlocksOccupied.Length - 1], nextBlock}, f);
            //Create our new entrydata
            EntryData EntryNew = new EntryData();
            EntryNew.EntryOffset = m.GetBlockOffset(nextBlock, f);
            return new object[] { false, EntryNew };
        }

        public bool Delete(File f)
        {
            long ProgressUpdate = 0;
            long ProgressMax = 0;
            string CurrentFile = "";
            return DeleteInternal(f, ref ProgressUpdate, ref ProgressMax, ref CurrentFile);
        }

        public bool Delete(File f, ref long ProgressUpdate, ref long ProgressMax, ref string CurrentFile)
        {
            return DeleteInternal(f, ref ProgressUpdate, ref ProgressMax, ref CurrentFile);
        }

        private bool DeleteInternal(File f, ref long progressUpdate, ref long progressMax, ref string CurrentFile)
        {
            return true;
        }

        public bool Delete(Folder f)
        {
            long max = 0;
            long update= 0;
            string s = "";
            return Delete(f, ref update, ref max, ref s);
        }

        public bool Delete(Folder f, ref long ProgressUpdate, ref long ProgressMax, ref string CurrentEntry)
        {
            return DeleteInternal(f, ref ProgressUpdate, ref ProgressMax, ref CurrentEntry);
        }

        private bool DeleteInternal(Folder f, ref long progressUpdate, ref long progressMax, ref string CurrentFile)
        {
            uint[] Occupied = f.BlocksOccupied;
            //Set the max progress
            progressMax = Occupied.Length;
            foreach (File g in f.Files(false))
            {
                progressMax += (uint)g.BlocksOccupied.Length;
            }
            foreach (Folder g in f.SubFolders(false))
            {
                progressMax += (uint)g.BlocksOccupied.Length;
            }
            //Set progress update
            progressUpdate = 0;
            //Mark the blocks as empty
            ClearFATChain(Occupied, f);
             progressUpdate++;

            foreach (Folder g in f.SubFolders(false))
            {
                DeleteInternal(g, ref progressUpdate, ref progressMax, ref CurrentFile);
            }

            foreach (File g in f.Files(false))
            {
                ClearFATChain(g.BlocksOccupied, g);
                progressUpdate++;
            }
            
            return true;
        }

        private bool MarkEntryAsDeleted(Entry e)
        {
            FATX_Browser.FATX.IOReader br = ourDrive.GetIO();
            long position = m.DownToNearest200(e.EntryOffset);
            //Get our offset in our buffer
            long OffsetInBuffer = e.EntryOffset - position;
            br.BaseStream.Position = position;
            //Read our buffer
            byte[] buffer = br.ReadBytes(0x200);
            //Close our binary reader - not needed now
            br.Close();
            //Create our binary writer
            FATX_Browser.FATX.IOWriter bw = new FATX_Browser.FATX.IOWriter(new System.IO.MemoryStream(buffer));
            //Seek to the position in the buffer
            bw.BaseStream.Position = OffsetInBuffer;
            //Write the flag
            bw.Write((byte)Info.FileFlags.Deleted);
            //Close our binary writer
            bw.Close();
            //Re-open our binary writer for the drive
            bw = ourDrive.GetWriterIO();
            //Set our position
            bw.BaseStream.Position = m.DownToNearest200(e.EntryOffset);
            //Write out our buffer
            bw.Write(buffer);
            return true;
        }
        ///We need to make the writing of the blocks and shit little endian so that it will
        ///write it in big endian.  what the fuck.
        //For some reason is the function that writes a FAT chain
        private bool WriteBlock(uint ui, byte[] value, Entry e)
        {
            //Create our binary reader
            FATX_Browser.FATX.IOReader br = ourDrive.GetIO();
            //Set our position to the block offset in the FAT
            br.BaseStream.Position = m.DownToNearest200(m.BlockToFATOffset(ui, e));
            //Get our position in the buffer
            long OffsetInBuffer = m.BlockToFATOffset(ui, e) - br.BaseStream.Position;
            //Read our buffer
            byte[] buffer = br.ReadBytes(0x200);
            //Close our binary reader - we're done with it for the drive for now
            br.Close();
            //Create our binary writer for writing to the buffer
            FATX_Browser.FATX.IOWriter bw = new FATX_Browser.FATX.IOWriter(new System.IO.MemoryStream(buffer));
            //Set our position 
            bw.BaseStream.Position = OffsetInBuffer;
            //Write our block
            bw.Write(value);
            bw.Close();
            //Re-open our binary writer in the drive
            bw = ourDrive.GetWriterIO();
            //Set our position
            bw.BaseStream.Position = m.DownToNearest200(m.BlockToFATOffset(ui, e));
            //Write our buffer
            bw.Write(buffer);
            return true;
        }

        public bool Rename(Entry e, string newName)
        {
            return Rename(e.EntryOffset, newName);
        }


        private bool Rename(long entryOffset, string newName)
        {
            if (m.CheckFileName(newName))
            {
                //Create our binary reader/writer
                FATX_Browser.FATX.IOReader br = ourDrive.GetIO();
                //Round our offset down to the nearest 0x200 boundary so we can read
                //the entry
                //Set our reader to do the same thing
                br.BaseStream.Position = m.DownToNearest200(entryOffset);
                //Split the difference so we can see how far in to our buffer
                //we need to be
                long offsetInBuffer = entryOffset - (m.DownToNearest200(entryOffset));
                //Create our buffer
                byte[] buffer = br.ReadBytes(0x200);
                //Close our reader - we don't need it any more
                br.Close();
                //Create a new binary reader that reads the buffer in memory
                FATX_Browser.FATX.IOWriter memWriter = new FATX_Browser.FATX.IOWriter(new System.IO.MemoryStream(buffer));
                //Set our position to the entry position
                memWriter.BaseStream.Position = offsetInBuffer;
                //Write the file name size
                memWriter.Write((byte)newName.Length);
                //Jump forward one byte and clear the old name
                memWriter.BaseStream.Position++;
                for (int i = 0; i < 0x2A; i++)
                {
                    memWriter.Write((byte)0xFF);
                }
                //Go back to where the file name is
                memWriter.BaseStream.Position = offsetInBuffer + 0x2;
                //Write the new name
                memWriter.Write((byte[])Encoding.ASCII.GetBytes(newName));
                memWriter.Close();
                //Open / set our writer's stuff
                FATX_Browser.FATX.IOWriter bw = ourDrive.GetWriterIO();
                bw.BaseStream.Position = m.DownToNearest200(entryOffset);
                //Write our edited buffer to the drive
                bw.Write((byte[])buffer);
                bw.Close();
                return true;
            }
            else
            {
                throw new Exception("File name not valid");
            }
        }

        public bool WriteNewFile(Folder Root, string FilePath)
        {
            int Garbage=0;
            int Garbage2=0;
            return WriteNewFile(Root, FilePath, ref Garbage, ref Garbage2);
        }

        private EntryData GetNewEntryData(Folder root, string Name)
        {
            if (m.CheckFileName(Name))
            {
                EntryData EData = new EntryData();
                object[] ourObject = CheckIfBlocksNeeded(root);
                //If we need to create a new entry...
                if (!(bool)ourObject[0])
                {
                    //Create our new entrydata that will serve as the EData for the new folder
                    Int32 timeStamp = m.FatTimeInt(DateTime.Now);
                    byte[] ourArray = BitConverter.GetBytes(timeStamp);
                    byte[] CD = new byte[] { ourArray[2], ourArray[3] };
                    byte[] CT = new byte[] { ourArray[0], ourArray[1] };
                    EData.CreationDate = BitConverter.ToUInt16(CD, 0);
                    EData.CreationTime = BitConverter.ToUInt16(CT, 0);
                    EData.FileName = Name;
                    EData.FileNameSize = (byte)Name.Length;
                    EData.Flags = 0x10;
                    EData.Size = 0x0;
                    //Uint for our blocks..
                    uint[] Blocks = new FATStuff(root).GetFreeBlocks(1, ((EntryData)ourObject[1]).StartingCluster, 0, false);
                    //Set our starting cluster using the "GetFreeBlocks" method - tell it we need one block, and the starting block is the block of the previous entry
                    EData.StartingCluster = Blocks[0];
                    //If we're using a block that we just created (the current block for the parent folder
                    //has free space
                    EData.EntryOffset = ((EntryData)ourObject[1]).EntryOffset;
                    //Create a new folder
                    Folder f = new Folder(ourDrive, root.PartInfo);
                    f.EData = EData;
                    f.BlocksOccupied = Blocks;
                    CreateNewEntry(EData);
                    WriteFATChain(f.BlocksOccupied, f);
                }
                //We are using a deleted entry
                else
                {
                    Int32 timeStamp = m.FatTimeInt(DateTime.Now);
                    byte[] ourArray = BitConverter.GetBytes(timeStamp);
                    byte[] CD = new byte[] { ourArray[0], ourArray[1] };
                    Array.Reverse(CD);
                    byte[] CT = new byte[] { ourArray[2], ourArray[3] };
                    Array.Reverse(CT);
                    EData.CreationDate = BitConverter.ToUInt16(CD, 0);
                    EData.CreationTime = BitConverter.ToUInt16(CT, 0);
                    EData.FileName = Name;
                    EData.FileNameSize = (byte)Name.Length;
                    EData.Flags = 0x10;
                    EData.Size = 0x0;
                    EData.StartingCluster = new FATStuff(root).GetFreeBlocks(1, ((EntryData)ourObject[1]).StartingCluster, 0, false)[0];
                    EData.EntryOffset = ((EntryData)ourObject[1]).EntryOffset;
                    Folder f = new Folder(ourDrive, root.PartInfo);
                    f.EData = EData;
                    CreateNewEntry(EData);
                    WriteFATChain(f.BlocksOccupied, f);
                }
                return EData;
            }
            throw new Exception("File name not valid");
        }

        public bool WriteToCluster(int Cluster, byte[] Buffer)
        {
            return WriteToCluster(Cluster * 0x4000, Buffer);
        }

        public bool WriteToCluster(long Offset, byte[] Buffer)
        {
            FATX_Browser.FATX.IOWriter bw = ourDrive.GetWriterIO();
            bw.BaseStream.Position = Offset;
            bw.Write(Buffer);
            bw.Close();
            return true;
        }

        public bool WriteToSector(int Sector, byte[] Buffer)
        {
            return WriteToSector(Sector * 0x200, Buffer);
        }

        public bool WriteToSector(long Offset, byte[] Buffer)
        {
            FATX_Browser.FATX.IOWriter bw = ourDrive.GetWriterIO();
            bw.BaseStream.Position = Offset;
            bw.Write(Buffer);
            bw.Close();
            return true;
        }

        public bool WriteNewFile(Folder Root, string FilePath, ref int Progress, ref int BlocksToWrite)
        {
            FATX_Browser.FATX.IOReader br = null;
            //Do a try...
            try
            {
                //Get our entry
                EntryData EData = GetNewEntryData(Root, new System.IO.FileInfo(FilePath).Name);
                //Create our entry in the folder
                CreateNewEntry(EData);
                //Create our new fatstuff to get our free blocks
                FATStuff fs = new FATStuff(Root);
                //Get our free blocks
                uint[] blocks = fs.GetFreeBlocks((int)(m.UpToNearestCluster(new System.IO.FileInfo(FilePath).Length, Root.PartInfo.ClusterSize) / Root.PartInfo.ClusterSize), EData.StartingCluster, 0, false);
                //Make a new list for the blocks...
                List<uint> COCKS = blocks.ToList<uint>();
                //Insert the beginning block at the 0 index
                COCKS.Insert(0, EData.StartingCluster);
                //Make the cocks an array
                blocks = COCKS.ToArray();
                //Write the FAT chain
                WriteFATChain(blocks, Root);
                //Create our binary reader to read our file
                br = new FATX_Browser.FATX.IOReader(new System.IO.FileStream(FilePath, System.IO.FileMode.Open));
                for (int i = 0; i < blocks.Length; i++)
                {
                    WriteToCluster(m.GetBlockOffset(blocks[i], Root), br.ReadBytes(0x200));
                }
                br.Close();
                return true;
            }
            catch(Exception e)
            {
                try
                {
                    br.Close();
                }
                catch { }
                throw e;
            }
        }

        public bool ClearFATChain(uint[] Blocks, Entry e)
        {
            for (int i = 0; i < Blocks.Length; i++)
            {
                //Open our binary reader to read our buffer
                FATX_Browser.FATX.IOReader br = ourDrive.GetIO();
                //Get the position we should be at for our buffer
                long BufferOffset = m.DownToNearest200(m.BlockToFATOffset(Blocks[i], e));
                //Set our position to the buffer offset
                br.BaseStream.Position = BufferOffset;
                //Read our buffer
                byte[] Buffer = br.ReadBytes(0x200);
                //Close our reader -- we don't need it any more
                br.Close();
                //Open our binary writer in to a memory stream
                FATX_Browser.FATX.IOWriter bw = new FATX_Browser.FATX.IOWriter(new System.IO.MemoryStream(Buffer));
                //Set our position in the buffer to where the actual block is
                bw.BaseStream.Position = m.BlockToFATOffset(Blocks[i], e) - BufferOffset;
                //Write out free block
                if (e.PartInfo.EntrySize == Info.PartitionBit.FATX16)
                {
                    bw.Write(new byte[] { 0x00, 0x00 });
                }
                else
                {
                    bw.Write(new byte[] { 0x00, 0x00 });
                }
                //Close our binary writer
                bw.Close();
                //Check to see if we can write out more blocks from within the buffer, so we 
                //don't have to re-read what we already have
                i += CheckWriteBuffDel(ref Buffer, BufferOffset, Blocks, i + 1, e);
                //Re-open our binary writer, on the drive
                bw = ourDrive.GetWriterIO();
                //Set the position
                bw.BaseStream.Position = BufferOffset;
                //Write out the buffer
                bw.Write(Buffer);
                bw.Close();
            }
            return true;
        }

        public bool OverWriteFile(File FileToOverwrite, string FilePath)
        {
            int p = 0;
            int d = 0;
            return OverWriteFile(FileToOverwrite, FilePath, ref p, ref d);
        }

        public bool OverWriteFile(File FileToOverwrite, string FilePath, ref int Progress, ref int BlocksToWrite)
        {
            FATX_Browser.FATX.IOReader br = null;
            //Do a try...
            try
            {
                //Create our new fatstuff to get our free blocks
                FATStuff fs = new FATStuff(FileToOverwrite);
                //Get our blocks needed
                int BlocksNeeded = (int)(m.UpToNearestCluster(new System.IO.FileInfo(FilePath).Length, FileToOverwrite.PartInfo.ClusterSize) / FileToOverwrite.PartInfo.ClusterSize);
                //Create our block array for the blocks we do have
                uint[] BlocksWeHave = FileToOverwrite.BlocksOccupied;
                //If we have more blocks than we need already...
                if ((int)FileToOverwrite.BlocksOccupied.Length > BlocksNeeded)
                {
                    //Get our blocks that we're going to clear...
                    List<uint> BlocksList = FileToOverwrite.BlocksOccupied.ToList<uint>();
                    //Remove the blocks we need from the list of blocks to overwrite
                    BlocksList.RemoveRange(0x0, (int)((int)FileToOverwrite.BlocksOccupied.Length - BlocksNeeded));
                    //Finalize
                    uint[] BlocksToFree = BlocksList.ToArray();
                    //Clears the blocks.
                    ClearFATChain(BlocksToFree, FileToOverwrite);
                    //Make the final block in the series the ending block by writing 0xFFFF to it
                    uint EndBlock = FileToOverwrite.BlocksOccupied[(FileToOverwrite.BlocksOccupied.Length - 1) - BlocksNeeded];
                    if (FileToOverwrite.PartInfo.EntrySize == Info.PartitionBit.FATX16)
                    {
                        WriteBlock(EndBlock, new byte[] { 0xFF, 0xFF }, FileToOverwrite);
                    }
                    else
                    {
                        WriteBlock(EndBlock, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF }, FileToOverwrite);
                    }
                    BlocksList = FileToOverwrite.BlocksOccupied.ToList<uint>();
                    BlocksList.RemoveRange(0x0, (FileToOverwrite.BlocksOccupied.Length - 1) - BlocksNeeded);
                    BlocksWeHave = BlocksList.ToArray();
                }
                else if ((int)FileToOverwrite.BlocksOccupied.Length < BlocksNeeded)
                {
                    //Get the number of blocks we REALLY need
                    int RealBlocksNeeded = BlocksNeeded - FileToOverwrite.BlocksOccupied.Length;
                    //Write out the FAT chain from that last block
                    List<uint> bl = new List<uint>();
                    bl.Add(FileToOverwrite.BlocksOccupied[FileToOverwrite.BlocksOccupied.Length - 1]);
                    uint[] newBlocks = new FATStuff(FileToOverwrite).GetFreeBlocks(RealBlocksNeeded, bl[0], 0, false);
                    bl.AddRange(newBlocks);
                    //Set the BlocksWeHave
                    BlocksWeHave = bl.ToArray();
                }
                //Create our binary reader to read our file
                br = new FATX_Browser.FATX.IOReader(new System.IO.FileStream(FilePath, System.IO.FileMode.Open));
                for (int i = 0; i < BlocksWeHave.Length; i++)
                {
                    WriteToCluster(m.GetBlockOffset(BlocksWeHave[i], FileToOverwrite), br.ReadBytes(0x200));
                }
                br.Close();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    br.Close();
                }
                catch { }
                throw e;
            }
        }

        private int CheckWriteBuffDel(ref byte[] Buffer, long BufferOffset, uint[] allBlocks, int index, Entry e)
        {
            //This will be our return value so that we can tell our other function how
            //many blocks were written
            int blocksWritten = 0;
            //If the offset for the next block's buffer is the same as our current buffer's offset
            if (m.DownToNearest200(m.BlockToFATOffset(allBlocks[index], e)) == BufferOffset)
            {
                //Get our offset in our buffer for the block we're writing to
                long OffsetinBuffer = m.BlockToFATOffset(allBlocks[index], e) - BufferOffset;
                //Create our binary writer
                FATX_Browser.FATX.IOWriter bw = new FATX_Browser.FATX.IOWriter(new System.IO.MemoryStream(Buffer));
                //Go to the offset in the buffer
                bw.BaseStream.Position = OffsetinBuffer;
                //Create our byte array (we do new byte[1] just as a placeholder)
                byte[] BlocktoWrite = new byte[1];
                //If we're on a 2-byte block entry
                if (e.PartInfo.EntrySize == Info.PartitionBit.FATX16)
                {
                    //Our block to write is the ending block
                    BlocktoWrite = new byte[] { 0x00, 0x00 };
                }
                else
                {
                    //Our block to write is the ending block
                    BlocktoWrite = new byte[] { 0x00, 0x00, 0x00, 0x00 };
                }
                //Write out our array
                bw.Write(BlocktoWrite);
                //Close our writer
                bw.Close();
                //If we didn't just write the last block...
                if (index != allBlocks.Length - 1)
                {
                    //Repeat
                    blocksWritten += CheckWriteBuff(ref Buffer, BufferOffset, allBlocks, index + blocksWritten, e);
                }
            }
            return blocksWritten;
        }
    }
}
