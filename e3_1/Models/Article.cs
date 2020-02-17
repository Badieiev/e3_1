using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e3_1.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}