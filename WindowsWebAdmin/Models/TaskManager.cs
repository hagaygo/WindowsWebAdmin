using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WindowsWebAdmin.Core.TaskManager;

namespace WindowsWebAdmin.Models
{
    public class TaskManager
    {
        public TaskList Tasks { get; set; }
        public WindowsWebAdmin.Core.Memory.Info Memory { get; set; }
    }
}