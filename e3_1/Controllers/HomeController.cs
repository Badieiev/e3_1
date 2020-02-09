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
        public ActionResult PostGuest(Review review)
        {
            review.Date = DateTime.Now;
            ReviewContainer.reviews.Add(review);
            return View();
        }

        [HttpGet]
        public ActionResult Guest()
        {
            return View(ReviewContainer.reviews);
        }

        public ActionResult Profiles()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}