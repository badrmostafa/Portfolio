using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.ViewModels
{
    public class PortfolioViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string Image { get; set; }
        [Required]
        [Range(minimum:30,maximum:80)]
        public string Description { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public IFormFile File { get; set; }
    }
}
