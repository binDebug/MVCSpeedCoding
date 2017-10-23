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

        public string Brokerage { get; set; }

        public int ID { get; set; }

        public IList<string> Specialties { get; set; }

        public IList<string> LicenseNumbers { get; set; }

        public IList<Property> ActiveListings { get; set; }

        public IList<Review> Reviews { get; set; }

        public Review AverageReview { get; set; }

        public IList<Sale> PastSales { get; set; }
    }
}