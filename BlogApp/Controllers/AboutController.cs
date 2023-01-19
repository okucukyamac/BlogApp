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
			return View();
		}

		public PartialViewResult SocialMedia()
		{
			var values = abm.GetList();
			return PartialView(values);
		}
	}
}
