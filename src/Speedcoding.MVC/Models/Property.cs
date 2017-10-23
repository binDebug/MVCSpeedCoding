using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedcoding.MVC.Models
{
    public class Property
    {
        public int ID { get; set; }

        public PropertyType Type { get; set; }

        public Location Location { get; set; }

        public decimal NoBed { get; set; }

        public decimal NoBath { get; set; }

        public int Area { get; set; }

        public string AreaUnit { get; set; }

        public IList<Image> Images { get; set; }
    }

    public enum PropertyType
    {
        Home,
    }
}