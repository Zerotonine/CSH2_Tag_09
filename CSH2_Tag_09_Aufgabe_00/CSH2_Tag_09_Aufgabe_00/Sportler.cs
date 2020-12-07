using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_09_Aufgabe_00
{
    delegate void Aktion();
    class Sportler
    {
        public void FühreAktionAus(Aktion a)
        {
            a?.Invoke();
        }
    }
}
