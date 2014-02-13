using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindowsWebAdmin.Models
{
    public class ProgressData
    {
        public ProgressData()
        {
            WidthInPixels = 150;
            HeightInPixels = 20;
        }
        public int HeightInPixels { get; set; }
        public int WidthInPixels { get; set; }
        public ulong Value { get; set; }
        public ulong Max { get; set; }
    }
}