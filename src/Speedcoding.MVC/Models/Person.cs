using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedcoding.MVC.Models
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string About { get; set; }

        public IList<Property> ActiveListings { get; set; }

        public IList<Review> Reviews { get; set; }

        public IList<PurchasedProperty> PastSales { get; set; }
    }
}