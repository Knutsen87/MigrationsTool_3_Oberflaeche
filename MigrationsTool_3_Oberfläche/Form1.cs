using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationsTool_3_Oberfläche
{
    public partial class MigrationsTool : Form
    {
        public MigrationsTool()
        {
            InitializeComponent();
        }

        private void CmdOpenFile_Click(object sender, EventArgs e)
        {
            //Erlaubt nur CSV Dateien zur Auswahl
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            // Zeigt den Dialog und holt sich result
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK) // Test result
            {
                // Zeigt dem Nutzer an ob er die richtige Datei ausgewählt hat.
                string[] fileName = openFileDialog1.FileName.Split('\\');
                LblDateiAnzeige.Text = fileName[fileName.Length-1];
            }
            // MessageBox.Show(result.ToString()); // Zum debugging
        }

        private void CmdCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdOpenBuchungsDaten_Click(object sender, EventArgs e)
        {
            //Erlaubt nur CSV Dateien zur Auswahl
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            // Zeigt den Dialog und holt sich result
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result
            {
                // Zeigt dem Nutzer an ob er die richtige Datei ausgewählt hat.
                string[] fileName = openFileDialog1.FileName.Split('\\');
                LblDateiAnzeige.Text = fileName[fileName.Length - 1];
            }
            // MessageBox.Show(result.ToString()); // Zum debugging
        }

        private void LblDateiAnzeige_Click(object sender, EventArgs e)
        {

        }
    }
}
