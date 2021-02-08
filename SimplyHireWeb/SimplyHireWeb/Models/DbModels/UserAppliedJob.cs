using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyHireWeb.Models.DbModels
{
    public enum ApplicationStatus
    {
        Submitted = 1,
        Viewed = 2,
        Interested = 3,
        Contacted = 4,
        Hired = 5,
        Denied = 6
    }
    public class UserAppliedJob
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public SimplyHireWeb.Models.ApplicationUser User { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
        public DateTime ApplyDate { get; set; }
        public ApplicationStatus ApplicationStatus { get; set; }
        public string Notes { get; set; }
        public string DeniedReason { get; set; }
    }
}