﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKBookClub.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsBookOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
