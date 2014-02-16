﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsWebAdmin.Core.TaskManager
{
    public class Task
    {
        public string Name { get; set;  }
        public int ProcessId { get; set; }
        public long PrivateMemory { get; set; }
        public long WorkingSet { get; set; }
        public TimeSpan ProcessorTime { get; set; }
    }
}
