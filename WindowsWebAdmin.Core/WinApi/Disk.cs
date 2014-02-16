using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsWebAdmin.Core.WinApi
{
    public static class Disk
    {
        public static List<WindowsWebAdmin.Core.Disk.Info> GetDisks()
        {
            var lst = new List<WindowsWebAdmin.Core.Disk.Info>();
            foreach (var di in System.IO.DriveInfo.GetDrives())
            {
                var i = new WindowsWebAdmin.Core.Disk.Info();
                i.Type = di.DriveType;
                i.Name = di.Name;                                
                if (di.IsReady)
                {
                    i.VolumeLabel = di.VolumeLabel;
                    i.TotalFreeSpace = di.TotalFreeSpace;
                    i.TotalSize = di.TotalSize;
                    i.AvailableFreeSpace = di.AvailableFreeSpace;
                    i.DriveFormat = di.DriveFormat;
                }
                lst.Add(i);
            }
            return lst;
        }
    }
}
