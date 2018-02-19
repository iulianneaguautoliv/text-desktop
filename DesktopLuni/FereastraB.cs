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

            _SavedTexts = new List<SavedText>();
        }

        protected override void DesenareSpecifica(IDeviceContext dc)
        {
            if (_SavedTexts.Count != 0)
            {
                for (int i=0;i<_SavedTexts.Count;i++)
                {

                    dc.PutString(_SavedTexts[i].text,  _SavedTexts[i].line, _SavedTexts[i].column
                        ,this,true);

                }
            }
        }

        
        private List<SavedText> _SavedTexts;

        public void AddText(string str, int linie, int coloana)
        {
            SavedText st=new SavedText();
            st.text=str; 
            st.line=linie;
            st.column=coloana;
            _SavedTexts.Add(st);

        }


        class SavedText
        {
            public string text;
            public int line;
            public int column;
        }

    }
}
