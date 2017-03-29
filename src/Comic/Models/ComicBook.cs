using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comic.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssuNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favoirie { get; set; }
    }
}