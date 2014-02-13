using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsWebAdmin.Core.Cpu
{
    public class Info
    {
        public int Cores { get; set; }
        public decimal Speed { get; set; }
        public decimal CurrentSpeed { get; set; }
        public string Name { get; set; }
        public int Load { get; set; }
    }
}
