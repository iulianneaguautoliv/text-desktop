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

        protected override void DesenareSpecifica(IDeviceContext dc)
        {
           
            for (int linie = 1; linie < _Inaltime-1; linie++)
            {
                for (int coloana = 1; coloana < _Latime-1; coloana++)
                {
                    dc.PutChar(linie, coloana, 'A',this);
                }
            }
        }

        

    }
}
