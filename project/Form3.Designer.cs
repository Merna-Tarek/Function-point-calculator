namespace project
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_LOC = new System.Windows.Forms.Button();
            this.label_LOC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "The programming language";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Assembly Language",
            "C",
            "COBOL/Fortan",
            "Pascal",
            "Ada",
            "C++",
            "Visaual Basic",
            "Object-Oriented Languages",
            "Smalltalk",
            "Code Generators (PowerBulder)",
            "SQL/Oracle",
            "Spreadsheets",
            "Graphical Languages (icons)"});
            this.comboBox1.Location = new System.Drawing.Point(440, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button_LOC
            // 
            this.button_LOC.Location = new System.Drawing.Point(287, 173);
            this.button_LOC.Name = "button_LOC";
            this.button_LOC.Size = new System.Drawing.Size(158, 44);
            this.button_LOC.TabIndex = 2;
            this.button_LOC.Text = "Calculate LOC";
            this.button_LOC.UseVisualStyleBackColor = true;
            this.button_LOC.Click += new System.EventHandler(this.button_LOC_Click);
            // 
            // label_LOC
            // 
            this.label_LOC.AutoSize = true;
            this.label_LOC.Location = new System.Drawing.Point(348, 241);
            this.label_LOC.Name = "label_LOC";
            this.label_LOC.Size = new System.Drawing.Size(0, 17);
            this.label_LOC.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_LOC);
            this.Controls.Add(this.button_LOC);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_LOC;
        private System.Windows.Forms.Label label_LOC;
    }
}