using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedcoding.MVC.Models
{
    public class Review
    {
        public string ReviewdBy { get; set; }

        public DateTime ReviewDate { get; set; }

        public PurchasedProperty Property { get; set; }

        public decimal LocalKnowledge { get; set; }

        public decimal Expertise { get; set; }

        public decimal Responsiveness { get; set; }

        public decimal NegotiationSkills { get; set; }

        public string Description { get; set; }
    }
}