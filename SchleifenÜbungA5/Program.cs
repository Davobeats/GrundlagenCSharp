using System;

namespace SchleifenÜbungA5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben Sie bitte eine Zahl ein:");

            decimal x = Convert.ToDecimal(Console.ReadLine());
            decimal i = -x;

            while(i<=x)
            {
                Console.Write(i+", ");
                i += 2;
            }
               



        }
    }
}
