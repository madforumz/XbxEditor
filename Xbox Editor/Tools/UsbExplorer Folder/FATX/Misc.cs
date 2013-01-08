using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FATX_Browser.FATX;
using System.Windows.Forms;
using System.Drawing;

namespace FATX_Browser.FATX
{
    class Misc
    {
        /// <summary>
        /// Returns a user-friendly (KB/MB/GB) number
        /// </summary>
        public string ByteConversion(long byteSize)
        {
            decimal size = byteSize;
            string returnVal = "";
            //There's 0x400 bytes in a kilobyte, 0x400 KB in a MB, 0x400 MB in a GB
            //if the size is below 1KB
            if ((size / 0x400) < 1)
            {
                returnVal = size.ToString() + " bytes";
            }
            //If the size is above 1KB
            if (size / 0x400 > 1)
            {
                size = size / 0x400;
                returnVal = size.ToString("#.00") + " KB";
            }

            //if the size is above 1MB
            if (size / 0x400 > 1)
            {
                size = size / 0x400;
                returnVal = size.ToString("#.00") + " MB";
            }

            //If the size is bigger than 1GB
            if (size / 0x400 > 1)
            {
                size = size / 0x400;
                returnVal = size.ToString("#.00") + " GB";
            }

            return returnVal;
        }

        /// <summary>
        /// Returns the offset within the FAT of the next block
        /// </summary>
        /// <param name="baseBlock">The root block for the entry</param>
        public long BlockToFATOffset(uint baseBlock, PartitionInfo PartInfo)
        {
            long rVal = baseBlock * (int)PartInfo.EntrySize;
            rVal += PartInfo.FATOffset;
            return rVal;
        }

        public long BlockToFATOffset(uint BaseBlock, Entry e)
        {
            return BlockToFATOffset(BaseBlock, e.PartInfo);
        }

        /// <summary>
        /// Returns the remaining size of a file/folder
        /// </summary>
        public long RemainingData(File f)
        {
            long length = (long)(f.BlocksOccupied.Length - 1) * f.PartInfo.ClusterSize;
            return f.Size - length;
        }

        /// <summary>
        /// Converts cluster (block) number to offset
        /// </summary>
        public long GetBlockOffset(uint block, FATX.PartitionInfo pinfo)
        {
            //The way that FATX works is that the root block is considered block 0,
            //so let's think about this like an array...  if the block is reading block
            //2, then it's really block 1 in an array
            block--;
            long rVal = (pinfo.DataOffset + ((long)block * pinfo.ClusterSize));
            return rVal;
        }

