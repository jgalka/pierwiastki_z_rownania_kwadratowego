using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RownanieKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, c, delta, x1, x2;
                Console.WriteLine("Podaj a:");
                a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    throw new Exception("Parametr musi być rózny od zera");
                }
                Console.WriteLine("Podaj b:");
                b = Convert.ToDouble(Console.ReadLine());
                if (b == 0)
                {
                    throw new Exception("Parametr musi być rózny od zera");
                }
                Console.WriteLine("Podaj c:");
                c = Convert.ToDouble(Console.ReadLine());
                if (c == 0)
                {
                    throw new Exception("Parametr musi być rózny od zera");
                }
                delta = (b * b) - (4 * a * c);
                if (delta > 0)
                {
                    x1 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);
                    x2 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Rownanie ma dwa pierwiastki");
                    Console.WriteLine("\tx1 = {0}", x1);
                    Console.WriteLine("\tx2 = {0}", x2);
                    Console.ReadKey(true);
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty");
                    Console.WriteLine("\tx1 = {0}", x1);
                }
                else
                {
                    Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Program został przerwany - {0}", ex.Message);
                Console.ReadKey(true);
            }

        }
    }
}
