using Comic.Data;
using Comic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic.Controllers
{
    public class ComicBookController:Controller

    {
        private ComicBookRep _comicBookRep = null;
        public ComicBookController()
        {
            _comicBookRep= new ComicBookRep();
        }

        public ActionResult detail(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRep.GetComicBook((int)id);

            //two ways to Initialize object
            //1.var comicBook = new ComicBook() ; comicBook.SeriesTitle = "";

            //2.this way...
            //var comicBook = new ComicBook()
            //{
            //    SeriesTitle = "spiderman hsamen",
            //    IssuNumber =700,
            //    DescriptionHtml= "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
            //    Artists = new Artist[]
            //    {
            //        new Artist () { Name = "dan slott",Role="script" },
            //        new Artist () { Name = "humberto ramos",Role="pencils" },
            //        new Artist () { Name = "inks: victor",Role="olazaba" },
            //        new Artist () { Name = "edgar delgado",Role="colors" },
            //        new Artist () { Name = "chris eliopoulos",Role="letters" },
            //    }


            //};

            //2 vways to pass data to views -- dynamic ViewBag.ComicBook = comicBook;
            //or .. 
            return View(comicBook);
           
        }
    }
}