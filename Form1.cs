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
        public Form1()
        {
            InitializeComponent();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            originalCode.Items.Clear();
            originalTraces.Items.Clear();
            
            //TODO fileReader
            //TODO parseFile

        }

        private void fix_btn_Click(object sender, EventArgs e)
        {
            //TODO algorithm and read parsed lines
            //TODO show results in Modified Code + Modified Lines (you choose)
        }

        // PS putem scapa de modificare tot cod

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
