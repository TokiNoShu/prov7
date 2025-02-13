using System;

namespace Classes
{
    public class Calculator23
    {
        public int N { get; set; }


        public Calculator23(double n)
        {
            N = Convert.ToInt32(n);
        }
        public bool CalculateA()
        {
            return N % 4 == 0 || N % 7 == 0;
        }
        public bool CalculateB()
        {
            return N % 5 == 0 || N % 10 != 0;
        }
    }
}
