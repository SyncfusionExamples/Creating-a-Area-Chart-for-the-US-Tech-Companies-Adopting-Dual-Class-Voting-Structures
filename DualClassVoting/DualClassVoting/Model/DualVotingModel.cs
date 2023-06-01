using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualClassVoting.Model
{
    public class DualVotingModel
    {
        public double Year { get; set; }
        public double TechPercentage { get; set; }
        public double NonTechPercentage { get; set; }

        public DualVotingModel(double year, double techPercentage, double nonTechPercentage)
        {
            Year = year;
            TechPercentage = techPercentage;
            NonTechPercentage = nonTechPercentage;
        }
    }
}
