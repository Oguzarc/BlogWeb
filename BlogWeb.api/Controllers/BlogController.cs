using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWeb.Service;
using BlogWeb.entity;
using Microsoft.AspNetCore.Authorization;

namespace BlogWeb.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        BlogService _blogService;
        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpPost]
        [Route("Add")]
        public Result<Blog> Add(Blog blog)
        {
            return _blogService.Add(blog);
        }
        [HttpPost]
        [Route("Update")]
        public Result<Blog> Update(Blog blog)
        {
            return _blogService.Update(blog);
        }
        [HttpGet]
        [Route("GetAll")]
        public Result<Blog> GetAll()
        {
            return _blogService.GetAll();
        }
        [HttpGet]
        [Route("GetByCategory")]
        public Result<Blog> GetByCategory(string category)
        {
            return _blogService.GetByCategory(category);
        }
        [HttpGet]
        [Route("GetById")]
        public Result<Blog> GetById(int id)
        {
            return _blogService.GetById(id);
        }
        [HttpPost]
        [Route("Delete")]
        public Result<Blog> MemberActivity(int blogId)
        {
            return _blogService.Delete(blogId);
        }

    }
}
