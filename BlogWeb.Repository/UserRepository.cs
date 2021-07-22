using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using BlogWeb.entity;
using Dapper;
using Microsoft.IdentityModel.Tokens;

namespace BlogWeb.Repository
{
    public class UserRepository
    {
        public User Register(User user)
        {
            using (var db = new DbContext().GetConnection())
            {
                return db.Query<User>("Insert Into UserTable (username,password) values (@username,@password) SELECT SCOPE_IDENTITY();", user).FirstOrDefault();
            }
        }
        public User GetByUserName(string username)
        {
            using (var db = new DbContext().GetConnection())
            {
                return db.Query<User>("select * From UserTable where username=@username", new { username }).FirstOrDefault();
            }
        }
        public User Authenticate(string username,string password)
        {
            using (var db = new DbContext().GetConnection())
            {
                var user = db.Query<User>("select * From UserTable where username=@username and password=@password", new { username,password }).SingleOrDefault();
                if (user == null)
                    return null;
                return user;
            }
        }
    }
}
