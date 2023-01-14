using BlogApp.Models;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogApp.ViewComponents.Comment
{
    public class CommentListByBlog: ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetAll(id);
            return View(values);
        }
    }
}

