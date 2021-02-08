using SimplyHireWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyHireWeb.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

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
            var dbUserSkills = _db.UserSkills.Where(f => f.SkillName.Contains(vm.Search));
            var userIds = dbUserSkills.Select(y => y.UserId).ToList();
            var users = _db.Users.Where(f => userIds.Contains(f.Id)).ToList();
            foreach (var user in users)
            {
                var skills = _db.UserSkills.Where(f => f.UserId == user.Id).ToList();
                var searchResults = new UserSearchResult()
                {
                    Bio = user.Bio,
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Skills = skills.Select(f => new SearchResultSkill()
                    {
                        SkillName = f.SkillName,
                        SkillLevel = f.SkillLevel
                    }).ToList()
                };
                viewModel.UserResults.Add(searchResults);
            }

            //SqlParameter param1 = new SqlParameter("@SearchTerm", vm.Search);
            //var data = _db.Database.SqlQuery<string>("GetUsersBySkill @SearchTerm", param1);
            //foreach(var d in data)
            //{
            //    string a = d;
            //}
            return View("Results", viewModel);
        }
    }
}