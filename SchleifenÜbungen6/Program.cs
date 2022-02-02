using System;

namespace SchleifenÜbungen6
{
    class Program
    {
        static void Main(string[] args)
        {


            int ende = 0;
            Console.WriteLine("Bitte geben Sie eine 0 ein, um das Programm zu beenden.");
            Console.ReadLine();

            do
            {

                Console.WriteLine("Sie sollen eine 0 eingeben, um das Programm zu verlassen!");
                Console.ReadLine();

            } while (ende != 0);


        }
    }
}
