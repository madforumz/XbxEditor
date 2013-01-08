using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using FATX_Browser.Win32;
using Microsoft.Win32.SafeHandles;
using System.IO;

namespace FATX_Browser.FATX
{
    class IO
    {

        public class HDDFATX
        {
            private long driveSize;
            protected internal System.IO.Stream fs;
            protected internal FATX_Browser.FATX.IOReader br;
            protected internal FATX_Browser.FATX.IOWriter bw;
            SafeFileHandle diskDrive;
            private bool Dump;
            private string DumpPath;

            public HDDFATX(bool dump, string dumpPath)
            {
                if (dump)
                {
                    Dump = dump;
                    DumpPath = dumpPath;
                }
            }

            #region Get FATX Drives

            /// <summary>
            /// Returns an array of valid FATXDrives
            /// </summary>
            public FATX.FATXDrive[] GetFATXDrives(int range)
            {
                List<FATX.FATXDrive> driveList = new List<FATX.FATXDrive>();
                ///Gets physical disks
                for (int i = 0; i < range; i++)
                {
                    try
                    {
                        //Start reading the physical drive
                        fs = fs_diskStream(i);
                        br = br_diskReader(i);
                        //Seek to the FATX partition
                        //try
                        //{
                            br.BaseStream.Position = (long)FATX.Info.HDDFATX.Partitions.Data;
                            //Read the header
                            byte[] header = br.ReadBytes(0x4);
                            //Convert the header to a string, check if it's fatx
                            if (Encoding.ASCII.GetString(header) == "XTAF")
                            {
                                FATX.FATXDrive drive = new FATXDrive(i, FATX.Info.DriveType.HDD);
                                driveList.Add(drive);
                            }
                        //}
                        //catch{ }
                        br.Close();
                        fs.Close();
                        diskDrive.Close();
                        bool closed = diskDrive.IsClosed;
                    }
                    catch { fs.Close(); br.Close(); diskDrive.Close(); }
                }
                ///Gets usb drives
                List<string> driveLetters = new List<string>();
                char[] DriveLetters = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
                //Loop for each possible drive letter
                for (int i = 0; i < DriveLetters.Length; i++)
                {
                    //Create a new drive info
                    DriveInfo di = new DriveInfo(DriveLetters[i].ToString());
                    //If the drive doesn't exist, it will return false, so if it's true, it exists
                    if (di.IsReady)
                    {
                        //Add it to the drive letters
                        driveLetters.Add(DriveLetters[i].ToString());
                    }
                }
                ///Check to see if the drive has a subdirectory of "Xbox360"
                List<string> indexesToRemove = new List<string>();
                for (int i = 0; i < driveLetters.Count; i++)
                {
                    //If the directory does not exist
                    DirectoryInfo di = new DirectoryInfo(driveLetters[i] + ":\\Xbox360");
                    if (!di.Exists)
                    {
                        //Remove the drive from the list
                        indexesToRemove.Add(driveLetters[i]);
                    }
                    else
                    {
                        //Check to make sure that there's actually files in that directory..
                        FileInfo[] fi = di.GetFiles();
                        if (fi[0].Name != "Data0000")
                        {
                            indexesToRemove.Add(driveLetters[i]);
                        }
                    }
                }
                for (int i = 0; i < indexesToRemove.Count; i++)
                {
                    driveLetters.Remove(indexesToRemove[i]);
                }
                ///Finally create our new FATXDrive...
                for (int i = 0; i < driveLetters.Count; i++)
                {
                    driveList.Add(new FATXDrive(driveLetters[i] + ":\\Xbox360", Info.DriveType.USB));
                }
                return driveList.ToArray();
            }

            #endregion

            #region Get Drive Size

            /// <summary>
            /// Returns the size of a HDD
            /// </summary>
            public long GetDriveSize(int deviceNumber)
            {
                API api = new API();
                var diskGeo = new API.DISK_GEOMETRY();
                bool result = api.GetDriveGeometry(ref diskGeo, deviceNumber, CreateHandle(deviceNumber));
                return diskGeo.DiskSize;
            }

            public long GetDriveSize()
            {
                return fs.Length;
            }

            public long GetUSBSize()
            {
                return driveSize;
            }

            #endregion

            #region File Stream/Binary Reader
            /// <summary>
            /// Stream for the disk
            /// </summary>
            protected internal System.IO.Stream fs_diskStream(int deviceNumber)
            {
                CreateHandle(deviceNumber);
                fs = new System.IO.FileStream(diskDrive, System.IO.FileAccess.ReadWrite);
                return fs;
            }

