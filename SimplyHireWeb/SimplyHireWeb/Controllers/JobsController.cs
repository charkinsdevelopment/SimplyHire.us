using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyHireWeb.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyJobs()
        {
            return View();
        }

        public ActionResult Browse()
        {
            return View();
        }
    }
}