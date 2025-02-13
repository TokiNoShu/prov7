using System;

namespace Classes
{
    public class Calculator28
    {
        public int N { get; set; }


        public Calculator28(double n)
        {
            N = Convert.ToInt32(n);
        }
        public bool CalculateA()
        {
            return N % 2 == 0 && N % 7 == 0 && N % 11 != 0 && N % 13 != 0;
        }
    }
}
