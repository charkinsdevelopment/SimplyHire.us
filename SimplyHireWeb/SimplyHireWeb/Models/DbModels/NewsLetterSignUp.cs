using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimplyHireWeb.Models
{
    public class NewsLetterSignUp
    {
        public int Id { get; set; }
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? NewsletterSentDate { get; set; }
        public bool OptedOut { get; set; }
    }
}