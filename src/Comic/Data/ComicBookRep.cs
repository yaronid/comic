﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Comic.Models;

namespace Comic.Data
{
    public class ComicBookRep
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {   Id=1,
                SeriesTitle = "The Amazing Spider-Man",
                IssuNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                   {
                    new Artist () { Name = "dan slott",Role="script" },
                    new Artist () { Name = "humberto ramos",Role="pencils" },
                    new Artist () { Name = "inks: victor",Role="olazaba" },
                    new Artist () { Name = "edgar delgado",Role="colors" },
                    new Artist () { Name = "chris eliopoulos",Role="letters" },
                   }


            },

    new ComicBook()
    {   Id=2,
        SeriesTitle = "The Amazing Spider-Man",
        IssuNumber = 657,
        DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Dan Slott", Role = "Script" },
            new Artist() { Name = "Marcos Martin", Role = "Pencils" },
            new Artist() { Name = "Marcos Martin", Role = "Inks" },
            new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
            new Artist() { Name = "Joe Caramagna", Role = "Letters" }
        },
        Favorite = false
    },
    new ComicBook()
    {    Id=3,
        SeriesTitle = "Bone",
        IssuNumber = 50,
        DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Jeff Smith", Role = "Script" },
            new Artist() { Name = "Jeff Smith", Role = "Pencils" },
            new Artist() { Name = "Jeff Smith", Role = "Inks" },
            new Artist() { Name = "Jeff Smith", Role = "Letters" }
        },
        Favorite = false
    }



        };
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBook_return = null;
            foreach(var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBook_return = comicBook;
                    break;
                }
            }
            
            return comicBook_return;
        }
    }
}