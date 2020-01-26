using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBasics2
{
    class Program
    {
        /// <summary>
        /// Gönderilen metinde boşlukların sayısını döndüren metod
        /// </summary>
        /// <param name="metin">Boşlukları sayılacak metin</param>
        /// <returns>int değer</returns>
        static int BoslukSay(string metin)
        {
            int metinBoyut = metin.Length;
            int boslukSayisi = 0;
            for (int i = 0; i < metinBoyut; i++)
            {
                if (metin[i] == ' ')
                {
                    boslukSayisi++;
                }

            }
            return boslukSayisi;
        }
        delegate int BoslukSayHandler(string metin);

        static void Main(string[] args)
        {

            // BoslukSayHandler bsh = BoslukSay;

            //BoslukSayHandler bsh = new BoslukSayHandler(BoslukSay);
            Func<string, int> bsh = BoslukSay;
            int boslukSayisi = bsh.Invoke("It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)");
            Console.WriteLine("Metindeki boşluk sayısı : {0}", boslukSayisi);
            Console.ReadKey();
        }
    }
}
