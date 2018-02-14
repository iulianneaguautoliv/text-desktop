using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesktopLuni
{
    class Program
    {
        static void Main(string[] args)
        {
            Desktop d = new Desktop();
            IFereastra f1 = new FereastraA("Fereastra A", 20, 10, 5, 7);
            IFereastra f2 = new FereastraB("Fereastra B", 15, 8, 10, 15);
            //f1.Minimize();
            //f2.Minimize();

            //f1.Move(-4,10);
             

            d.Adauga(f1);
            d.Adauga(f2);
            d.Afisare();
            Console.ReadKey();
            d.AduInFata(f1);
            d.Afisare();

        }
    }
}
