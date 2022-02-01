using System;

namespace SchleifenÜbungen6
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ende = false;

            

            Console.WriteLine("Bitte geben Sie eine 0 ein, um das Programm zu beenden.");
            Console.ReadLine();

            do
            {

                Console.WriteLine("Sie sollen eine 0 eingeben, um das Programm zu verlassen!");
                ende = true;
            } while (!ende);
            if (ende)
            
                Environment.Exit(0);
            


        }
    }
}
