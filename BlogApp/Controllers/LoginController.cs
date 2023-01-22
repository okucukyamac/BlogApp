using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApp.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{		
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer model)
		{
			Context c = new();
			var dataValue = c.Writers.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
			if (dataValue != null)
			{
				HttpContext.Session.SetString("username", model.Mail);
				return RedirectToAction("Index", "Writer");
			}
			else
				return View();
		}
	}
}
