using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        FP_calculater calc = new FP_calculater();
        public static double UFP_result;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calc_UFP_Click(object sender, EventArgs e)
        {
            //FOR EXTERNEL INPUT
            if(combo_input.SelectedIndex==0)
            {
                calc.Add_FP_Parameter(int.Parse(text_input.Text), 3);
            }
            else if(combo_input.SelectedIndex == 1)
            {
                calc.Add_FP_Parameter(int.Parse(text_input.Text), 4);
            }
            else if(combo_input.SelectedIndex == 2)
            {
                calc.Add_FP_Parameter(int.Parse(text_input.Text), 6);
            }
            //FOR EXTERNEL OUTPUT
            if (combo_output.SelectedIndex == 0)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_output.Text), 4);
            }
            else if (combo_output.SelectedIndex == 1)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_output.Text), 5);
            }
            else if (combo_output.SelectedIndex == 2)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_output.Text), 7);
            }
            //FOR EXTERNEL INQUERY
            if (combo_inquery.SelectedIndex == 0)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_inquery.Text), 3);
            }
            else if (combo_inquery.SelectedIndex == 1)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_inquery.Text), 4);
            }
            else if (combo_inquery.SelectedIndex == 2)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_inquery.Text), 6);
            }
            //FOR ENTERNEL LOGICAL FILES
            if (combo_logicalfiles.SelectedIndex == 0)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_logicalfiles.Text), 7);
            }
            else if (combo_logicalfiles.SelectedIndex == 1)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_logicalfiles.Text), 10);
            }
            else if (combo_logicalfiles.SelectedIndex == 2)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_logicalfiles.Text), 15);
            }
            //FOR EXTERNEL INTERFAC FILES
            if (combo_interfacefiles.SelectedIndex == 0)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_interfacefiles.Text), 5);
            }
            else if (combo_interfacefiles.SelectedIndex == 1)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_interfacefiles.Text), 7);
            }
            else if (combo_interfacefiles.SelectedIndex == 2)
            {
                calc.Add_FP_Parameter(int.Parse(textBox_interfacefiles.Text), 10);
            }
            result_label.Text = calc.Calculate_UFP().ToString();
            UFP_result = int.Parse(result_label.Text);

        }

        private void btn_next_Click(object sender, EventArgs e)
        {

            Form2 myform = new Form2();
            myform.Show();
        }
    }
}
