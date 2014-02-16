using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsWebAdmin.Core.Disk
{
    public class Info
    {
        public DriveType Type { get; set; }
        public string Name { get; set; }
        public long? TotalFreeSpace { get; set; }
        public long? TotalSize { get; set; }
        public string VolumeLabel { get; set; }
        public long? AvailableFreeSpace { get; set; }
        public string DriveFormat { get; set; }
    }
}
