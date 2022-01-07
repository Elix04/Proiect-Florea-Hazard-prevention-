namespace Proiect_Hazard_prevention
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.OriginalLinesListBox = new System.Windows.Forms.ListBox();
            this.FixIssuesButton = new System.Windows.Forms.Button();
            this.OriginalTracesListBox = new System.Windows.Forms.ListBox();
            this.ModifiedLinesListBox = new System.Windows.Forms.ListBox();
            this.OriginalLinesTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedLinesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(125, 541);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load a file";
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(125, 561);
            this.LoadFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(130, 35);
            this.LoadFileButton.TabIndex = 2;
            this.LoadFileButton.Text = "Browse";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(1086, 572);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(198, 36);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // OriginalLinesListBox
            // 
            this.OriginalLinesListBox.FormattingEnabled = true;
            this.OriginalLinesListBox.ItemHeight = 15;
            this.OriginalLinesListBox.Location = new System.Drawing.Point(50, 104);
            this.OriginalLinesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OriginalLinesListBox.Name = "OriginalLinesListBox";
            this.OriginalLinesListBox.Size = new System.Drawing.Size(205, 364);
            this.OriginalLinesListBox.TabIndex = 5;
            // 
            // FixIssuesButton
            // 
            this.FixIssuesButton.Location = new System.Drawing.Point(261, 561);
            this.FixIssuesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FixIssuesButton.Name = "FixIssuesButton";
            this.FixIssuesButton.Size = new System.Drawing.Size(130, 36);
            this.FixIssuesButton.TabIndex = 8;
            this.FixIssuesButton.Text = "Fix issues";
            this.FixIssuesButton.UseVisualStyleBackColor = true;
            this.FixIssuesButton.Click += new System.EventHandler(this.FixIssuesButton_Click);
            // 
            // OriginalTracesListBox
            // 
            this.OriginalTracesListBox.FormattingEnabled = true;
            this.OriginalTracesListBox.ItemHeight = 15;
            this.OriginalTracesListBox.Location = new System.Drawing.Point(263, 104);
            this.OriginalTracesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OriginalTracesListBox.Name = "OriginalTracesListBox";
            this.OriginalTracesListBox.Size = new System.Drawing.Size(205, 364);
            this.OriginalTracesListBox.TabIndex = 11;
            // 
            // ModifiedLinesListBox
            // 
            this.ModifiedLinesListBox.FormattingEnabled = true;
            this.ModifiedLinesListBox.ItemHeight = 15;
            this.ModifiedLinesListBox.Location = new System.Drawing.Point(476, 104);
            this.ModifiedLinesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModifiedLinesListBox.Name = "ModifiedLinesListBox";
            this.ModifiedLinesListBox.Size = new System.Drawing.Size(205, 364);
            this.ModifiedLinesListBox.TabIndex = 13;
            // 
            // OriginalLinesTextBox
            // 
            this.OriginalLinesTextBox.Location = new System.Drawing.Point(1079, 104);
            this.OriginalLinesTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OriginalLinesTextBox.Multiline = true;
            this.OriginalLinesTextBox.Name = "OriginalLinesTextBox";
            this.OriginalLinesTextBox.Size = new System.Drawing.Size(205, 364);
            this.OriginalLinesTextBox.TabIndex = 14;
            // 
            // ModifiedLinesTextBox
            // 
            this.ModifiedLinesTextBox.Location = new System.Drawing.Point(866, 104);
            this.ModifiedLinesTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModifiedLinesTextBox.Multiline = true;
            this.ModifiedLinesTextBox.Name = "ModifiedLinesTextBox";
            this.ModifiedLinesTextBox.Size = new System.Drawing.Size(205, 364);
            this.ModifiedLinesTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Original Lines:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(261, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Original Traces:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(474, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Modified Lines:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1079, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Original Code TEXT:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(866, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Modified Code TEXT:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1335, 620);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModifiedLinesTextBox);
            this.Controls.Add(this.OriginalLinesTextBox);
            this.Controls.Add(this.ModifiedLinesListBox);
            this.Controls.Add(this.OriginalTracesListBox);
            this.Controls.Add(this.FixIssuesButton);
            this.Controls.Add(this.OriginalLinesListBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.LoadFileButton);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.ListBox OriginalLinesListBox;
        private System.Windows.Forms.Button FixIssuesButton;
        private System.Windows.Forms.ListBox OriginalTracesListBox;
        private System.Windows.Forms.ListBox ModifiedLinesListBox;
        private System.Windows.Forms.TextBox OriginalLinesTextBox;
        private System.Windows.Forms.TextBox ModifiedLinesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

