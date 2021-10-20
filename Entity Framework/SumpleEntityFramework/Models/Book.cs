using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumpleEntityFramework.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }        
        [MaxLength(16)]
        public string Publisher { get; set; }
        public int PublishedYear { get; set; }
        public Author Author { get; set; }

    
    }
}

