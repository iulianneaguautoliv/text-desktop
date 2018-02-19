using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    interface IDeviceContext
    {
        void PutChar(int linie, int coloana, char c, IFereastra f,bool inside=true);
        void PutString(string text, int linie, int coloana, IFereastra f,bool inside=true);
        

    }
}
