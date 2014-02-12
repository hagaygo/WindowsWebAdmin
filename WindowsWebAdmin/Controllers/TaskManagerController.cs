using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WindowsWebAdmin.Core.TaskManager;

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
            var tl = new TaskList();
            tl.Add(new Task() { Name = "bla"});
            tl.Add(new Task() { Name = "bla2" });
            tl.Add(new Task() { Name = "bla3" });
            return View(tl);
        }
	}
}
