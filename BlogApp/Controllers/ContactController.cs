using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogApp.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactRepository());

		[HttpGet]
		public IActionResult Index()
		{

			return View();
		}

		[HttpPost]
		public IActionResult Index(Contact model)
		{
			model.InsertDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			model.Status = true;
			cm.Add(model);
			return RedirectToAction("Index","Blog");
		}
	}
}
