using SimplyHireWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplyHireWeb.Controllers
{
    public class NewsletterController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Newsletter
        [HttpPost]
        public ActionResult SignUp(NewsLetterSignUp vm)
        {
            bool _success = true;
            string _message = "Signed Up!";
            try
            {
                NewsLetterSignUp model = new NewsLetterSignUp();
                if (_db.NewsLetterSignUps.Any(f => f.EmailAddress.ToLower() == vm.EmailAddress.ToLower()))
                {
                    model = _db.NewsLetterSignUps.First(f => f.EmailAddress.ToLower() == vm.EmailAddress.ToLower());
                    model.OptedOut = false;
                    model.NewsletterSentDate = null;
                    _db.SaveChanges();
                } 
                else
                {
                    model.CreateDate = DateTime.Now;
                    model.EmailAddress = vm.EmailAddress.ToLower();
                    model.NewsletterSentDate = null;
                    model.OptedOut = false;
                    _db.NewsLetterSignUps.Add(model);
                    _db.SaveChanges();

                }
            } catch(Exception ex)
            {
                _success = false;
                _message = "There was an error signing you up. Please try again later.";
            }
            return Json(new { Success = _success, Message = _message });
        }
    }
}