using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
	public class AboutController : Controller
	{
		AboutManager abm = new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
			var values = abm.GetList();

			return View(values);
		}

		public PartialViewResult SocialMedia()
		{
			return PartialView();
		}
	}
}
