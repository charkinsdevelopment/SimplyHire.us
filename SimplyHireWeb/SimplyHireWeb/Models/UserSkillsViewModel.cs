using SimplyHireWeb.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyHireWeb.Models
{
    public class UserSkillsViewModel
    {
        public UserSkillsViewModel()
        {
            this.UserSkills = new List<UserSkill>();
        }
        public List<UserSkill> UserSkills { get; set; }
    }
}