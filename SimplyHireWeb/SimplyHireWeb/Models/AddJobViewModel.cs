using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyHireWeb.Models
{
    public class AddJobViewModel
    {
        public AddJobViewModel()
        {
            this.RequiredSkills = new List<Skill>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Skill> RequiredSkills { get; set; }
        public Company Company { get; set; }
        public decimal MinPay { get; set; }
        public decimal MaxPay { get; set; }
    }
}