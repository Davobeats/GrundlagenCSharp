using System;

namespace SchleifenÜbungen6
{
    class Program
    {
        static void Main(string[] args)
        {


            int ende = 1;


            do
            {

                Console.WriteLine("Sie sollen eine 0 eingeben, um das Programm zu verlassen!");
                ende= Convert.ToInt32(Console.ReadLine());

            } while (ende != 0);


        }
    }
}
