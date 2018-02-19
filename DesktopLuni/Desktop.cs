using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    class Desktop
    {
        private Canvas _c;
        private List<IFereastra>_ferestre;
        

        public void Adauga(IFereastra f)
        {
            _ferestre.Add(f);
        }

       public Desktop()
       {
            _c = new Canvas(80, 30);
            _ferestre = new List<IFereastra>();
            for (int coloana = 0; coloana < _c.NrColoane; coloana++)
            {
                for (int linie = 0; linie < _c.NrLinii; linie++)
                {
                    _c.Set(linie, coloana, '.');
                }
            }
        }

        public void Afisare()
        {
            int poz = 0;

            foreach (var f in _ferestre)
            {

                if(f.Minimizat==false)
                    f.Desenare(_c);
                else
                {
                    TextHelper.PutText(f.Titlu,_c.NrLinii-1,poz,_c);
                    poz += f.Titlu.Length+2;

                }
            }
            for (int linie = 0; linie < _c.NrLinii; linie++)
                
            {
                for (int coloana = 0; coloana < _c.NrColoane; coloana++)
                {
                    Console.Write(_c.Get(linie, coloana));

                }
                Console.WriteLine();
            }

           
        }

        //public void AduInFata(IFereastra f)
        //{
        //    _ferestre.Remove(f);
        //    _ferestre.Add(f);
        //}

        public void SetZorder(int zindex, IFereastra f)
        {
            if (zindex  >=_ferestre.Count||zindex<0)
            {
                return;
            }
            _ferestre.Remove(f);
            _ferestre.Insert(_ferestre.Count-zindex,f);

        }

    }
}
