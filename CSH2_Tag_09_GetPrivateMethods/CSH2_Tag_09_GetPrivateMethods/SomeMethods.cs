using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_09_GetPrivateMethods
{
    delegate void GetMethod(string s);
    class SomeMethods
    {
        private void privateMethode(string s)
        {
            Console.WriteLine(s);
        }
        public GetMethod MeinePrivateMethode
        {
            get
            {
                return new GetMethod(privateMethode);
            }
        }

    }
}
