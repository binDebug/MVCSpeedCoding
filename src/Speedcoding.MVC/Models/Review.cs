using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedcoding.MVC.Models
{
    public class Review
    {
        public int ID { get; set; }

        public string ReviewdBy { get; set; }

        public DateTime ReviewDate { get; set; }

        public Sale Property { get; set; }

        public decimal LocalKnowledge { get; set; }

        public decimal Expertise { get; set; }

        public decimal Responsiveness { get; set; }

        public decimal NegotiationSkills { get; set; }

        public int LocalKnowledgePercentage { get; set; }

        public int ExpertisePercentage { get; set; }

        public int ResponsivenessPercentage { get; set; }

        public int NegotiationSkillsPercentage { get; set; }

        public int AveragePercentage { get; set; }

        public decimal Average { get; set; }

        public string Description { get; set; }
    }
}