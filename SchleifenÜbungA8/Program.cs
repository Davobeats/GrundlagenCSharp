using System;

namespace SchleifenÜbungA8
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = 1234;
            int versuche = 0;

            do
            {
                Console.WriteLine("PIN BESTÄTIGUNG!\nBitte geben Sie Ihren PIN ein:");
                pin = Convert.ToInt32(Console.ReadLine());
                if(versuche != pin)
                {
                    versuche = versuche + 1;
                }
                Console.Clear();
            } while (pin != 1234);
            Console.Clear();
            Console.WriteLine("Korrekt! Sie haben {0} Versuche gebraucht!",versuche);


        }
    }
}
