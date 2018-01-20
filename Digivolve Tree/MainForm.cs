using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digivolve_Tree
{
    public partial class MainForm : Form
    {
        public Digidex dex = new Digidex(new List<Digimon>(), new List<Digivolution>());

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadXml();
            PopulateDigiSelectCombo();
        }

        private void PopulateDigiSelectCombo()
        {
            cmbDigiSelect.Items.Clear();
            var names = dex.getAllDigimonNames();
            foreach(string name in names)
            {
                cmbDigiSelect.Items.Add(name);
            }
            if (names.Count > 0)
                cmbDigiSelect.SelectedIndex = 0;
        }

        private void ParseFile(string path)
        {
            /*File Format:
            * LEVEL: Rookie
            * (Digimon A): (Digimon X, Y, Z that evolve from Digimon A)
            * (Stats required to evolve into Digimon A)
            * (Digimon B): (Digimon X, Y, Z that evolve from Digimon B)
            * (Stats required to evolve into Digimon B)
            * ...
            * 
            * LEVEL: Champion
            * (Digimon C): (Digimon X, Y, Z that evolve from Digimon C)
            * (Stats required to evolve into Digimon C)
            */

            if (!File.Exists(path))
            {
                return;
            }

            using (StreamReader file = new StreamReader(path))
            {

                int counter = 1;
                string line;

                string currentDigiLevel = "";

                Digimon currDigimon = null;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Trim() == "") continue;

                    if (line.StartsWith("LEVEL: "))
                    {
                        //change the current level
                        string[] strSplit = line.Split(':');
                        currentDigiLevel = strSplit[1].Trim();
                    }
                    else if (line.StartsWith("("))
                    {
                        //this will be a digivolve req
                        string req = line.Substring(1, line.Length - 2);
                        if (currDigimon != null)
                        {
                            currDigimon.Requirements = req;
                        }
                    }
                    else
                    {
                        //got a digimon!
                        string[] nameSplit = line.Split(':');
                        string name = nameSplit[0].Trim();
                        currDigimon = new Digimon();
                        currDigimon.Name = name;
                        currDigimon.Level = currentDigiLevel;

                        dex.AllDigimon.Add(currDigimon);
                        if (nameSplit.Length > 1)
                        {
                            //digimon can digivolve
                            string[] digivolveSplit = nameSplit[1].Split(',');
                            foreach (string digi in digivolveSplit)
                            {
                                string digivolvesTo = digi.Trim();
                                Digivolution digivolution = new Digivolution(name, digivolvesTo);
                                dex.AllDigivolutions.Add(digivolution);
                            }
                        }
                    }
                    counter++;
                }   //end file read while loop
            }
            dex.WriteXML();
        }

        private void cmbDigiSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = cmbDigiSelect.Text;
            var selecteDM = dex.getDigimonByName(selectedName);
            
            //center details stuff
            txtReqs.Text = "";
            if (selecteDM.Requirements != null) txtReqs.Text = selecteDM.Requirements;
            lblLevel.Text = "Level: ";
            if (selecteDM.Level != null) lblLevel.Text += selecteDM.Level;


            var digivolvesIntoSelected = dex.getDigivolvesInto(selectedName);
            var digivolvesFromSelected = dex.getDigivolvesFrom(selectedName);

            //Table stuff
            tblDigivolvesFrom.Rows.Clear();
            tblDigivolvesTo.Rows.Clear();
            foreach (var name in digivolvesIntoSelected)
            {
                //left table
                tblDigivolvesFrom.Rows.Add(name);
            }
            foreach (var name in digivolvesFromSelected)
            {
                //left table
                tblDigivolvesTo.Rows.Add(name);
            }

            tblDigivolvesFrom.ClearSelection();
            tblDigivolvesTo.ClearSelection();
        }

        private void tblDigivolvesTo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;

            string name = tblDigivolvesTo.Rows[row].Cells[0].Value.ToString();
            cmbDigiSelect.Text = name;
        }

        private void tblDigivolvesFrom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;

            string name = tblDigivolvesFrom.Rows[row].Cells[0].Value.ToString();
            cmbDigiSelect.Text = name;
        }

        private void ReadXml()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Digidex));
            StreamReader file = new StreamReader("digimon.xml");
            dex = (Digidex)reader.Deserialize(file);
            file.Close();
        }
    }
}
