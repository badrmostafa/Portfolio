using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(80,150)]
        public string Description { get; set; }
    }
}
