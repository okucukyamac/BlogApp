using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager categoryManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddCommetn()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            categoryManager.GetAll(id);
            return PartialView();
        }
    }
}
