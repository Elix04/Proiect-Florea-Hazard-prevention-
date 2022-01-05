using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Florea__Hazard_prevention_
{
    public partial class Form1 : Form
    {
        public List<string> original_asm_lines;
        public List<string> modified_asm_lines;
        public List<Trace> original_Trace_Lines;
        public string fileSelected = "";
        
        //public List<Trace> origAsmLines; 
        
        //TODO trace class 



        public Form1()
        {
            InitializeComponent();

            modifiedLinesTextBox.ScrollBars = ScrollBars.Vertical;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            originalCodeBox.Items.Clear();
            originalTracesBox.Items.Clear();

            var fileReader = new OpenFileReader();

            //Load file and parse Original ASM code to list 
            original_asm_lines = fileReader.PromptUserForFile("INS (*.ins)|*.ins").ReadLinesFromFile();
            original_asm_lines = original_asm_lines.Select(s => Regex.Replace(s, @"[^0-9a-zA-Z:,-_# /* *()""]+", "")).ToList();


            fileSelected = fileReader.file_select;
            modified_asm_lines = original_asm_lines.ToList();


            var originalTraceLines = new OpenFileReader().PromptUserForFile("TRC (*.trc)|*.trc").ReadLinesFromFile();

            var regex = new Regex("[ ]{2,}", RegexOptions.None);
            var original_traces = new List<string>();

            originalTraceLines.ForEach(line =>
            {
                var chestii = regex.Replace(line, " ");
                var ceva = chestii.Split(' ');

                for(var i = 0; i < ceva.Length - 1; i += 3)
                {
                    original_traces.Add($"{ceva[i]} {ceva[i + 1]} {ceva[i + 2]}");
                }
            });

           

            original_asm_lines.ForEach(s => originalCodeBox.Items.Add(s));
            original_traces.ForEach(s => originalTracesBox.Items.Add(s));
            original_Trace_Lines = original_traces.Select(trace => new Trace(trace)).ToList();
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
