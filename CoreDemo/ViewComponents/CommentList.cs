﻿using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvaues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Murat"
                },
                new UserComment
                {
                    ID=2,
                    Username="Mesut"
                },
                new UserComment
                {
                    ID=3,
                    Username="Merve"
                }
            };
            return View(commentvaues);
        }
    }
}
