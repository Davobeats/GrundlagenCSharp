using System;

namespace SchleifenÜbungA5
{
    class Program
    {
        static void Main(string[] args)
        {


            int auswahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wählen Sie eine Positive Zahl(1) oder eine negative Zahl(2)");
            Console.ReadLine();

            
            

            if (auswahl == 1) 
            for (int i = 0; i >= 0; i++) 
            {
                    Console.Write(i);    
            }

            if(auswahl==2)
            for(int i = 0; i<=0; i--)
                {
                    Console.Write(i); 
                }
        }
    }
}
