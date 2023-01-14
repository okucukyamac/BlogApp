using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithBlogCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            List<Blog> values = bm.GetBlogById(id);
            return View(values);
        }
    }
}
