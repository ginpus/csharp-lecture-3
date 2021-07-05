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

            /* HelloWorld();
             Console.WriteLine(Add(5, 6));
             Console.WriteLine(Add(5, 6.1));*/

            // ----------------------STACIAKAMPIO PERIMETRAS---------------------------------------------

            // main metode kviečiamas naujas metodas CalculatePerimeter, kuris grazina stačiojo trikampio perimetrą
            // ir jame apskaičiuojame stačiojo trikampio perimetrą P = a + b + c, kur c = šaknis(a * a + b * b);
            // a ir b reikšmės gaunamos naudojant Console.ReadLine()

            /*            Console.Write("Iveskite pirma statine: ");
                        var a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Iveskite antra statine: ");
                        var b = Convert.ToInt32(Console.ReadLine());
                        Console.Write(CalculatePerimeter(a, b));*/
            // ------------------------------------------------------------------------------------

            // ----------------------SKAICIUOJAM KIEK SIMBOLIU BE LENGTH---------------------------
            /*            Write a program to find the length of a string without using "length" property
            Test Data:
                        Input the string : w3resource.com
                        Expected Output:
                        Length of the string is : 15*/

            Console.Write("Iveskite teksta: ");
            var text = Console.ReadLine();
            Console.Write($"Length of the string is : {FindLength(text)}");

            // ------------------------------------------------------------------------------------
        }

        // ----------------------SKAICIUOJAM KIEK SIMBOLIU BE LENGTH---------------------------

        private static int FindLength(string input)
        {
            int count = 0;
            foreach (char symbol in input)
            {
                count++;
            }

            return count;
        }

        // ------------------------------------------------------------------------------------

        // ----------------------STACIAKAMPIO PERIMETRAS---------------------------------------------
        // main metode kviečiamas naujas metodas CalculatePerimeter, kuris grazina stačiojo trikampio perimetrą
        // ir jame apskaičiuojame stačiojo trikampio perimetrą P = a + b + c, kur c = šaknis(a * a + b * b);
        // a ir b reikšmės gaunamos naudojant Console.ReadLine()

        /*        private static double CalculatePerimeter(int a, int b)
                {
                    return a + b + Math.Sqrt(a * a + b * b);
                }*/
        // ------------------------------------------------------------------------------------

        /*private static void HelloWorld()
        {
            Console.WriteLine("Hello Worlds!");
            // nieko negrazina, nes yra void (ir neturi return)
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }*/
    }
}