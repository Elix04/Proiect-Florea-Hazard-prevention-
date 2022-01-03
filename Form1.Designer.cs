
namespace Proiect_Florea__Hazard_prevention_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.load_btn = new System.Windows.Forms.Button();
            this.originalCode = new System.Windows.Forms.ListBox();
            this.originalTraces = new System.Windows.Forms.ListBox();
            this.fix_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modifiedCode = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.modifiedLinesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(107, 473);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(168, 51);
            this.load_btn.TabIndex = 0;
            this.load_btn.Text = "Load File";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // originalCode
            // 
            this.originalCode.FormattingEnabled = true;
            this.originalCode.Location = new System.Drawing.Point(107, 42);
            this.originalCode.Name = "originalCode";
            this.originalCode.Size = new System.Drawing.Size(236, 355);
            this.originalCode.TabIndex = 1;
            // 
            // originalTraces
            // 
            this.originalTraces.FormattingEnabled = true;
            this.originalTraces.Location = new System.Drawing.Point(365, 42);
            this.originalTraces.Name = "originalTraces";
            this.originalTraces.Size = new System.Drawing.Size(236, 355);
            this.originalTraces.TabIndex = 2;
            // 
            // fix_btn
            // 
            this.fix_btn.Location = new System.Drawing.Point(107, 530);
            this.fix_btn.Name = "fix_btn";
            this.fix_btn.Size = new System.Drawing.Size(168, 52);
            this.fix_btn.TabIndex = 3;
            this.fix_btn.Text = "Fix Code";
            this.fix_btn.UseVisualStyleBackColor = true;
            this.fix_btn.Click += new System.EventHandler(this.fix_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original  Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Original Traces ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // modifiedCode
            // 
            this.modifiedCode.FormattingEnabled = true;
            this.modifiedCode.Location = new System.Drawing.Point(623, 42);
            this.modifiedCode.Name = "modifiedCode";
            this.modifiedCode.Size = new System.Drawing.Size(236, 355);
            this.modifiedCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modified Code";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modified Lines";
            // 
            // modifiedLinesTextBox
            // 
            this.modifiedLinesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modifiedLinesTextBox.Location = new System.Drawing.Point(623, 436);
            this.modifiedLinesTextBox.Multiline = true;
            this.modifiedLinesTextBox.Name = "modifiedLinesTextBox";
            this.modifiedLinesTextBox.Size = new System.Drawing.Size(236, 146);
            this.modifiedLinesTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 594);
            this.Controls.Add(this.modifiedLinesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modifiedCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fix_btn);
            this.Controls.Add(this.originalTraces);
            this.Controls.Add(this.originalCode);
            this.Controls.Add(this.load_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.ListBox originalCode;
        private System.Windows.Forms.ListBox originalTraces;
        private System.Windows.Forms.Button fix_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox modifiedCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modifiedLinesTextBox;
    }
}

