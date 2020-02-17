using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e3_1.Models
{
    public class ArticleRepository: Repository <Article>
    {
        public ArticleRepository() : base(new ArticleContext())
        { }

        public List<Review> GetReviews (int ArticleId)
        {
            Article article = this.Get(ArticleId);
            if (article !=null)
            {
                return article.Reviews;
            }
            else
            {
                return null;
            }
        }
    }
}