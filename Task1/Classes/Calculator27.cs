namespace Classes
{
    public class Calculator27
    {
        public double A { get; set; }
        public double B { get; set; }


        public Calculator27(double a)
        {
            A = a;
            if (A < 50000 && A >= 0)
                B = 1.16;
            else if (A >= 50000 && A <= 100000)
                B = 1.18;
            else B = 0;
        }
        public double CalculateA()
        {
            return A * B;
        }
    }
}
