﻿using System;
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
        public bool Favorite { get; set; }
        public string DisplayText
        {
            get { return SeriesTitle + " #" + IssuNumber; }
        }

        //series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get { return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssuNumber + ".jpg"; }
        }
    }
}