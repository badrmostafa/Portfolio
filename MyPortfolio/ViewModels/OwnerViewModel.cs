using Microsoft.AspNetCore.Http;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.ViewModels
{
    public class OwnerViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Owner Name Field is Required.")]
        [Display(Name = "Owner_Name")]
        public string OwnerName { get; set; }
        public string Image { get; set; }
        [Required]
        public string Profile { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public IFormFile File { get; set; }
        //Navigation Property
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        
    }
}