        public bool EOF(byte[] buffer, bool Entry)
        {
            int NoOfFF = 0;
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] == 0xFF)
                {
                    NoOfFF++;
                }
                else if (i == buffer.Length - 1)
                {
                    if (buffer[i] == 0xF8)
                    {
                        NoOfFF++;
                    }
                }
            }

            if (NoOfFF == buffer.Length)
            {
                return true;
            }

            if (Entry)
            {
                if (buffer[0] > 0x2A && buffer[0] != 0xE5)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Converts cluster (block) number to offset
        /// </summary>
        public long GetBlockOffset(uint block, Entry e)
        {
            return GetBlockOffset(block, e.PartInfo);
        }

        /// <summary>
        /// ReadUInt32 (big endian)
        /// </summary>
        public uint ReadUInt32(ref FATX_Browser.FATX.IOReader br)
        {
            byte[] bytes = br.ReadBytes(0x4);
            Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0x0);
        }

        public short ReadInt16(ref FATX_Browser.FATX.IOReader br)
        {
            byte[] bytes = br.ReadBytes(0x2);
            Array.Reverse(bytes);
            return BitConverter.ToInt16(bytes, 0x0);
        }

        public ushort ReadUInt16(ref FATX_Browser.FATX.IOReader br)
        {
            byte[] bytes = br.ReadBytes(0x2);
            Array.Reverse(bytes);
            return BitConverter.ToUInt16(bytes, 0x0);
        }

        /// <summary>
        /// ReadInt32 (big endian)
        /// </summary>
        public int ReadInt32(ref FATX_Browser.FATX.IOReader br)
        {
            byte[] bytes = br.ReadBytes(0x4);
            Array.Reverse(bytes);
            return BitConverter.ToInt32(bytes, 0x0);
        }

        /// <summary>
        /// Used for quickly reading bytes for a length that is not a multiple of 0x200
        /// </summary>
        internal byte[] ReadBytes(ref FATX_Browser.FATX.IOReader br, long length)
        {
            Misc m = new Misc();
            m.UpToNearest200(length);
            byte[] buffer = br.ReadBytes((int)length);
            List<byte> bl = buffer.ToList<byte>();
            bl.RemoveRange((int)(length - 1), (int)(buffer.Length - length));
            buffer = bl.ToArray();
            return buffer;
        }

        public ImageList ListForFATX
        {
            get
            {
                ImageList i = new ImageList();
                Image[] images = { FATX_Browser.Properties.Resources.fatx_folder, FATX_Browser.Properties.Resources.fatx_file, FATX_Browser.Properties.Resources.fatx_camera, Properties.Resources.fatx_database };
                i.Images.AddRange(images);
                return i;
            }
        }

        /// <summary>
        /// Rounds a number down to the nearest 0x200 byte boundary
        /// </summary>
        public long DownToNearest200(long val)
        {
            return (val -= (val % 0x200));
        }

        /// <summary>
        /// Rounds a number up to the nearest 0x200 byte boundary
        /// </summary>
        public long UpToNearest200(long val)
        {
            return (val += 0x200 - (val % 0x200));
        }

        /// <summary>
        /// Rounds a number up to the nearest 0x200 byte boundary
        /// </summary>
        public long UpToNearestCluster(long val, long ClusterSize)
        {
            return (val += ClusterSize - (val % ClusterSize));
        }

        public int FatTimeInt(DateTime OurDateTime)
        {
            if (OurDateTime.Year < 1980)
            {
                OurDateTime = new DateTime(1980, OurDateTime.Month, OurDateTime.Day, OurDateTime.Hour, OurDateTime.Minute, OurDateTime.Second);
            }
            int Date = ((((int)OurDateTime.Year - 1980) - 1980 << 9 | ((int)OurDateTime.Month << 5) | (int)OurDateTime.Day));
            int Time = ((((int)OurDateTime.Hour << 11) | ((int)OurDateTime.Minute << 5) | ((int)OurDateTime.Second)));
            return ((Date<< 16) | Time);
        }

        public DateTime GetDateTimeFromNum(ushort date, ushort time)
        {
            //If they're both zero, then we don't have a date.
            if (date == 0 && time == 0)
            {
                return DateTime.Now;
            }
            //We didn't return the date, so ye
            //We mask the upper 8 bits to get only bits 9-15, then shift them to the right 9 times to get the number
            //of years past 2000
            int year = ((date & 0xFE00) >> 9) + 1980;
            int month = (date & 0x1E0) >> 5;
            int day = (date & 0x1F);
            int hour = (time & 0xF800) >> 11;
            int minute = (time & 0x7E0) >> 5;
            int second = (time & 0x1F) * 2;
            return new DateTime(year, month, day, hour, minute, second);
        }

        /// <summary>
        /// Checks to make sure the file name is valid for FATX/STFS
        /// </summary>
        public bool CheckFileName(string name)
        {
            //If the string is empty, or over ...
            if (name == null)
            {
                return false;
            }
            if ( name == "" | name.Length > 0x2A)
            {
                return false;
            }
            try
            {
                byte[] stringBytes = Encoding.ASCII.GetBytes(name);
                for (int i = 0; i < 0x80; i++)
                {
                    for (int j = 0; i < stringBytes.Length; i++)
                    {
                        //Don't check the characters we want them to use
                        if (j == 0x20 | j == 0x24 | j == 0x2E | j == 0x5A | j == 0x5F)
                        {
                            j++;
                        }

                        if (j == 0x30)
                        {
                            j = 0x3A;
                        }

                        if (j == 0x41)
                        {
                            j = 0x5B;
                        }

                        if (j == 0x61)
                        {
                            j = 0x7B;
                        }

                        //If the character is a character we don't want them to use
                        if (stringBytes[i] == j)
                        {
                            //Report invalid
                            return false;
                        }

                        if (stringBytes[i] > 0x7A)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            catch { return false; }
        }
    }
}
