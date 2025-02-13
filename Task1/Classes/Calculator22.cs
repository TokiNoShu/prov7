namespace Classes
{
    public class Calculator22
    {
        public double A {  get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public Calculator22(double a, double b, double c) 
        {
            A = a;
            B = b;
            C = c;
        }
        public bool CalculateA()
        { 
            return (A % 2 == 0 && B % 2 != 0) || (A % 2 != 0 && B % 2 == 0);
        }
        public bool CalculateB() 
        {
            return A % 3 == 0 && B % 3 == 0 && C % 3 == 0;
        }
    }
}
