using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsWebAdmin.Core
{
    public abstract class ModelBase
    {
        public WindowsWebAdmin.Core.Memory.Info Memory { get; set; }
        public List<WindowsWebAdmin.Core.Cpu.Info> Cpu { get; set; }

        public void FillBaseData()
        {
            Memory = WindowsWebAdmin.Core.WinApi.Memory.GetMemoryInfo();
            Cpu = WindowsWebAdmin.Core.WinApi.Cpu.GetCpuInfo();
        }
    }
}
