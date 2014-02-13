using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsWebAdmin.Core.Memory
{
    public class Info
    {
        public ulong TotalRam { get; set;  }
        public ulong AvailableRam { get; set; }
        public ulong UsedRam 
        {
            get { return TotalRam - AvailableRam; }
        }
        public ulong UsedVirtualMemory { get; set; }
        public ulong AvailableVirtualMemory { get; set; }        
    }
}
