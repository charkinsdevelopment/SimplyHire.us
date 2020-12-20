using SimplyHireWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyHireWeb.Controllers
{
    public class SearchController : Controller
    {
        [HttpPost]
        public ActionResult Jobs(HomeMainViewModel vm)
        {
            SearchResultsViewModel viewModel = new SearchResultsViewModel();
            return View("Results", viewModel);
        }

        [HttpPost]
        public ActionResult Skills(HomeMainViewModel vm)
        {
            SearchResultsViewModel viewModel = new SearchResultsViewModel();
            return View("Results", viewModel);
        }
    }
}