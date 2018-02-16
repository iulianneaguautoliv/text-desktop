using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    class FereastraA : Fereastra
    {

        public FereastraA(string Titlu, int Latime, int Inaltime, int Linie, int Coloana) : base(Titlu, Latime,
            Inaltime, Linie, Coloana)
        {
            
        }

        protected override void DesenareSpecifica(Canvas can)
        {
           
            for (int linie = _StangaSusLinie+1; linie < _StangaSusLinie + _Inaltime-1; linie++)
            {
                for (int coloana = _StangaSusColoana+1; coloana < _StangaSusColoana + _Latime-1; coloana++)
                {
                    can.Set(linie, coloana, 'A');
                }
            }
        }

        

    }
}
