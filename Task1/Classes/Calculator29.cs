using System;

namespace Classes
{
    public class Calculator29
    {
        public int N { get; set; }


        public Calculator29(double n)
        {
            N = Convert.ToInt32(n);
        }
        public bool CalculateA()
        {
            return N % 3 != 0 && N % 7 == 0 && N % 10 == 0;
        }
    }
}
