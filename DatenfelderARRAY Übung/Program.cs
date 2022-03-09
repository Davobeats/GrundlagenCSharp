using System;

namespace DatenfelderARRAY_Übung
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] Noten = new int[20];

            int note = 0;

            double Summe = 0;

            for(int i = 0; i<Noten.Length;i++)
            {
                Console.WriteLine("Welche Note hat der Schüler?");
                
                note = Convert.ToInt32(Console.ReadLine());

                Noten[i] = note;

                Summe = Summe + note;
            }

            foreach (int i in Noten) 
            {
                Console.WriteLine(Noten[i]);
            }
            Console.WriteLine($"Der Notendurschnitt ist: {Summe/20:F2}");




            






        }
    }
}
