namespace project
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_interfacefiles = new System.Windows.Forms.TextBox();
            this.textBox_logicalfiles = new System.Windows.Forms.TextBox();
            this.textBox_inquery = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.combo_interfacefiles = new System.Windows.Forms.ComboBox();
            this.combo_logicalfiles = new System.Windows.Forms.ComboBox();
            this.combo_inquery = new System.Windows.Forms.ComboBox();
            this.combo_output = new System.Windows.Forms.ComboBox();
            this.combo_input = new System.Windows.Forms.ComboBox();
            this.Calc_UFP = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Externel Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_input
            // 
            this.text_input.Location = new System.Drawing.Point(471, 54);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(109, 22);
            this.text_input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Externel Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "External Inquiry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Internal Logical Files";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "External Interface files";
            // 
            // textBox_interfacefiles
            // 
            this.textBox_interfacefiles.Location = new System.Drawing.Point(471, 247);
            this.textBox_interfacefiles.Name = "textBox_interfacefiles";
            this.textBox_interfacefiles.Size = new System.Drawing.Size(109, 22);
            this.textBox_interfacefiles.TabIndex = 11;
            // 
            // textBox_logicalfiles
            // 
            this.textBox_logicalfiles.Location = new System.Drawing.Point(471, 203);
            this.textBox_logicalfiles.Name = "textBox_logicalfiles";
            this.textBox_logicalfiles.Size = new System.Drawing.Size(109, 22);
            this.textBox_logicalfiles.TabIndex = 12;
            // 
            // textBox_inquery
            // 
            this.textBox_inquery.Location = new System.Drawing.Point(471, 156);
            this.textBox_inquery.Name = "textBox_inquery";
            this.textBox_inquery.Size = new System.Drawing.Size(109, 22);
            this.textBox_inquery.TabIndex = 14;
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(471, 108);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(109, 22);
            this.textBox_output.TabIndex = 15;
            // 
            // combo_interfacefiles
            // 
            this.combo_interfacefiles.FormattingEnabled = true;
            this.combo_interfacefiles.Items.AddRange(new object[] {
            "Simple",
            "Average",
            "Complex"});
            this.combo_interfacefiles.Location = new System.Drawing.Point(291, 247);
            this.combo_interfacefiles.Name = "combo_interfacefiles";
            this.combo_interfacefiles.Size = new System.Drawing.Size(121, 24);
            this.combo_interfacefiles.TabIndex = 17;
            // 
            // combo_logicalfiles
            // 
            this.combo_logicalfiles.FormattingEnabled = true;
            this.combo_logicalfiles.Items.AddRange(new object[] {
            "Simple",
            "Average",
            "Complex"});
            this.combo_logicalfiles.Location = new System.Drawing.Point(291, 201);
            this.combo_logicalfiles.Name = "combo_logicalfiles";
            this.combo_logicalfiles.Size = new System.Drawing.Size(121, 24);
            this.combo_logicalfiles.TabIndex = 18;
            // 
            // combo_inquery
            // 
            this.combo_inquery.FormattingEnabled = true;
            this.combo_inquery.Items.AddRange(new object[] {
            "Simple",
            "Average",
            "Complex"});
            this.combo_inquery.Location = new System.Drawing.Point(291, 154);
            this.combo_inquery.Name = "combo_inquery";
            this.combo_inquery.Size = new System.Drawing.Size(121, 24);
            this.combo_inquery.TabIndex = 19;
            // 
            // combo_output
            // 
            this.combo_output.FormattingEnabled = true;
            this.combo_output.Items.AddRange(new object[] {
            "Simple",
            "Average",
            "Complex"});
            this.combo_output.Location = new System.Drawing.Point(291, 108);
            this.combo_output.Name = "combo_output";
            this.combo_output.Size = new System.Drawing.Size(121, 24);
            this.combo_output.TabIndex = 20;
            // 
            // combo_input
            // 
            this.combo_input.FormattingEnabled = true;
            this.combo_input.Items.AddRange(new object[] {
            "Simple",
            "Average",
            "Complex"});
            this.combo_input.Location = new System.Drawing.Point(291, 58);
            this.combo_input.Name = "combo_input";
            this.combo_input.Size = new System.Drawing.Size(121, 24);
            this.combo_input.TabIndex = 21;
            // 
            // Calc_UFP
            // 
            this.Calc_UFP.Location = new System.Drawing.Point(280, 315);
            this.Calc_UFP.Name = "Calc_UFP";
            this.Calc_UFP.Size = new System.Drawing.Size(148, 38);
            this.Calc_UFP.TabIndex = 22;
            this.Calc_UFP.Text = "Calculate_UFP";
            this.Calc_UFP.UseVisualStyleBackColor = true;
            this.Calc_UFP.Click += new System.EventHandler(this.Calc_UFP_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(345, 406);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(0, 17);
            this.result_label.TabIndex = 23;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(623, 470);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(94, 30);
            this.btn_next.TabIndex = 24;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 535);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.Calc_UFP);
            this.Controls.Add(this.combo_input);
            this.Controls.Add(this.combo_output);
            this.Controls.Add(this.combo_inquery);
            this.Controls.Add(this.combo_logicalfiles);
            this.Controls.Add(this.combo_interfacefiles);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_inquery);
            this.Controls.Add(this.textBox_logicalfiles);
            this.Controls.Add(this.textBox_interfacefiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_interfacefiles;
        private System.Windows.Forms.TextBox textBox_logicalfiles;
        private System.Windows.Forms.TextBox textBox_inquery;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.ComboBox combo_interfacefiles;
        private System.Windows.Forms.ComboBox combo_logicalfiles;
        private System.Windows.Forms.ComboBox combo_inquery;
        private System.Windows.Forms.ComboBox combo_output;
        private System.Windows.Forms.ComboBox combo_input;
        private System.Windows.Forms.Button Calc_UFP;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Button btn_next;
    }
}

