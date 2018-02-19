using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    static class TextHelper
    {
        public static void PutText(string text, int linie, int coloana, Canvas canv)
        {
            for (int i = 0; i < text.Length; i++)
            {
                canv.Set(linie, coloana + i, text[i]);
            }
        }


    }
}
