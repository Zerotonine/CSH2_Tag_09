using System;

namespace CSH2_Tag_09_GetPrivateMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMethod gm = null;
            SomeMethods sm = new SomeMethods();

            gm = sm.MeinePrivateMethode;

            gm("hallo ich bin eine private Methode");

            Console.ReadKey(true);
        }
    }
}
