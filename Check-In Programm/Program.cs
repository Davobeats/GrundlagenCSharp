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
            double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };


                Console.WriteLine("Hallo. Wenn Sie mit Ihrem Nachnamen einchecken wollen, schreiben Sie irgendeinen Buchstaben.\n" +
                "Wenn Sie mit Ihrer Zimmernummer einchecken wollen, geben Sie irgendeine Zahl ein.\n" +
                "Sie werden weitergeleitet.");
                string eingabe_string = Console.ReadLine();

                short eingabe_short;
                var data = (true, 0, "", "", 0, 0.0);


                bool flag = short.TryParse(eingabe_string, out eingabe_short);

                switch (flag)
                {
                    case false:
                        data = GetData(eingabe_string, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag);
                        break;

                    case true:

                        data = GetData(eingabe_short, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag);
                        break;
                }

               Console.WriteLine(GetData(eingabe_string, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag));


        }

        static (bool, short, string, string, short, double) GetData(short diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {
            Console.WriteLine("Sie haben eine Zahl eingegeben und checken dadurch mit Ihrer Zimmernummer ein.\n" +
            "Welche Zimmernummer haben Sie?");
            short Zinum = Convert.ToInt16(Console.ReadLine());

            short index = 0;

            for (short i = 0; i < zn.Length; i++)
            {
                Zinum = i;
                if (diff == zn[i])
                {
                    index = i;
                }
            }


            return (false, zn[index], nn[index], vn[index], ue[index], rb[index]);
        }

        static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {
            Console.WriteLine("Sie haben einen Buchstaben eingegeben und checken dadurch mit Ihrem Nachnamen ein.\n" +
            "Welchen Namen haben Sie?");

            string name = Convert.ToString(Console.ReadLine());

            short index = 0;
            for (short i = 0; i < zn.Length; i++)
            {

                if (diff == nn[i])
                {
                    index = i;
                }
            }

            return (false, zn[index], nn[index], vn[index], ue[index], rb[index]);
        }
    }
}
