using System;

namespace SRP_Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20,5,7);
            rectangle.ciz();

            AlanHesapla alanhesapla = new AlanHesapla();
            float rectanglee = alanhesapla.Rectangle(rectangle);
            Console.WriteLine(rectanglee);
        }
    }
}
