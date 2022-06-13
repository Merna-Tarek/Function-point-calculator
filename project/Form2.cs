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
    public partial class Form2 : Form

    {
        public static double TCF;
        public static double FP_result;
        FP_calculater calc = new FP_calculater();
        

        public double UFP { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

    

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Clac_TCF_Click(object sender, EventArgs e)
        {
            calc.Add_DI_Factors(combo_Data.SelectedIndex);
            calc.Add_DI_Factors(combo_Distributed.SelectedIndex);
            calc.Add_DI_Factors(combo_Performanc.SelectedIndex);
            calc.Add_DI_Factors(combo_Heavily.SelectedIndex);
            calc.Add_DI_Factors(combo_Transaction.SelectedIndex);
            calc.Add_DI_Factors(combo_OnData.SelectedIndex);
            calc.Add_DI_Factors(combo_End.SelectedIndex);
            calc.Add_DI_Factors(combo_OnUpdate.SelectedIndex);
            calc.Add_DI_Factors(combo_Complex.SelectedIndex);
            calc.Add_DI_Factors(combo_Reusability.SelectedIndex);
            calc.Add_DI_Factors(combo_Installation.SelectedIndex);
            calc.Add_DI_Factors(combo_Operational.SelectedIndex);
            calc.Add_DI_Factors(combo_Multiple.SelectedIndex);
            calc.Add_DI_Factors(combo_Faciliate.SelectedIndex);

            calc.Calculate_DI();
            
            
            label_TCF.Text= calc.Calculate_TCF().ToString();

            TCF = double.Parse(label_TCF.Text);

            

        }

       

        private void button_FP_Click(object sender, EventArgs e)
        {

            UFP = Form1.UFP_result;
            double FP = calc.Calculate_FP(TCF, UFP);
            label_FP.Text = FP.ToString();
            FP_result = FP;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 myform2 = new Form3();
            myform2.Show();
        }

        private void combo_Installation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
