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
using System.Xml.Serialization;

namespace Digivolve_Tree
{
    public partial class MainForm : Form
    {
        public Digidex Dex = new Digidex(new List<Digimon>(), new List<Digivolution>());
        private Digimon SelectedDigimon = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadXml();
            PopulateStageCombo();
        }

        private void PopulateStageCombo()
        {
            cmbStage.Items.Clear();
            cmbStage.Items.Add("N/A");
            var levels = Dex.GetAllLevels();
            foreach (var level in levels)
            {
                cmbStage.Items.Add(level);
            }
            cmbStage.SelectedIndex = 0;
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

                        Dex.AllDigimon.Add(currDigimon);
                        if (nameSplit.Length > 1)
                        {
                            //digimon can digivolve
                            string[] digivolveSplit = nameSplit[1].Split(',');
                            foreach (string digi in digivolveSplit)
                            {
                                string digivolvesTo = digi.Trim();
                                Digivolution digivolution = new Digivolution(name, digivolvesTo);
                                Dex.AllDigivolutions.Add(digivolution);
                            }
                        }
                    }
                    counter++;
                }   //end file read while loop
            }
            Dex.WriteXML();
        }

        private void FillDigimonDetails()
        {
            lblName.Text = SelectedDigimon.Name;

            //center details stuff
            lblReqs.Text = "";
            if (SelectedDigimon.Requirements != null) lblReqs.Text = SelectedDigimon.Requirements;
            lblLevel.Text = "Level: ";
            if (SelectedDigimon.Level != null) lblLevel.Text += SelectedDigimon.Level;


            var digivolvesIntoSelected = Dex.GetDigivolvesInto(SelectedDigimon.Name);
            var digivolvesFromSelected = Dex.GetDigivolvesFrom(SelectedDigimon.Name);

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
                //right table
                var d = Dex.GetDigimonByName(name);
                tblDigivolvesTo.Rows.Add(name, d?.Requirements);
            }

            tblDigivolvesFrom.ClearSelection();
            tblDigivolvesTo.ClearSelection();
        }

       

        private void tblDigivolvesTo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;

            string name = tblDigivolvesTo.Rows[row].Cells[0].Value.ToString();
            txtSearch.Text = name;
        }

        private void tblDigivolvesFrom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;

            string name = tblDigivolvesFrom.Rows[row].Cells[0].Value.ToString();
            txtSearch.Text = name;
        }

        private void ReadXml()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Digidex));
            StreamReader file = new StreamReader("digimon.xml");
            Dex = (Digidex)reader.Deserialize(file);
            file.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string name = txtSearch.Text.Trim();
            List<Digimon> searchList = new List<Digimon>();

            if (cmbStage.SelectedIndex == 0)
            {
                //just search by name
                searchList = Dex.GetDigimonContainingName(name);
            }
            else
            {
                //search by name and stage
                string level = cmbStage.Text;
                searchList = Dex.GetDigimonContainingNameByLevel(name, level);
            }

            PopulateSearchTable(searchList);
        }

        private void PopulateSearchTable(List<Digimon> digimonList)
        {
            tblDigimon.Rows.Clear();
            foreach (var digimon in digimonList)
            {
                tblDigimon.Rows.Add(digimon.Name);
            }
            if (tblDigimon.RowCount > 0)
                tblDigimon[0, 0].Selected = true;
        }

        private void cmbStage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void tblDigimon_Select()
        {
            if (tblDigimon.SelectedCells.Count == 0) return;
            int rowIndex = tblDigimon.SelectedCells[0].RowIndex;
            int colIndex = tblDigimon.SelectedCells[0].ColumnIndex;
            if (rowIndex < 0) return;

            string name = tblDigimon[colIndex, rowIndex].Value.ToString();

            SelectedDigimon = Dex.GetDigimonByName(name);
            FillDigimonDetails();
        }

        private void tblDigimon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tblDigimon_Select();
        }

        private void tblDigimon_SelectionChanged(object sender, EventArgs e)
        {
            tblDigimon_Select();
        }
    }
}
