using System;
using System.Text;

namespace lecture3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Metodas - programos strukturinis vienetas. Metodas turetu daryti kazkoki konkretu viena veiksma. Viena priezasti egzistuoti. Metodai yra dalis klases
            // public metodas - pasiekiamas is isores. Metodo pavadinimas turi buti veiksmazodis. Statiniame kontekste turi buti naudojami statiniai metodai
            // nurodomoas duomenu tipas grazinamas

            HelloWorld();
            Console.WriteLine(Add(5, 6));
            Console.WriteLine(Add(5, 6.1));
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello Worlds!");
            // nieko negrazina, nes yra void
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }
    }
}