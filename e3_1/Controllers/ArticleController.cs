﻿using e3_1.Models;
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
            return View(repository.GetAll());
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
    }
}