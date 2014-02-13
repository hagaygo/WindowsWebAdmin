using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Web;
using System.Web.Mvc;
using WindowsWebAdmin.Core.TaskManager;
using WindowsWebAdmin.Core.WinApi;

namespace WindowsWebAdmin.Controllers
{
    public class TaskManagerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TaskList()
        {
            var tm = new WindowsWebAdmin.Models.TaskManager();
            tm.Tasks = GetRunningTasks();
            tm.FillBaseData();
            return View(tm);
        }

        TaskList GetRunningTasks()
        {
            var tl = new TaskList();
            var processlist = Process.GetProcesses();

            foreach (Process p in processlist)
            {
                var t = new Task();
                t.Name = p.ProcessName;
                t.ProcessId = p.Id;         
                tl.Add(t);
            }

            return tl;
        }        
    }
}
