using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.ViewModels
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public List<Portfolio> Portfolio { get; set; }
        public Address Address { get; set; }
        public About About { get; set; }
        public Contact Contact { get; set; }
    }
}
