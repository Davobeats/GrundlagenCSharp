using System;

namespace SchleifenÜbungA5
{
    class Program
    {
        static void Main(string[] args)
        {
            double variable = 0;
            int auswahl = 0;

            Console.WriteLine("Wählen Sie eine Positive Zahl(1) oder eine negative Zahl(2)");
            Console.ReadLine();


            if (auswahl == 1) ;
            do
            {
                variable = variable + 1;
                Console.Write(variable);
            
            } while (variable < 0) ;


              if (auswahl == 2) ;
              do
              {
                variable = variable - 1;
                Console.Write(variable);
              } while (variable > 0);

        }
    }
}
