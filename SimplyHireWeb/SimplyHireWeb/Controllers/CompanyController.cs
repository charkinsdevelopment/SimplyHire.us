using SimplyHireWeb.Models;
using SimplyHireWeb.Models.CompanyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyHireWeb.Controllers
{
    public class CompanyController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyJobs()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult GetCompanyJobs(int companyId)
        {
            var jobs = _db.Jobs.Where(f => f.CompanyId == companyId).OrderBy(f => f.Title);
            JobListViewModel vm = new JobListViewModel();
            return PartialView("~/Views/Company/_CompanyJobList.cshtml", vm);
        }

        public ActionResult AddJob()
        {
            AddJobViewModel vm = new AddJobViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddJob(AddJobViewModel vm) 
        {
            return View();
        }
    }
}