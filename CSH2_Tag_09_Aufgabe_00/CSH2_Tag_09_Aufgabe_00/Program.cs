using System;

namespace CSH2_Tag_09_Aufgabe_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportler s = new Sportler();

            s.FühreAktionAus(Schwimmen);
            s.FühreAktionAus(Laufen);

            Console.ReadKey(true);
        }

        static void Schwimmen()
        {
            Console.WriteLine("Ich schwimme");
        }

        static void Laufen()
        {
            Console.WriteLine("Ich laufe");
        }
    }
}
