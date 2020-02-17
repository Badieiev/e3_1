using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace e3_1.Models
{
    public class ArticleContext: DbContext
    {
        public ArticleContext()
        {        
            Database.SetInitializer<ArticleContext>(new DropCreateDatabaseIfModelChanges<ArticleContext>());
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}