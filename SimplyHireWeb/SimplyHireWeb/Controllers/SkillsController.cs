using SimplyHireWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyHireWeb.Controllers
{
    public class SkillsController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
       [HttpPost]
       public JsonResult GetSuggestedSkills(string skillname)
        {
            if (skillname == "") return null;
            string suggestion = "";
            int count = 0;

            var results = _db.Skills.Where(f => f.Name.StartsWith(skillname)).ToList();

            count = results.Count();
            suggestion = results.Count > 0 ? results.First().Name : "";

            return Json(new { skillName = suggestion, resultCount = count });
        }
    }
}