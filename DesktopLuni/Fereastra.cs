using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    abstract class Fereastra : IFereastra
    {
        private string _Titlu;
        protected int _Latime;
        protected int _Inaltime;
        protected int _StangaSusLinie;
        protected int _StangaSusColoana;

        protected Fereastra(string Titlu, int Latime, int Inaltime, int Linie,
            int Coloana)
        {
            _Titlu = Titlu;
            _Latime = Latime;
            _Inaltime = Inaltime;
            _StangaSusLinie = Linie;
            _StangaSusColoana = Coloana;

        }

        protected Fereastra()
        {
            _Titlu = "Fara nume";
            _Latime = 10;
            _Inaltime = 5;
            _StangaSusLinie = 0;
            _StangaSusColoana = 0;
        }

        protected abstract void DesenareSpecifica(Canvas canvas);
       
        public void Desenare(Canvas canvas)
        {
            if (_vizibilitate == false)
            {
                return;
            }




            for (int linie = _StangaSusLinie; linie < _StangaSusLinie + _Inaltime; linie++)
            {
                for (int coloana = _StangaSusColoana; coloana < _StangaSusColoana + _Latime; coloana++)
                {
                    canvas.Set(linie, coloana, ' ');
                }
            }
            for (int coloana = _StangaSusColoana; coloana < _StangaSusColoana + _Latime; coloana++)
            {
                canvas.Set(_StangaSusLinie, coloana, '*');
                canvas.Set(_StangaSusLinie + _Inaltime - 1, coloana, '*');
            }
            for (int linie = _StangaSusLinie; linie < _StangaSusLinie + _Inaltime; linie++)
            {
                canvas.Set(linie, _StangaSusColoana, '*');
                canvas.Set(linie, _StangaSusColoana + _Latime - 1, '*');
            }
            for (int i = 0; i < _Titlu.Length; i++)
            {
                canvas.Set(_StangaSusLinie, _StangaSusColoana + 2 + i, _Titlu[i]);
            }
            DesenareSpecifica(canvas);

        }
    

    protected bool _vizibilitate=true;
        public void Ascunde()
        {
            _vizibilitate = false;

        }

        protected bool _minimizat = false;

        public bool Minimizat
        {
            get { return _minimizat; }
        }
        public void Minimize()
        {
            _minimizat = true;
        }

        public string Titlu
        {
            get { return _Titlu; }
        }

        public void Move(int deltaLinii, int deltaColoane)
        {
            _StangaSusLinie += deltaLinii;
            _StangaSusColoana += deltaColoane;

        }

    }
}
