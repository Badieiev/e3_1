using e3_1.Models;
using e3_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e3_1.Controllers
{
    public class ArticleController : Controller
    {
        private ArticleRepository repository = new ArticleRepository();
        // GET: Article
        public ActionResult Index()
        {
            var allArticles = repository.GetAll();
            List<ArticlePreview> articlePreviews = new List<ArticlePreview>();
            foreach (var article in allArticles)
            {
                var articlePreview = new ArticlePreview{ Article = article};
                articlePreviews.Add(articlePreview);
            }


            return View(articlePreviews);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(Article article)
        {
            if (!ModelState.IsValid) return View(article);

            repository.Add(article);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var article = repository.Get(id);
            if (article == null) return HttpNotFound();
            else return View(article);
        }

        [HttpPost()]
        public ActionResult Edit(Article article)
        {
            if (!ModelState.IsValid) return View(article);

            repository.Update(article);
            repository.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Review(int id)
        {
            ViewBag.ArticleId = id;
            return View(repository.GetReviews(id));
        }

        public ActionResult CreateReview(int id)
        {
            ViewBag.ArticleId = id;
            return View();
        }

        [HttpPost]
        public ActionResult CreateReview(Review review)
        {
            if (!ModelState.IsValid) return View(review);

            Article article = repository.Get(review.ArticleId);
            if (article != null)
            {
                review.Date = DateTime.Now;
                article.Reviews.Add(review);
                repository.SaveChanges();
            }
            return RedirectToAction("Index");
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
            return RedirectToAction("ProfileResult");
        }

        public ActionResult ProfileResult()
        {
            var profile = TempData["profile"] as Profile;
            if (profile != null)
            {
                ViewBag.Name = profile.Name;
                ViewBag.Age = profile.Age;
                ViewBag.MaritalStatus = profile.Single ? "single" : "married";
                List<string> edu = new List<string>();
                if (profile.None)
                {
                    edu.Add("none education");
                }
                if (profile.High_school)
                {
                    edu.Add("high school");
                }
                if (profile.Bachelor)
                {
                    edu.Add("barchelor");
                }
                if (profile.Master)
                {
                    edu.Add("master");
                }
                if (profile.Phd)
                {
                    edu.Add("phd");
                }
                ViewBag.edu = edu;
            }

            return View();
        }
    }
}