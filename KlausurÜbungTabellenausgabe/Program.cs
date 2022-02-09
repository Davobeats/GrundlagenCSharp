using System;

namespace KlausurÜbungTabellenausgabe
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double K = 0, j = 0, p = 0, bil = 0, kz = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.Write("Geben Sie Ihr Kapital ein:\n");
            K = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Geben Sie Ihren Prozentsatz ein:\n");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Clear();


            Console.Write("Für wieviele Jahre soll Ihr Zinssatz ausgerechnet werden?\n");
            j = Convert.ToDouble(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("{0,4}{1,11}{2,9}{3,11}{4,8}\n","Jahr ","Guthaben ", "Zinsen ", "K.Zinsen ", "Bilanz ");
            
            for(int i = 0; i<= 43; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();

            for(int Jahr = 0;Jahr <=j;Jahr++)
            {
                

                kz = kz + K * (p / 100);
                bil = bil + K;
                if (Jahr == j)
                {
                    for (int i = 0; i <= 43; i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("{0,3}| {1,9:F2}€| {2,6:F2}€| {3,8:F2}€| {4,6:F2}€", Jahr, K, K * (p/100), kz,bil);
                K = K + (K * (p/100));




            }


                 
            


        }
    }
}
