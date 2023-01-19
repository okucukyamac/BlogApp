using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogApp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddCommetn()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult PartialAddCommetn(Comment model)
        {
            model.InsertDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            model.Status = true;
            model.BlogId= 2;
            cm.Add(model);

            return View();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetAll(id);
            return PartialView(values);
        }
    }
}
