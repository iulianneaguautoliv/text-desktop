using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesktopLuni
{
    class AddobeReader : Fereastra,IFileReader
    {

        private List<string> _DateSalvate;

        public AddobeReader(string Titlu, int Latime, int Inaltime, int Linie,
            int Coloana):base(Titlu,Latime,Inaltime,Linie,Coloana)
        {
            _DateSalvate=new List<string>();
        }
        public void ReadTextFile(string filePath)
        {
            StreamReader read=new StreamReader(filePath);
            string continut;
            while (read.Peek() >= 0)
            {
                 
                continut= read.ReadLine();
                _DateSalvate.Add(continut);
            }

            read.Close();

        }

        protected override void DesenareSpecifica(IDeviceContext dc)
        {
            int i = 0;
            foreach (var linieDeText in _DateSalvate)
            {
                dc.PutString(linieDeText,1+i, 1,this);
                i++;
            }
            

        }
    }
}
