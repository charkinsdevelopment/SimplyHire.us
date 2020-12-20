using SimplyHireWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyHireWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeMainViewModel vm = new HomeMainViewModel();
            //testing
            vm.CompanyCount = 30;
            vm.EmployeeCount = 120;
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}