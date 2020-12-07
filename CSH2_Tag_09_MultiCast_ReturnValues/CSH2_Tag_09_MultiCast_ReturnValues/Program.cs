using System;
using System.Collections.Generic;

namespace CSH2_Tag_09_MultiCast_ReturnValues
{
    delegate int meinDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            meinDelegate d = Summe;
            d += Produkt;
            d += Summe;
            d += Produkt;

            List<int> returnWerte = new List<int>();

            int i = 5, j = 8;
            foreach(meinDelegate md in d.GetInvocationList())
            {
                returnWerte.Add(md.Invoke(i, j));
                i++;
                j++;
            }

            foreach(int k in returnWerte)
            {
                Console.WriteLine(k);
            }

            Console.ReadKey(true);
        }

        static int Summe(int a, int b)
        {
            return (a + b);
        }

        static int Produkt(int a, int b)
        {
            return (a * b);
        }

    }
}
