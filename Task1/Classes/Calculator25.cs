namespace Classes
{
    public class Calculator25
    {
        public double N { get; set; }


        public Calculator25(double n)
        {
            N = n;
        }
        public bool CalculateA()
        {
            return N % 3 == 0 && N % 9 != 0 && (N % 4 == 0 == (N % 5 == 0 && N % 3 == 0));
        }
    }
}
