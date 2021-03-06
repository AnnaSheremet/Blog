﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Blog.Entities;

namespace Blog.Repositories
{
    public interface IUserRepository
    {
        Users GetUser(string login, string password);
        List<Users> GetUsers();
        void AddUser(Users user);
    }
}
