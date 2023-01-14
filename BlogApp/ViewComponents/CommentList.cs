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
                new UserComment() {Id=1,UserName="Murat"},
                new UserComment() {Id=2,UserName="Mesut"},
                new UserComment() {Id=3,UserName="Merve"},
            };
            return View(commentValues);
        }
    }
}
