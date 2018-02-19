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
            IFereastra f1 = new FereastraA("Fereastra1", 20, 10, 5, 15);
            IFereastra f2 = new FereastraB("Fereastra2", 15, 8, 10, 15);
            IFereastra f3 = new FereastraA("MicrosoftWord3", 25, 15, 1, 27);
            IFereastra f4 = new FereastraB("VisualStudio4", 10, 7, 15, 15);
            IFereastra f5 = new AddobeReader("Cititor",10,10,15,35);
            f1.Minimize();
            // f2.Minimize();

            //f1.Move(-4,10);


            d.Adauga(f1);
            d.Adauga(f2);
            d.Adauga(f3);
            d.Adauga(f4);
            d.Adauga(f5);
            
            if (f2 is ITextEditor)
            {
                (f2 as ITextEditor).AddText("CSharp Rules Break Rules", 0, 0);
                (f2 as ITextEditor).AddText("Afara este frumos", 4, 5);
            }
            if (f5 is IFileReader)
            {
                (f5 as IFileReader).ReadTextFile("C://temp/text.txt");
            }

            d.Afisare();
            Console.ReadKey();
            d.SetZorder(1, f1);
            //d.AduInFata(f1);
            d.Afisare();
            Console.ReadKey();


        }
    }
}
