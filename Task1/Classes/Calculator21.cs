using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator21
    {
        public double A { get; set; }
        public double B { get; set; }


        public Calculator21(double a)
        {
            A = a;
            if (A > 2 && A <= 5)
            {
                B = 12;
            }
            if (A > 5)
            {
                B = 13;
            }
            if (A < 2)
            {
                B = 11;
            }
        }
        public double CalculateA()
        {
            return B;
        }
    }
}
