using System;
using System.Linq;
using System.Text;

namespace CSH2_Tag_09_Aufgabe_02
{
    class Program
    {
        delegate bool MeinDelegat(string a, string b);
        static void Main(string[] args)
        {
            string[] arr = { "Beere", "Autobahnpolizist", "Tee"};
            Ausgabe(arr);
            Console.WriteLine();

            MeinDelegat d = A_IstLängerAls_B;
            Sortiere(ref arr, d);
            Ausgabe(arr);
            Console.WriteLine();

            d = A_hatMehr_E_Als_B;
            Sortiere(ref arr, d);
            Ausgabe(arr);

            Console.ReadKey(true);
        }

        static bool A_IstLängerAls_B(string a, string b)
        {
            if (a.Length > b.Length)
                return true;
            return false;
        }

        static bool A_hatMehr_E_Als_B(string a, string b)
        {
            int eCountInA = a.Count(c => string.Equals(c.ToString(), "e", StringComparison.InvariantCultureIgnoreCase));
            int eCountInB = b.Count(c => string.Equals(c.ToString(), "e", StringComparison.InvariantCultureIgnoreCase));

            if (eCountInA > eCountInB)
                return true;
            return false;
        }

        static void Sortiere(ref string[] arr, MeinDelegat d)
        {
            string temp;
            for(int i = 0; i <= arr.Length - 2; i++)
            {
                for(int j = 0; j <= arr.Length - 2; j++)
                {
                    if(d(arr[j], arr[j+1]))
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Ausgabe(string[] arr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---Ausgabe Array---");
            int i = 1;
            foreach(string s in arr)
            {
                sb.AppendLine($"String Nr.{i}\t{s}");
                i++;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
