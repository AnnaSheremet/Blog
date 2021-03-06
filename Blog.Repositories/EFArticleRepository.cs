﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Configuration;

using Blog.Entities;

namespace Blog.Repositories
{
    public class EFArticleRepository: IArticleRepository
    {
        #region Fields
        private readonly string _connectionString;
        #endregion 

        #region Constructors
        public EFArticleRepository()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["BlogEntities"].ConnectionString;
        }


        public EFArticleRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        #endregion

        public List<Article> GetPublished()
        {
            using (ObjectContext context = new ObjectContext(_connectionString))
            {
                return context.CreateObjectSet<Article>()
                    .Where(u => u.Published == true)
                    .ToList();
            }
            
        }


        public void AddArticle(Article article)
        {
            using (ObjectContext context = new ObjectContext(_connectionString))
            {
                var articles = context.CreateObjectSet<Article>();
                articles.AddObject(article);
                context.SaveChanges();
            }
            //MyBlogEntities entities = new MyBlogEntities();
            //entities.Article.Add(article);
            //entities.SaveChanges();
        }



        public List<Article> GetUsersArticle(int id)
        {
            using (ObjectContext context = new ObjectContext(_connectionString))
            {
                return context.CreateObjectSet<Article>()
                    .Where(a => a.AuthoreId == id)
                    .ToList();
            }
        }




        public void EditArticle(int id, string content)
        {
            using (ObjectContext context = new ObjectContext(_connectionString))
            {
                Article article = context.CreateObjectSet<Article>().Single(a => a.Id == id);
                article.Content = content;
                context.SaveChanges();
            }
        }
    }
}
