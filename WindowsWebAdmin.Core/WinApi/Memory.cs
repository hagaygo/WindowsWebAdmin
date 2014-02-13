using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsWebAdmin.Core.Memory;

namespace WindowsWebAdmin.Core.WinApi
{
    public static class Memory
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        struct MEMORYSTATUSEX
        {
            public uint dwLength;        
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
        }

        [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "GlobalMemoryStatusEx")]
        [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);

        public static Info GetMemoryInfo()
        {
            var i = new Info();
            var data = new MEMORYSTATUSEX();
            data.dwLength = 64;
            GlobalMemoryStatusEx(ref data);
            i.AvailableRam = data.ullAvailPhys;
            i.TotalRam = data.ullTotalPhys;
            i.UsedVirtualMemory = data.ullTotalPageFile - data.ullTotalPhys;
            i.AvailableVirtualMemory = data.ullAvailPhys - data.ullAvailPageFile;
            return i;
        }
    }
}
