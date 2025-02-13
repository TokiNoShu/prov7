namespace Classes
{
    public class Calculator30
    {
        public double K { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double N { get; set; }



        public Calculator30(double k, double l, double m, double n)
        {
            K = k;
            L = l;
            M = m;
            N = n;
        }
        public bool CalculateA()
        {
            return K == 0 == L > M && (K < 0 == 2 * L - 3 * N < M);
        }
    }
}
