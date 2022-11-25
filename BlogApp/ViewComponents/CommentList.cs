using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogApp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>()
            {
                new UserComment() {Id=1,Name="Murat"},
                new UserComment() {Id=2,Name="Mesut"},
                new UserComment() {Id=3,Name="Merve"},
            };
            return View(commentValues);
        }
    }
}
