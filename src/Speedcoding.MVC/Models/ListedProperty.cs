using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedcoding.MVC.Models
{
    public class ListedProperty : Property
    {
        public bool IsFavorited { get; set; }

        public int Price { get; set; }
        public decimal PriceChange { get; set; }
        public int Direction { get; set; }
    }

    
}
