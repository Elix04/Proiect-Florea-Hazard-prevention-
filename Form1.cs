using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proiect_Hazard_prevention
{
    public partial class Form1 : Form
    {
        private List<string> originalAssemblyLines;
        private List<string> modifiableAssemblyLines;
        private List<Trace> originalTracesLines;
        
        private string selectedFile = "";

        public Form1()
        {
            InitializeComponent();

            OriginalLinesTextBox.ScrollBars = ScrollBars.Vertical;
            ModifiedLinesTextBox.ScrollBars = ScrollBars.Vertical;
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            OriginalLinesListBox.Items.Clear();
            OriginalTracesListBox.Items.Clear();

            var fileReader = new FileReader();

            originalAssemblyLines = fileReader
                .PromptUserForFile("INS (*.ins)|*.ins")
                .ReadLinesFromFile();
            originalAssemblyLines = originalAssemblyLines
                .Select(s => Regex.Replace(s, @"[^0-9a-zA-Z:,-_# /* *()""]+", ""))
                .ToList();

            selectedFile = fileReader.SelectedFIle;

            modifiableAssemblyLines = originalAssemblyLines.ToList();

            var originalTraceLines = new FileReader()
                .PromptUserForFile("TRC (*.trc)|*.trc")
                .ReadLinesFromFile();

            var regex = new Regex("[ ]{2,}", RegexOptions.None);
            var originalTraces = new List<string>();

            originalTraceLines.ForEach(line =>
            {
                var stuff = regex.Replace(line, " ");
                var smth = stuff.Split(" ");

                for (var i = 0; i < smth.Length - 1; i += 3)
                {
                    originalTraces.Add($"{smth[i]} {smth[i + 1]} {smth[i + 2]}");
                }
            });

            originalAssemblyLines.ForEach(s => OriginalLinesListBox.Items.Add(s));
            originalAssemblyLines.ForEach(s => OriginalLinesTextBox.AppendText(s + Environment.NewLine));
            originalTraces.ForEach(s => OriginalTracesListBox.Items.Add(s));
            originalTracesLines = originalTraces.Select(trace => new Trace(trace)).ToList();
        }

        private void FixIssuesButton_Click(object sender, EventArgs e)
        {
            InstructionFix abstractRearrangement = new ImmediateMerging(modifiableAssemblyLines, originalTracesLines);
            modifiableAssemblyLines = abstractRearrangement.Rearrange();
            modifiableAssemblyLines.ForEach(line => ModifiedLinesListBox.Items.Add(line));
            modifiableAssemblyLines.ForEach(s => ModifiedLinesTextBox.AppendText(s + Environment.NewLine));
        }


        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (selectedFile == "")
            {
                MessageBox.Show("NO FILE SELECTED");
                return;
            }

            var path = selectedFile.Insert(selectedFile.Length - 4, "-improved");
            using (var streamWriter = File.CreateText(path))
            {
                modifiableAssemblyLines.ForEach(streamWriter.WriteLine);
            }

            MessageBox.Show("File Saved successfully");
        }
    }
}