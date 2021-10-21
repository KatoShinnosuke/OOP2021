using System;
using System.Collections.Generic;

namespace SumpleEntityFramework.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Books> Books { get; set; }

    }
}