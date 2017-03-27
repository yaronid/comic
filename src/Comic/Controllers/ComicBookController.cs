﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic.Controllers
{
    public class ComicBookController:Controller
    {
        public ActionResult detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return new RedirectResult("/");
            }
            return Content("hi from mvc");
           
        }
    }
}