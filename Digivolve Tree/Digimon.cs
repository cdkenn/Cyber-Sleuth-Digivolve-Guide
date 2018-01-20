using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digivolve_Tree
{
    [Serializable]
    public class Digimon
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Requirements { get; set; }
        
        public Digimon() { }
        
        public Digimon(string name, string level, string req)
        {
            Name = name;
            Level = level;
            Requirements = req;
        }
    }
}
