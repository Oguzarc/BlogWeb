using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogWeb.entity;
using Dapper;
namespace BlogWeb.Repository
{
    public class BlogRepository
    {
        public Blog Add(Blog blog)
        {
            using (var db = new DbContext().GetConnection())
            {
                var value=db.Query<int>("Insert Into BlogText (Title,Summary,Text,CategoryName) values (@Title,@Summary,@Text,@CategoryName) SELECT SCOPE_IDENTITY();", blog).FirstOrDefault();
                if (blog.CategoryName != null)
                {
                    db.Execute("Insert Into Category (PostID,CategoryName) VALUES (@PostID,@CategoryName)", new { PostID =value, CategoryName = blog.CategoryName });
                }
                return GetById(value);
            }          
        }
        public List<Blog> GetByCategory(string category)
        {
            using (var db = new DbContext().GetConnection())
            {
                return db.Query<Blog>("select * from Category inner join BlogText ON Category.PostID=BlogText.Id where Category.CategoryName=@category and  active=1", new {category }).ToList();
            }
        }
        public List<Blog> GetAll()
        {
            using (var db = new DbContext().GetConnection())
            {
                return db.Query<Blog>("select * from BlogText where active=1").ToList();
            }
        }
        public Blog GetById(int id)
        {
            using (var db = new DbContext().GetConnection())
            {
                return db.Query<Blog>("select * from BlogText where Id=@id", new { id }).FirstOrDefault();
            }
        }
        public bool Delete(int postId)
        {
            using (var db = new DbContext().GetConnection())
            {
                return db.Execute("Update BlogText Set Active=0 Where Id=@postId ", new { postId }) > 0;
            }
        }
        public Blog Update(Blog blog)
        {
            using (var db = new DbContext().GetConnection())
            {
                db.Execute("Update BlogText Set Title=@Title,Summary=@Summary,Text=@Text Where Id=@Id ", blog);
                return GetById(blog.Id);
            }
            
        }
    }
}
