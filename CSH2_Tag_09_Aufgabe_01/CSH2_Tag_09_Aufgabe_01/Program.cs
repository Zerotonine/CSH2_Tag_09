using System;

namespace CSH2_Tag_09_Aufgabe_01
{
    class Program
    {
        delegate void Ausgabe(string[] strArr);
        static void Main(string[] args)
        {
            string[] strings = { "Die", "WBS", "ist", "doof"};
            Ausgabe a = Bildschirm;
            a += Datei;
            a += Datenbank;

            a(strings);

            Console.ReadKey(true);
        }

        static void Bildschirm(string[] arr)
        {
            foreach(string s in arr)
            {
                Console.WriteLine($"Gebe {s} auf Bildschirm aus...");
            }
        }

        static void Datei(string[] arr)
        {
            foreach(string s in arr)
            {
                Console.WriteLine($"Schreibe {s} in Datei...");
            }
        }

        static void Datenbank(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.WriteLine($"Schreibe {s} in DB...");
            }
        }
    }
}
