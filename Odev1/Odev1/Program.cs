using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime;
            string harf;
            string yazdir;

            Console.WriteLine("Bir kelime giriniz");

            kelime = Console.ReadLine();

            Console.WriteLine("Aranan harfi giriniz");

            harf = Console.ReadLine();

            int index1 = kelime.IndexOf(harf);
            Console.WriteLine(index1);

            int index2 = kelime.LastIndexOf(harf);
            Console.WriteLine(index2);

            if (kelime.Contains(harf))
            {
                Console.WriteLine("var");
            }
            else
            {
                Console.WriteLine("yok");
                yazdir = kelime.Substring(3);
                Console.WriteLine(yazdir);
            }

          

            


            Console.ReadLine();
        }
    }
}
