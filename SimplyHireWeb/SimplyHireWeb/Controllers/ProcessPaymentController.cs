using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stripe;

namespace SimplyHireWeb.Controllers
{
    public class ProcessPaymentController : Controller
    {
        
        // GET: ProcessPayment
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public bool AttemptCharge(long chargeAmount)
        {
            StripeConfiguration.ApiKey = "sk_test_51HYswwFuWzXwEiKoPskvxZzZjhs6pknuP8mzKyfoxmXT7C6i4SSS2Yv0WGnndfixTmcuzOD61lz09gxS4u8DMrJ900olCuofSB";
            try
            {
                var options = new ChargeCreateOptions
                {
                    Amount = chargeAmount,
                    Currency = "usd",
                    Source = "tok_visa", // obtained with Stripe.js
                    Description = "My First Test Charge (created for API docs)",
                };
                var service = new ChargeService();
                service.Create(options, new RequestOptions
                {
                    IdempotencyKey = "xh4LPc53wpGyXB9D",
                });
            } catch(Exception ex)
            {
                string error = ex.Message;
                return false;
            }
            return true;
        }
    }
}