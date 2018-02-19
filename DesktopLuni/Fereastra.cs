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

        protected abstract void DesenareSpecifica(IDeviceContext dc);
       
        public void Desenare(IDeviceContext dc)
        {
            if (_vizibilitate == false)
            {
                return;
            }



            //interiorul ferestrei

            for (int linie = 0; linie < _Inaltime; linie++)
            {
                for (int coloana = 0; coloana < _Latime; coloana++)
                {
                    dc.PutChar(linie, coloana, ' ', this,false);
                }
            }
            //marginea de sus si cea de jos a ferestrei

            for (int coloana = 0; coloana <  _Latime; coloana++)
            {
                dc.PutChar(0, coloana, '*',this,false);
                dc.PutChar(_Inaltime - 1, coloana, '*',this,false);
            }
            //margini verticale stanga-dreapta

            for (int linie = 0; linie <  _Inaltime; linie++)
            {
                dc.PutChar(linie,0 , '*',this,false);
                dc.PutChar(linie,  _Latime - 1, '*',this,false);
            }
            dc.PutString(_Titlu,0,2,this,false);
            
            DesenareSpecifica(dc);

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

        public int StangaSusLinie => _StangaSusLinie;
        public int StangaSusColoana => _StangaSusColoana;
        public int Inaltime => _Inaltime;
        public int Latime => _Latime;



    }
}
