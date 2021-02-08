using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyHireWeb.Models.CompanyModels
{
    public class JobListViewModel
    {
        public JobListViewModel()
        {
            this.PostedJobs = new List<PostedJob>();
        }
       public List<PostedJob> PostedJobs { get; set; }
    }
    public class PostedJob
    {
        public PostedJob()
        {
            this.RequiredSkills = new List<Skill>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumberOfApplicants { get; set; }
        public int CreateDate { get; set; }
        public List<Skill> RequiredSkills { get; set; }
    }
}