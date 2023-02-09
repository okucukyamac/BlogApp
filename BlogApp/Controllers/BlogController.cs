using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithBlogCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            List<Blog> values = bm.GetBlogById(id);
            return View(values);

        }

        public IActionResult BlogListByWriter()
        {
            var values = bm.GetListWithCategoryByWriter(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BlogAdd()

        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categories = (from x in cm.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }).ToList();

            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(blog);

            if (results.IsValid)
            {
                blog.Status = true;
                blog.InsertDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterId = 1;

                bm.Add(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }

            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var blog = bm.GetById(id);
            bm.Delete(blog);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categories = (from x in cm.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }).ToList();
            ViewBag.Categories = categories;
            Blog blog = bm.GetById(id);
            return View(blog);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(blog);

            if (results.IsValid)
            {
                bm.Update(blog);
                return RedirectToAction("BlogListByWriter");
            }

            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }




    }
}
