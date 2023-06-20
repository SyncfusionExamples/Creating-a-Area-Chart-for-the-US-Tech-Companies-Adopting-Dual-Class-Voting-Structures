using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualClassVoting.Model
{
    public class DualVotingModel
    {
        public int Year { get; set; }
        public double TechPercentage { get; set; }
        public double NonTechPercentage { get; set; }

        public DualVotingModel(int year, double techPercentage, double nonTechPercentage)
        {
            Year = year;
            TechPercentage = techPercentage;
            NonTechPercentage = nonTechPercentage;
        }
    }
}
