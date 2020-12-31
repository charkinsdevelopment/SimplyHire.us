using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyHireWeb.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int YearsInBusiness { get; set; }
        public int NumberOfEmployees { get; set; }
        public int YearlyRevenue { get; set; }
        public string CompanyLogoUrl { get; set; }
    }
}