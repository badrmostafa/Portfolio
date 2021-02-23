using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Owner
    {
        public int Id { get; set; }
         [Required(ErrorMessage = "This Field Is Required.")]
        //[Display(Name = "Name")]
        public string OwnerName { get; set; }
        public string Image { get; set; }
        public string Profile { get; set; }
        //Navigation Property
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

    }
}
