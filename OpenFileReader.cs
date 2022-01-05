using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Proiect_Florea__Hazard_prevention_
{
    public class OpenFileReader
    {

        public string file_select;
        char[] delim = new[] { '\n', '\r' };

        public string ReadFromFile()
        {
            var fileStream = new StreamReader(file_select);
            return fileStream.ReadToEnd();
        }

        public OpenFileReader PromptUserForFile(string format)
        {
            var fileDialog = new OpenFileDialog { Filter = format };
            var dialogResult = fileDialog.ShowDialog();
            file_select = dialogResult == DialogResult.OK ? fileDialog.FileName : null;
            return this;
        }

        public List<string> ReadLinesFromFile()
        {
            return ReadFromFile().Split(delim).ToList();
        }
    }
}