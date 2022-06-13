using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project
{
    class FP_calculater
    {
        


        
        public double UFP;
        public int DI;
        public double TCF;
        public double FP;
        public double LOC;

        List <Parameter> FP_Parameter = new List<Parameter>();
        List<int> DI_Factors = new List<int>();

       

        //TO calculate UFP
        public void Add_FP_Parameter(double count,int weight)
        {
            FP_Parameter.Add(new Parameter(count, weight));
        }
        

        public double Calculate_UFP()
        {
            UFP = 0;
            foreach(Parameter i in FP_Parameter)
            {
                UFP += i.Get_parameter_value();
            }
            return UFP;
        }
        //To calculate DI
        public void Add_DI_Factors(int val)
        {
            DI_Factors.Add(val);
        }
        public void Calculate_DI()
        {
            DI = 0;
            foreach(int i in DI_Factors)
            {
                DI += i;
            }
        }
        //TO calculate TCF
        public double Calculate_TCF()
        {
            TCF = 0.65 + (0.01 * DI);
            return TCF;
        }
        //To calculate FP
        public double Calculate_FP(double UFP,double TCF)
        {
            FP = UFP * TCF;
            return FP;
        }
        //To calculate LOC
        public double Calculate_LOC(double FP,int AVC)
        {
            LOC = AVC * FP;
            return LOC;
        }
    }
}
