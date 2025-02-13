using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator24
    {
        public double K { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double N { get; set; }



        public Calculator24(double k, double l, double m, double n)
        {
            K = k;
            L = l;
            M = m;
            N = n;
        }
        public bool CalculateA()
        {
            return (N + M) > K && N > K == M < L;
        }
    }
}
