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
    public partial class Form3 : Form
    {
        FP_calculater calc= new FP_calculater();
        public Form3()
        {
            InitializeComponent();
        }

        public double FP { get; private set; }

        private void button_LOC_Click(object sender, EventArgs e)
        {
            FP = Form2.FP_result;
            if(comboBox1.SelectedIndex==0)
            {
                label_LOC.Text = calc.Calculate_LOC(FP,320).ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 128).ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 105).ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 90).ToString();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 70).ToString();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 64).ToString();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 32).ToString();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                label_LOC.Text = calc.Calculate_LOC(FP,30).ToString();
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 22).ToString();
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 15).ToString();
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 12).ToString();
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 6).ToString();
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                label_LOC.Text = calc.Calculate_LOC(FP, 4).ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
