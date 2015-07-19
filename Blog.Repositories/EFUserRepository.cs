using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.Objects;
using Blog.Entities;
using System.Data.SqlClient;

namespace Blog.Repositories
{
    class EFUserRepository : IUserRepository
    {
        #region Fields
        private readonly string _connectionString;
        #endregion

        #region Constructors
        public EFUserRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public EFUserRepository()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["DB_BlogEntities"].ConnectionString;
        }
        #endregion


        #region Functions

        public Users GetUser(string login, string password)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetUsers()
        {

            DB_BlogEntities entities = new DB_BlogEntities();
            var user_ = from user in entities.Users select user;
            List<Users> users = user_.ToList();
            return users;
        }

        public void UpdateUser(int Id, bool IsEnable)
        {

            using (ObjectContext context = new ObjectContext(_connectionString))
            {
                Users user = context.CreateObjectSet<Users>().First(s => s.ID_User == Id);
                user.IsEnable = IsEnable;
                context.SaveChanges();
            }
        }
        #endregion

    }
}
