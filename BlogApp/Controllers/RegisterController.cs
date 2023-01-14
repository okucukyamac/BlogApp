using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		public IActionResult Index()
		{
			return View();
		}
		
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			writer.Status = true;
			writer.About = "deneme  test";
			wm.Add(writer);
			return RedirectToAction("Index","Blog");
		}


	}
}
