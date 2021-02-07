using SimplyHireWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyHireWeb.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Profile
        public ActionResult Index(string Id)
        {
            var user = _db.Users.First(f => f.Id == Id);
            return View(user);
        }
    }
}