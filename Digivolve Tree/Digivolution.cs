using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digivolve_Tree
{
    [Serializable]
    public class Digivolution
    {
        public string DigivolveFrom { get; set; }
        public string DigivolveTo { get; set; }
        
        public Digivolution() { }

        public Digivolution(string from, string to)
        {
            DigivolveFrom = from;
            DigivolveTo = to;
        }
    }
}