            protected internal System.IO.Stream fs_dumpStream()
            {
                try { fs.Close(); }
                catch { }
                fs = new System.IO.FileStream(DumpPath, FileMode.Open);
                return fs;
            }

            /// <summary>
            /// Returns a binary reader to read the disk
            /// </summary>
            protected internal FATX_Browser.FATX.IOReader br_diskReader(int deviceNumber)
            {
                br = new FATX_Browser.FATX.IOReader(fs_diskStream(deviceNumber));
                return br;
            }

            protected internal FATX_Browser.FATX.IOReader br_dumpReader()
            {
                try { br.Close(); }
                catch { }
                br = new FATX_Browser.FATX.IOReader(fs_dumpStream());
                try
                {
                    driveSize = br.BaseStream.Length;
                }
                catch { }
                return br;
            }

            /// <summary>
            /// Returns a binary writer to write to the disk
            /// </summary>
            protected internal FATX_Browser.FATX.IOWriter bw_diskWriter(int deviceNumber)
            {
                try { bw.Close(); }
                catch { }
                bw = new FATX_Browser.FATX.IOWriter(fs_diskStream(deviceNumber));
                return bw;
            }

            protected internal FATX_Browser.FATX.IOWriter bw_dumpWriter()
            {
                try { bw.Close(); }
                catch { }
                bw = new FATX_Browser.FATX.IOWriter(fs_dumpStream());
                try
                {
                    driveSize = bw.BaseStream.Length;
                }
                catch { }
                return bw;
            }

            /// <summary>
            /// Creates and returns a new handle for reading a drive
            /// </summary>
            public SafeFileHandle CreateHandle(int deviceNumber)
            {
                try { diskDrive.Close(); }
                catch{};
                diskDrive = API.CreateFile(@"\\.\PhysicalDrive" + deviceNumber.ToString(), System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite, IntPtr.Zero, System.IO.FileMode.Open, API.FlagsAndAttributes.Device | API.FlagsAndAttributes.NoBuffering | API.FlagsAndAttributes.Write_Through, IntPtr.Zero);
                return diskDrive;
            }

            #endregion

            /// <summary>
            /// Closes the readers/handles
            /// </summary>
            public bool Close()
            {
                try
                {
                    fs.Close();
                    br.Close();
                    bw.Close();
                    diskDrive.Close();
                    return true;
                }
                catch { return true; }
            }
        }
    }

    #region IO
    public class IOWriter : System.IO.BinaryWriter
    {
        public IOWriter(string[] ye):base(new IOStream(ye, System.IO.FileMode.Open))
        {

        }

        public IOWriter(Stream stream):base(stream)
        {
            
        }
    }

    public class IOReader : System.IO.BinaryReader
    {
        public IOReader(string[] ye):base(new IOStream(ye, System.IO.FileMode.Open))
        {

        }

        public IOReader(Stream stream):base(stream)
        {

        }
    }

    internal class IOStream : System.IO.Stream
    {
        int CurrentStream = 1;
        System.IO.FileStream[] streams;
        public IOStream(string[] filePaths, System.IO.FileMode mode)
            : base()
        {
            streams = new FileStream[filePaths.Length];
            //base.Close();
            for (int i = 0; i < streams.Length; i++)
            {
                streams[i] = new FileStream(filePaths[i], mode);
            }
        }

        public override void Close()
        {
            //base.Close();
            for (int i = 0; i < streams.Length; i++)
            {
                streams[i].Close();
            }
            base.Close();
        }

        public override long Length
        {
            get
            {
                long lengths = 0;
                for (int i = 0; i < streams.Length; i++)
                {
                    lengths += streams[i].Length;
                }
                return lengths;
            }
        }

        public override long Position
        {
            get
            {
                //We didn't return the value, we must be looking at a USB drive
                //For each stream, add up their lengths until we reach our current stream
                long lengths = 0;
                for (int i = 0; i < CurrentStream - 1; i++)
                {
                    lengths += streams[i].Length;
                }
                lengths += streams[CurrentStream - 1].Position;
                return lengths;
            }
            set
            {
                //First, we need to set our base, and our current stream.  So we need to determine
                //which base we need to be on...
                long LengthRemaining = value + 1;
                for (int i = 0; i < streams.Length; i++)
                {
                    //If the length remaining is larger than our current stream, then we couldn't
                    //possibly use that stream, so reduce the length remaining by the stream's length
                    //, and move on
                    if (LengthRemaining > streams[i].Length)
                    {
                        LengthRemaining -= streams[i].Length;
                    }
                    //This stream's length is larger than the length remaining, or equal to
                    //so, this must be the stream
                    else
                    {
                        CurrentStream = i + 1;
                        break;
                    }
                }
                long lengths = value + 1;
                for (int i = 0; i < CurrentStream - 1; i++)
                {
                    lengths -= streams[i].Length;
                }
                streams[CurrentStream - 1].Position = lengths - 1;
            }
        }

