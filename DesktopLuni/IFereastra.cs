using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    interface IFereastra
    {
        void Desenare(Canvas canvas);
        void Ascunde();
        void Minimize();
        bool Minimizat
        { 
            get ;
        }

        string Titlu { get; }
        void Move(int deltaLinii, int deltaColoane);

    }
}
