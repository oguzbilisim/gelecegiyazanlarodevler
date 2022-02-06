using FutbollGame_OOP_Odev2.Models;
using System;
using System.Collections.Generic;

namespace FutbollGame_OOP_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Futboll> team = new List<Futboll>();
            team.Add(new Futboll("kaleci",1));
            team.Add(new Defense("defans",2));
            team.Add(new Defense("defans",3));
            team.Add(new Defense("defans",4));
            team.Add(new Midfielder("orta saha",5));
            team.Add(new Midfielder("orta saha",6));
            team.Add(new Midfielder("orta saha",7));
            team.Add(new Midfielder("orta saha",8));
            team.Add(new Shooter("forvet",9));
            team.Add(new Shooter("forvet",10));
            team.Add(new Shooter("forvet",11));

            Random random = new Random();
            int number;
            int pascontrol=12;
            Boolean gol = true;
            number = random.Next(1, 12);
            for (int i = 1; i <= 3; i++)
            {
                while(pascontrol == number)
                {
                    number = random.Next(1, 12);
                }
                pascontrol = number;
               
                if(!team[number - 1].Pasver())
                {
                    Console.WriteLine("pas başarısız");
                    gol = false;
                    break;
                }
                else
                {
                    Console.WriteLine("pas tam isabet");
                }
            }
            Console.WriteLine(number+" numaralı oyuncu kacırdı");

            if(gol = true)
            {
                Console.WriteLine(number +" numaralı oyuncu golll attıı!!");
            }
            else
            {
                Console.WriteLine("az farkla kaçtı");
            }
            Console.ReadLine();
        }
    }
}
