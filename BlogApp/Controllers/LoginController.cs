using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

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
		public async Task<IActionResult> Index(Writer writer)
		{
			Context c = new Context();
			var data = c.Writers.FirstOrDefault(w => w.Mail == writer.Mail && w.Password == writer.Password);
			if (data != null)
			{

				var claims = new List<Claim>()
				{
					new Claim(ClaimTypes.Name, writer.Mail)
				};
				
				var userIdentity = new ClaimsIdentity(claims,"a");
				ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
				await HttpContext.SignInAsync(principal);


				return RedirectToAction("Index", "Writer");
			}
				return View();

		}



	}
}

//Context c = new();
//var dataValue = c.Writers.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
//if (dataValue != null)
//{
//	HttpContext.Session.SetString("username", model.Mail);
//	return RedirectToAction("Index", "Writer");
//}

//return View();
