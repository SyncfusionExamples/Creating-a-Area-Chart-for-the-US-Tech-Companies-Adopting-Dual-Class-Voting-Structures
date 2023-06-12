using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DualClassVoting.Model;

namespace DualClassVoting
{
    public class DualClassVotingPercentage
    {
        public List<DualVotingModel> VotingPercentage { get; set; }

        public DualClassVotingPercentage()
        {
            VotingPercentage = new List<DualVotingModel>(ReadCSV());
        }

        public IEnumerable<DualVotingModel> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("DualClassVoting.Resources.Raw.dualclassvoting.csv");

            string line;
            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                return new DualVotingModel(Convert.ToInt32(data[0]), Convert.ToDouble(data[1]), Convert.ToDouble(data[2]));
            });
        }
    }
}
