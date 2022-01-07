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
            this.label1.Location = new System.Drawing.Point(49, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load a file";
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(146, 75);
            this.LoadFileButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(91, 38);
            this.LoadFileButton.TabIndex = 2;
            this.LoadFileButton.Text = "Browse";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(806, 53);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(283, 60);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // OriginalLinesListBox
            // 
            this.OriginalLinesListBox.FormattingEnabled = true;
            this.OriginalLinesListBox.ItemHeight = 25;
            this.OriginalLinesListBox.Location = new System.Drawing.Point(71, 173);
            this.OriginalLinesListBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OriginalLinesListBox.Name = "OriginalLinesListBox";
            this.OriginalLinesListBox.Size = new System.Drawing.Size(291, 604);
            this.OriginalLinesListBox.TabIndex = 5;
            // 
            // FixIssuesButton
            // 
            this.FixIssuesButton.Location = new System.Drawing.Point(574, 53);
            this.FixIssuesButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.FixIssuesButton.Name = "FixIssuesButton";
            this.FixIssuesButton.Size = new System.Drawing.Size(186, 60);
            this.FixIssuesButton.TabIndex = 8;
            this.FixIssuesButton.Text = "Fix issues";
            this.FixIssuesButton.UseVisualStyleBackColor = true;
            this.FixIssuesButton.Click += new System.EventHandler(this.FixIssuesButton_Click);
            // 
            // OriginalTracesListBox
            // 
            this.OriginalTracesListBox.FormattingEnabled = true;
            this.OriginalTracesListBox.ItemHeight = 25;
            this.OriginalTracesListBox.Location = new System.Drawing.Point(373, 173);
            this.OriginalTracesListBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OriginalTracesListBox.Name = "OriginalTracesListBox";
            this.OriginalTracesListBox.Size = new System.Drawing.Size(291, 604);
            this.OriginalTracesListBox.TabIndex = 11;
            // 
            // ModifiedLinesListBox
            // 
            this.ModifiedLinesListBox.FormattingEnabled = true;
            this.ModifiedLinesListBox.ItemHeight = 25;
            this.ModifiedLinesListBox.Location = new System.Drawing.Point(1114, 173);
            this.ModifiedLinesListBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ModifiedLinesListBox.Name = "ModifiedLinesListBox";
            this.ModifiedLinesListBox.Size = new System.Drawing.Size(291, 604);
            this.ModifiedLinesListBox.TabIndex = 13;
            // 
            // OriginalLinesTextBox
            // 
            this.OriginalLinesTextBox.Location = new System.Drawing.Point(71, 853);
            this.OriginalLinesTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OriginalLinesTextBox.Multiline = true;
            this.OriginalLinesTextBox.Name = "OriginalLinesTextBox";
            this.OriginalLinesTextBox.Size = new System.Drawing.Size(291, 337);
            this.OriginalLinesTextBox.TabIndex = 14;
            // 
            // ModifiedLinesTextBox
            // 
            this.ModifiedLinesTextBox.Location = new System.Drawing.Point(1114, 853);
            this.ModifiedLinesTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ModifiedLinesTextBox.Multiline = true;
            this.ModifiedLinesTextBox.Name = "ModifiedLinesTextBox";
            this.ModifiedLinesTextBox.Size = new System.Drawing.Size(291, 337);
            this.ModifiedLinesTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(71, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Original Lines:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(373, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Original Traces:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1114, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Modified Lines:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(71, 820);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Original Code TEXT:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1114, 820);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Modified Code TEXT:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1494, 1273);
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
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
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

