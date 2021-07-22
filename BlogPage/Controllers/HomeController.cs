using BlogPage.Models;
using BlogWeb.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogWeb.entity;
namespace BlogPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        BlogService _blogService;
       
        public HomeController(ILogger<HomeController> logger, BlogService blogService)
        {
            _logger = logger;
            _blogService = blogService;
        }
        public IActionResult Post(int id)
        {
            var _data = _blogService.GetById(id).data;
            return View(_data);
        }
        public IActionResult Index()
        {
            var _datas = _blogService.GetAll().datas;
            return View(_datas);
        }
        [Route("Home/Category/{category}")]
        public IActionResult Category(string category)
        {
            var _datas = _blogService.GetByCategory(category).datas;
            return View(_datas);
        }
        public IActionResult PostAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PostAdd(Blog blog)
        {
            var returnValue= _blogService.Add(blog);
            return Redirect("index");
        }
        [HttpGet]
        public IActionResult PostEdit(int? id)
        {
            var _data = _blogService.GetById((int)id).data;
            return View(_data);
        }
        [HttpPost]
        public async Task<IActionResult> AddPostEdit(Blog blog)
        {
            var returnValue = _blogService.Update(blog);
            return Redirect("index");
        }       
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var returnResult = _blogService.Delete(id);
            if (returnResult.isSuccess)
            {
                return Content("Silindi");
            }
            return View(returnResult.errorMessage);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
