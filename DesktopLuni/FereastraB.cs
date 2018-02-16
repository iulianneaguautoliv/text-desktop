using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    class FereastraB:Fereastra,ITextEditor
    {
        public FereastraB(string Titlu, int Latime, int Inaltime, int Linie, int Coloana) : base(Titlu, Latime,
            Inaltime, Linie, Coloana)
        {
            _SavedTexts  =new List<string>();
            _SavedLines = new List<int>();
            _SavedColumns=new List<int>();
        }

        protected override void DesenareSpecifica(Canvas can)
        {
            if (_SavedTexts.Count != 0)
            {
                for (int i=0;i<_SavedTexts.Count;i++)
                {

                    TextHelper.PutText(_SavedTexts[i], _StangaSusLinie + _SavedLines[i], _StangaSusColoana + _SavedColumns[i],
                        can);

                }
            }
        }

        private List<string> _SavedTexts;
        private List<int> _SavedLines;
        private List<int> _SavedColumns;

        public void AddText(string str, int linie, int coloana)
        {
            _SavedTexts.Add(str); 
            _SavedLines.Add(linie);
            _SavedColumns.Add(coloana);

        }




    }
}
