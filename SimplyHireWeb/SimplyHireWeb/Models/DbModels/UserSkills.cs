using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyHireWeb.Models.DbModels
{
    public class UserSkills
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int SkillId { get; set; }
    }
}