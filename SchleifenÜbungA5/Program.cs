using System;

namespace SchleifenÜbungA5
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0, n = i * -1;

            Console.WriteLine("Geben Sie bitte eine Ziffer ein!");
            for (i = Convert.ToInt32(Console.ReadLine()); n<=i;n=n+2) 
            {

                Console.Write(n);
                Console.Write(" ");

            }
           


        }
    }
}
