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
            this.Skills = new List<Skill>();
        }
        public List<Skill> Skills { get; set; }
    }
}