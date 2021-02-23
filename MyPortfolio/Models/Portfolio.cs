using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
