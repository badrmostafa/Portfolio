using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Customer Name")]
        [Required]
        public string ClientName { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [RegularExpression(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage ="This is Not Email Address.")]
        public string Email { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
