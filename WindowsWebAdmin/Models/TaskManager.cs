using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WindowsWebAdmin.Core;
using WindowsWebAdmin.Core.TaskManager;

namespace WindowsWebAdmin.Models
{
    public class TaskManager : ModelBase
    {
        public TaskList Tasks { get; set; }        
    }
}