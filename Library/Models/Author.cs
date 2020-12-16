﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public List<Book> Books { get; set; }
        public Author()
        {
            Books = new List<Book>();
        }
    }
}
