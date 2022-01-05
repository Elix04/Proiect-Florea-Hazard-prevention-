using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Florea__Hazard_prevention_
{
    public partial class Form1 : Form
    {
        public List<string> originalAsmLines;
        public List<string> modifiedAsmLines;
        public string file_select = "";
        //public List<Trace> origAsmLines; 
        
        //TODO trace class 



        public Form1()
        {
            InitializeComponent();

            modifiedLinesTextBox.ScrollBars = ScrollBars.Vertical;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            originalCode.Items.Clear();
            originalTraces.Items.Clear();

            //TODO fileReader

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "INS (*.ins)|*.ins";
            openFileDialog1.InitialDirectory = @"C:\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName.ToString());
            }

            //elix se ocupa Xd


            
            //TODO parseFile

        }

        private void fix_btn_Click(object sender, EventArgs e)
        {
            ReArrange reArrange= new MergeImmediate(modifiableAssemblyLines, originalTracesLines);
            modifiableAssemblyLines = abstractRearrangement.Rearrange();
            modifiableAssemblyLines.ForEach(line => ModifiedLinesListBox.Items.Add(line));
            modifiableAssemblyLines.ForEach(s => ModifiedLinesTextBox.AppendText(s + Environment.NewLine));
        }

        // PS putem scapa de modificare tot cod

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