        public override void Write(byte[] array, int offset, int count)
        {
            if (array.Length > (streams[CurrentStream - 1].Length - streams[CurrentStream - 1].Position))
            {
                long DataRemaining = array.Length;
                int Offset = offset;
                int SpansAcrossFiles = 0;
                for (int i = CurrentStream - 1; i < streams.Length; i++, SpansAcrossFiles++)
                {
                    if (streams[i].Length < DataRemaining)
                    {
                        DataRemaining -= streams[i].Length;
                    }
                    else
                    {
                        DataRemaining = array.Length;
                        SpansAcrossFiles++;
                        break;
                    }
                }
                for (int j = 0; j < SpansAcrossFiles; j++)
                {
                    if (j != SpansAcrossFiles - 1)
                    {
                        //Calculate the data we can write
                        long DataWeCanRead = streams[CurrentStream - 1].Length - streams[CurrentStream - 1].Position;
                        //Get that much data in to a byte array
                        streams[CurrentStream - 1].Write(array, Offset, (int)DataWeCanRead);
                        DataRemaining -= DataWeCanRead;
                        Offset += (int)DataWeCanRead;
                        CurrentStream++;
                    }
                    else
                    {
                        streams[CurrentStream - 1].Read(array, Offset, (int)DataRemaining);
                    }
                }
            }
            else
            {
                streams[CurrentStream - 1].Write(array, offset, count);
            }
        }

        public override void WriteByte(byte value)
        {
            streams[CurrentStream - 1].WriteByte(value);
        }

        public override void Flush()
        {
            streams[CurrentStream - 1].Flush();
        }

        public override int ReadByte()
        {
            return streams[CurrentStream - 1].ReadByte();
        }

        public override int Read(byte[] array, int offset, int count)
        {
            if (array.Length > (streams[CurrentStream - 1].Length - streams[CurrentStream - 1].Position))
            {
                int ReturnValue = 0;
                long DataRemaining = array.Length;
                int Offset = offset;
                int SpansAcrossFiles = 0;
                for (int i = CurrentStream - 1; i < streams.Length; i++, SpansAcrossFiles++)
                {
                    if (streams[i].Length < DataRemaining)
                    {
                        DataRemaining -= streams[i].Length;
                    }
                    else
                    {
                        DataRemaining = array.Length;
                        SpansAcrossFiles++;
                        break;
                    }
                }
                for (int j = 0; j < SpansAcrossFiles; j++ )
                {
                    if (j != SpansAcrossFiles - 1)
                    {
                        //Calculate the data we can write
                        long DataWeCanRead = streams[CurrentStream - 1].Length - streams[CurrentStream - 1].Position;
                        //Get that much data in to a byte array
                        ReturnValue += streams[CurrentStream - 1].Read(array, Offset, (int)DataWeCanRead);
                        DataRemaining -= DataWeCanRead;
                        Offset += (int)DataWeCanRead;
                        CurrentStream++;
                    }
                    else
                    {
                        ReturnValue += streams[CurrentStream - 1].Read(array, Offset, (int)DataRemaining);
                    }
                }
                return ReturnValue;
            }
            else
            {
                int returnval = streams[CurrentStream - 1].Read(array, offset, count);
                return returnval;
            }
        }

        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return streams[CurrentStream - 1].BeginRead(buffer, offset, count, callback, state);
        }

        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return streams[CurrentStream - 1].BeginWrite(buffer, offset, count, callback, state);
        }

        public override bool CanRead
        {
            get { return streams[CurrentStream - 1].CanRead; }
        }

        public override bool CanSeek
        {
            get { return streams[CurrentStream - 1].CanSeek; }
        }

        public override bool CanWrite
        {
            get { return streams[CurrentStream - 1].CanWrite; }
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            if (origin == SeekOrigin.Begin)
            {
                Position = offset;
            }
            else if (origin == SeekOrigin.Current)
            {
                Position += offset;
            }
            else if (origin == SeekOrigin.End)
            {
                Position = Length - offset;
            }
            return Position;
        }
    }
    #endregion
}
