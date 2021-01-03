using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyHireWeb.Models.DbModels
{
    public class UserSkill
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int SkillLevel { get; set; }
        public int YearsExperience { get; set; }
    }
}