using System;

namespace MethodenÜbung1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben Sie etwas ein:");
            double anzahl = Convert.ToDouble(Console.ReadLine());
            anzahl = ausgabeTextMalX(anzahl);
            Console.WriteLine("\nAnzahl der Buchstaben: {0}", anzahl);
        }
        
        static double ausgabeTextMalX(double anzahl)
        {
            string name = "";
            Console.WriteLine("Was ist ihr Name?");
            name = Convert.ToString(Console.ReadLine());
            for(double i = anzahl; i<=anzahl; i++)
            {
                Console.WriteLine(i);
            }
            
            return anzahl;
        }

        
    }
}
