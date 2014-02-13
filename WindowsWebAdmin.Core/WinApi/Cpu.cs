using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using WindowsWebAdmin.Core.Cpu;

namespace WindowsWebAdmin.Core.WinApi
{
    public static class Cpu
    {
        public static List<Info> GetCpuInfo()
        {
            var lst = new List<Info>();
            var searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject s in searcher.Get())
            {
                var i = new Info();
                i.Name = s.GetPropertyValue("Name").ToString();
                i.Cores = Convert.ToInt32(s.GetPropertyValue("NumberOfCores").ToString());
                i.Speed = Convert.ToDecimal(s.GetPropertyValue("MaxClockSpeed").ToString());
                i.CurrentSpeed = Convert.ToDecimal(s.GetPropertyValue("CurrentClockSpeed").ToString());
                i.Load = Convert.ToInt32(s.GetPropertyValue("LoadPercentage").ToString());
                lst.Add(i);                
            }

            return lst;
        }
    }
}
