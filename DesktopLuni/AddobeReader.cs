using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    class AddobeReader : Fereastra,IFileReader
    {
        protected AddobeReader(string Titlu, int Latime, int Inaltime, int Linie,
            int Coloana):base(Titlu,Latime,Inaltime,Linie,Coloana)
        {

        }
        public void ReadTextFile(string filePath)
        {
            throw new NotImplementedException();
        }

        protected override void DesenareSpecifica(Canvas canvas)
        {
            throw new NotImplementedException();
        }
    }
}
