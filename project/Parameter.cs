using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Parameter
    {
        private double count;
        private int weight;

        public Parameter(double count, int weight)
        {
            this.count = count;
            this.weight = weight;
        }

        public double Get_parameter_value()
        {
            return count * weight;
        }
    }
}
