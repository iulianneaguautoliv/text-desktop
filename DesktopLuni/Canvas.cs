using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    class Canvas:IDeviceContext
    {
        private int _NrColoane;
        private int _NrLinii;
        private char[,] _Panza;

        public int NrColoane
        {
            get { return _NrColoane; }
            set { _NrColoane = value; }
        }

        public int NrLinii
        {
            get { return _NrLinii; }
            set { _NrLinii = value; }
        }

        public Canvas(int NrColoane, int NrLinii)
        {
            _NrColoane = NrColoane;
            _NrLinii = NrLinii;
            _Panza = new char[NrLinii, NrColoane];
        }
        public char Get(int linie, int coloana)
        {
            if (linie >= 0 && linie < _NrLinii && coloana >= 0 && coloana < _NrColoane)
            {
                return _Panza[linie, coloana];
            }
            return ' ';
        }
        public void Set(int linie, int coloana, char c)
        {

            if (linie >= 0 && linie < _NrLinii && coloana >= 0 && coloana < _NrColoane)
            {
                _Panza[linie, coloana] = c;
            }

        }

        private void SetLocal(int linie, int coloana, char c, IFereastra f)
        {
            if (linie >= 0 && linie+f.StangaSusLinie < _NrLinii && coloana >= 0 && coloana+f.StangaSusColoana < _NrColoane)
            {
                _Panza[linie + f.StangaSusLinie, coloana + f.StangaSusColoana] = c;
            }
            else
            {
                Console.WriteLine("Necesita mai multa atentie");
            }

        }

        public void PutChar(int linie, int coloana, char c, IFereastra f,bool inside=true)
        {
            if (linie < 0 || linie >= f.Inaltime||linie+f.StangaSusLinie>_NrLinii-1|| 
                coloana < 0 || coloana >= f.Latime || coloana + f.StangaSusColoana > _NrColoane - 1)
            {
                return;
            }
            if (inside == true)
            {
                SetLocal(linie + 1, coloana + 1, c, f);
            }
            else
            {
                SetLocal(linie, coloana, c, f);
            }
            
        }
        public void PutString(string text, int linie, int coloana, IFereastra f, bool inside=true)
        {
            for (int i = 0; i < text.Length; i++)
            {
                PutChar(linie, coloana + i, text[i], f,inside);
            }
        }
    }
}
