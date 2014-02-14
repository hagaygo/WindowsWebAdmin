using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WindowsWebAdmin.Controllers
{
    public class DiskController : Controller
    {        
        public ActionResult Index()
        {
            return Info();
        }

        public ActionResult Info()
        {
            var i = new WindowsWebAdmin.Models.Disk();
            i.FillBaseData();
            return View(i);
        }
	}
}