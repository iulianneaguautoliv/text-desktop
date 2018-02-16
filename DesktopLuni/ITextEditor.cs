using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    interface ITextEditor
    {
        /// <summary>
        /// Adding some text in window
        /// </summary>
        /// <param name="str"></param>
        /// <param name="linie">raportat la zona interioara a ferestrei</param>
        /// <param name="coloana">raportat la zona interioara a ferestrei</param>
        void AddText(string str, int linie, int coloana);
    }
}
