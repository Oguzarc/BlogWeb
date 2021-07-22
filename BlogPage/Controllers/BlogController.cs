using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWeb.Service;
using BlogWeb.entity;
namespace BlogPage.Controllers
{
    public class BlogController : Controller
    {
        BlogService _blogService;
        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }
        
    }
}
