using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Models
{
    public class Link
    {
        public int ID { get; set; }
        
        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string Title { get; set; }
        
        [StringLength(1999)]
        [Required]
        public string Url { get; set; }

        [RegularExpression(@"_(blank|self|parent|top)|^$")] // ^$
        public string? Target { get; set; }
    }
}
