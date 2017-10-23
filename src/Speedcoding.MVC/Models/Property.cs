using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedcoding.MVC.Models
{
    public class Property
    {
        public PropertyType Type { get; set; }

        public Location Location { get; set; }

        public decimal NoBed { get; set; }

        public decimal NoBath { get; set; }

        public int Area { get; set; }

        public string AreaUnit { get; set; }

        public int Price { get; set; }
    }

    public enum PropertyType
    {
        Home,
    }
}