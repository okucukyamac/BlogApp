using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
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
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(writer);
			if (results.IsValid)
			{
				writer.Status = true;
				writer.About = "deneme  test";
				wm.Add(writer);
				return RedirectToAction("Index", "Blog");
			}

			foreach (var item in results.Errors)
			{
				ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
			}
			return View();

		}


	}
}
