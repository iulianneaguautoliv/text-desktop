using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    class Canvas
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
    }
}
