using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e3_1.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}