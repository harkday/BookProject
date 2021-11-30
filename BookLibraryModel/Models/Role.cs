using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryModel.Models
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } 
    }
}
