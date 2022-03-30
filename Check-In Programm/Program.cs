using System;

namespace Check_In_Programm
{
    class Program
    {
        static void Main(string[] args)
        {

            short[] zimmernummer = { 45, 23, 3, 32 };
            string[] vorname = { "John", "Paul", "George", "Ringo" };
            string[] nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] übernachtungen = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = {82.46 ,329.84, 989.52, 247.38};

            Console.WriteLine("Hallo. Möchten Sie über Ihren Nachnamen(1) oder Zimmernummer einchecken?(2)");
            short eingabe = Convert.ToInt16(Console.ReadLine());

            if (eingabe == 1)
            {
                Console.WriteLine("Okay, Sie möchten mit Ihrem Nachnamen einchecken.");
                nachname = Name_Checkin(nachname);
            }

            if (eingabe == 2)
            {
                Console.WriteLine("Okay, Sie möchten mit Ihrer Zimmernummer einchecken.");
                zimmernummer = Zimmer_Checkin(zimmernummer);
            }

            Console.WriteLine("Okay, {0} Willkommen.");
        }

        static string[] Name_Checkin (string[] naname)
        {
            string[] ganz_name = naname;

            return naname;
        }

        static short[] Zimmer_Checkin (short[] zimmer)
        {
            short[] zimmer_nummer = zimmer;

            return zimmer;
        }


    }
}
