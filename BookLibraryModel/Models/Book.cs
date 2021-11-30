using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookLibraryModel.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public DateTime PublishedAt { get; set; }

        public string CategoryId { get; set; } 
        public Category Category { get; set; }

        public ICollection<UserBook> UserBooks { get; set; }
    }
}
