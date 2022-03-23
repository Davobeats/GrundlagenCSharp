using System;

namespace MethodenÜbung1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie ein wie oft es ausgegeben werden soll:");
            double anzahl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie Irgendwas ein:");
            string name = Convert.ToString(Console.ReadLine());
            anzahl = ausgabeTextMalX(anzahl,name);

            
            Console.WriteLine("\nAnzahl der Buchstaben: {0}", anzahl);
        }
        
        static double ausgabeTextMalX(double durchlauf,string name)
        {
            int anz_zeichen = name.Length;
            double anz_aller_zeichen = anz_zeichen * durchlauf;
            for (int i = 0; i<=anz_zeichen;i++)
            {
                Console.WriteLine(name);
            }

            return anz_aller_zeichen;
        }

        
    }
}
