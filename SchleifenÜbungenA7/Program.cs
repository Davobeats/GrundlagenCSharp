using System;

namespace SchleifenÜbungenA7
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Geben Sie eine Zahl ein:");

            int zahl = 0, n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; n >= i;i++) ;
            {
                zahl = zahl + n;
            }
            Console.WriteLine(zahl);







        }
    }
}
