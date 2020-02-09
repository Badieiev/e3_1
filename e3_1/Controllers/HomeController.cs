using e3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e3_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Article> articles = new List<Article>();
            articles.Add(new Article {
                Name = "first",
                Date = DateTime.Now, 
                Text = "Examine the Index.cshtml view template and the Index method in the MoviesController.cs file. Notice how the code creates a List object when it calls the View helper method in the Index action method. The code then passes this Movies list from the Index action method to the view:"
            });

            return View(articles);
        }

        [HttpPost]
        public ActionResult Guest(Review review)
        {
            review.Date = DateTime.Now;
            ReviewContainer.reviews.Add(review);
            return RedirectToAction("Guest");
        }

        public ActionResult Guest()
        {
            ViewBag.Reviews = ReviewContainer.reviews;
            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Profile(Profile profile)
        {
            TempData["profile"] = profile;

            return View();
        }

        public ActionResult ProfileResult ()
        {
            ViewBag.Profile = TempData["profile"];

            return View();
        }
    }
}