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
    }
}