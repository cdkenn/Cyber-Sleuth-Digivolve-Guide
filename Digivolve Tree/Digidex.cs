using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digivolve_Tree
{
    [Serializable]
    public class Digidex
    {
        public List<Digimon> AllDigimon { get; set; }
        public List<Digivolution> AllDigivolutions { get; set; }

        public Digidex()
        {

        }

        public Digidex(List<Digimon> digimon, List<Digivolution> digivolutions)
        {
            AllDigimon = digimon;
            AllDigivolutions = digivolutions;
        }

        public List<string> GetDigivolvesInto(string digimonName)
        {
            List<string> toReturn = new List<string>();
            for (int i = 0; i < AllDigivolutions.Count; i++)
            {
                if (AllDigivolutions[i].DigivolveTo == digimonName)
                {
                    toReturn.Add(AllDigivolutions[i].DigivolveFrom);
                }
            }
            return toReturn;
        }

        public List<string> GetDigivolvesFrom(string digimonName)
        {
            List<string> toReturn = new List<string>();
            for (int i = 0; i < AllDigivolutions.Count; i++)
            {
                if (AllDigivolutions[i].DigivolveFrom == digimonName)
                {
                    toReturn.Add(AllDigivolutions[i].DigivolveTo);
                }
            }
            return toReturn;
        }

        public Digimon GetDigimonByName(string name)
        {
            for(int i = 0; i < AllDigimon.Count; i++)
            {
                if(AllDigimon[i].Name== name)
                {
                    return AllDigimon[i];
                }
            }
            return null;
        }

        public List<string> GetAllDigimonNames()
        {
            List<string> toReturn = new List<string>();
            for (int i = 0; i < AllDigimon.Count; i++)
            {
                toReturn.Add(AllDigimon[i].Name);
            }
            return toReturn;
        }

        public void WriteXML()
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Digidex));

            string path = "digimon.xml";

            FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, this);
            file.Close();
        }

        public List<Digimon> GetDigimonContainingName(string name)
        {
            return (from t in AllDigimon where t.Name.ToLower().Contains(name.ToLower()) select (t)).ToList();
        }

        public List<Digimon> GetDigimonContainingNameByLevel(string name, string level)
        {
            return (from t in AllDigimon where t.Name.ToLower().Contains(name) && t.Level == level select (t)).ToList();
        }

        public List<Digimon> GetDigimonByLevel(string level)
        {
            return AllDigimon.Where(t => t.Level == level).ToList();
        }

        public List<string> GetAllLevels()
        {
            List<string> levels = new List<string>();

            foreach (var digimon in AllDigimon)
            {
                if(!levels.Contains(digimon.Level)) levels.Add(digimon.Level);
            }
            return levels;
        }
    }
}
