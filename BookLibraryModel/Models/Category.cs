﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryModel.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } 
    }
}
