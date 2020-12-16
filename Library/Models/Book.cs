﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<BookCopy> BookCopies { get; set; }
        public Book()
        {
            BookCopies = new List<BookCopy>();
        }
    }
}
