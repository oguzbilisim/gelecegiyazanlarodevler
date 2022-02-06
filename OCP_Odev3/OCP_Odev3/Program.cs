using OCP_Odev3.Models;
using System;

namespace OCP_Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(12,20);
            Console.WriteLine(rc.Area());

            Circle c = new Circle(4.38);
            Console.WriteLine(c.Area());

            Console.Read();
        }
    }
}
