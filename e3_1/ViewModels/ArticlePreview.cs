using e3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e3_1.ViewModels
{
    public class ArticlePreview
    {
        public Article Article { get; set; }

        public String Preview { get { return Article.Text.Length < 200 ? Article.Text : Article.Text.Substring(0, 200); } }
    }
}