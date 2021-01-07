using Microsoft.AspNet.Identity;
using SimplyHireWeb.Models;
using SimplyHireWeb.Models.DbModels;
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
        private readonly string _currentUser = System.Web.HttpContext.Current.User.Identity.GetUserId();

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

        [HttpPost]
        public bool AddSkill(string SkillName, string Skill, string YearsExperience)
        {
            bool exists = _db.Skills.Any(f => f.Name == SkillName);
            Skill skill = new Skill();
            if (!exists)
            {
                //create if not existing
                skill.Name = SkillName;
                _db.Skills.Add(skill);
                _db.SaveChanges();
            } else
            {
                skill = _db.Skills.First(f => f.Name == SkillName);
            }

            //then add skill to user
            UserSkill us = new UserSkill();
            us.SkillId = skill.Id;
            us.SkillLevel = int.Parse(Skill);
            us.SkillName = skill.Name;
            us.YearsExperience = int.Parse(YearsExperience);
            us.UserId = _currentUser;
            _db.UserSkills.Add(us);
            _db.SaveChanges();

            return true;
        }

        [HttpGet]
        public PartialViewResult GetUserSkillsView()
        {
            var userSkills = _db.UserSkills.Where(f => f.UserId == _currentUser).ToList();
            return PartialView("_SkillsList", userSkills);
        }

        [HttpGet]
        public JsonResult GetSkill(int Id)
        {
            var userSkills = _db.UserSkills.FirstOrDefault(f => f.Id == Id && f.UserId == _currentUser);
            if (userSkills == null) return null;
            return Json(new { skillname = userSkills.SkillName, skilllevel = userSkills.SkillLevel, yearsexperience = userSkills.YearsExperience }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void DeleteSkill(string Id)
        {
            int skillId = int.Parse(Id);
            var skillToDelete = _db.UserSkills.FirstOrDefault(f => f.Id == skillId && f.UserId == _currentUser);
            if (skillToDelete == null) return;
            _db.UserSkills.Remove(skillToDelete);
            _db.SaveChanges();
        }
    }
}