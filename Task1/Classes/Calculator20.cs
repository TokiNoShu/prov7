using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator20
    {
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool Z { get; set; }

        public bool CalculateA(int x, int y, int z)
        {
            {
                if (x == 1)
                    X = true;
                else X = false;
                if (y == 1)
                    Y = true;
                else Y = false;
                if (z == 1)
                    Z = true;
                else Z = false;
                return X && !(!Y || Z) || Y;
            }
        }
        public void CalculateB()
        {
            for (int x = 0; x <= 1; x++)
            {
                for (int y = 0; y <= 1; y++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        bool result = CalculateA(x, y, z);
                        Console.WriteLine("  -----------------------------");
                        if (result)
                        {
                            Console.WriteLine($"  |  {x}  |  {y}  |  {z}  |  {result}   |");
                        }
                        else
                        {
                            Console.WriteLine($"  |  {x}  |  {y}  |  {z}  |  {result}  |");
                        }

                    }
                }
            }
            Console.WriteLine("  -----------------------------");
        }
    }
}
