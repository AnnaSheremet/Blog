using System;
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
    }
}
