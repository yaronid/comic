using System;
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
            ViewBag.Title1 = "spiderman hsamen ";
            ViewBag.Movienum = 800;
            ViewBag.Desc = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
                {
                    "script: dan slott",
                    "pencils: humberto ramos",
                    "inks: victor olazaba",
                    "colors: edgar delgado",
                    "letters: chris eliopoulos"
                };

            return View();
           
        }
    }
}