using System;

namespace SchleifenÜbungenA7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            int n = Convert.ToInt32(Console.ReadLine());
            int zahl = 0;

            for (int i = 0; i <= n; i++) 
            {

                zahl = zahl + i;
                Console.WriteLine(zahl);

            }




        }
    }
}
