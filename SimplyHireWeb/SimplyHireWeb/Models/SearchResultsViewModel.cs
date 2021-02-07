using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyHireWeb.Models
{
    public class SearchResultsViewModel
    {
        public SearchResultsViewModel()
        {
            this.UserResults = new List<UserSearchResult>();
        }
        public List<UserSearchResult> UserResults { get; set; }
        //TODO 
        //public List<Jobs> JobResults {get; set;}
    }

    public class UserSearchResult
    {
        public UserSearchResult()
        {
            this.Skills = new List<SearchResultSkill>();
        }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserId { get; set; }
        public string Bio { get; set; }
        public List<SearchResultSkill> Skills { get; set; }
    }

    public class SearchResultSkill
    {
        public string SkillName { get; set; }
        public int SkillLevel { get; set; }
        public string GetSkillLevelName()
        {
            switch (this.SkillLevel)
            {
                case 1:
                    return "Novice";
                case 2:
                    return "Junior";
                case 3:
                    return "Skilled";
                case 4:
                    return "Senior";
                case 5:
                    return "Master";
                default:
                    return "Skilled";
            }
        }
    }

}