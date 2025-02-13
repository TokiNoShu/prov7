using System;

namespace Classes
{
    public class Calculator26
    {
        public double K { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double N { get; set; }



        public Calculator26(double k, double l, double m, double n)
        {
            K = k;
            L = l;
            M = m;
            N = n;
        }
        public bool CalculateA()
        {
            return N > 1 || (M <= L + K && L + K == 0) && (N > 2 == (Math.Pow(M, 2) > Math.Pow(L, 2)));
        }
    }
}
