using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager nm = new(new EfNewsLetterRepository());

		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult SubscribeMail(NewsLetter model)
		{
			model.Status = true;
			nm.Add(model);

			return PartialView();
		}




	}
}
