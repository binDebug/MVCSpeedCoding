using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedcoding.MVC.Models
{
    public class Sale
    {
        public int ID { get; set; }

        public Property Property { get; set; }

        public int Price { get; set; }

        public DateTime PurchasedDate { get; set; }

        public string RepresentedBy { get; set; }
    }
}