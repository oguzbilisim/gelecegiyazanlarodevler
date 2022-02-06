using System;
using System.Collections.Generic;
using System.Text;

namespace FutbollGame_OOP_Odev2.Models
{
    class Futboll
    {
        public Random randomname = new Random();
        protected string name;
        protected int number;
        protected int speed;
        protected int durability;
        protected int rust;
        protected int shot;
        protected int morale;
        protected int chance;

        public Futboll(string name, int number)
        {
            this.name = name;
            this.number = number;
            speed = randomname.Next(41, 99);
            durability = randomname.Next(50, 99);
            rust = randomname.Next(41, 99);
            shot = randomname.Next(41, 99);
            morale = randomname.Next(41, 99);
            chance = randomname.Next(41, 99);

        }

        public Futboll()
        {

        }
        public virtual Boolean Pasver()
        {
            int rustScore = Convert.ToInt32(rust*0.4+morale*0.3);

            if(rustScore>20)
            return true;

            else 
            return false;

        }

        public  virtual Boolean goalshut()
        {
            int goalshut = Convert.ToInt32(rust * 0.4 + morale * 0.3+shot*0.8);
            if(goalshut >20)

            return true;
            else
            return false;
        }
        
    }
   

    class Defense : Futboll
    {
        private int position;
        private int headshot;

        public Defense(string name, int number)
        {
            this.name = name;
            this.number = number;
            speed = randomname.Next(41, 99);
            durability = randomname.Next(50, 99);
            rust = randomname.Next(41, 99);
            shot = randomname.Next(41, 99);
            morale = randomname.Next(41, 99);
            chance = randomname.Next(41, 99);

            position = randomname.Next(41, 99);
            headshot = randomname.Next(41, 99);

    }
        public override Boolean Pasver()
        {
            int rustScore = Convert.ToInt32(rust * 0.4 + morale * 0.3);

            if (rustScore > 20)
                return true;

            else
                return false;

        }
        public override Boolean goalshut()
        {
            int goalshut = Convert.ToInt32(rust * 0.4 + morale * 0.3 + shot * 0.8);
            if (goalshut > 20)

                return true;
            else
                return false;
        }

    }

    class Midfielder : Futboll
    {
            private int longball;
            private int dribbling;
            private int specialability;

        public Midfielder(string name, int number)
        {
            this.name = name;
            this.number = number;
            speed = randomname.Next(41, 99);
            durability = randomname.Next(50, 99);
            rust = randomname.Next(41, 99);
            shot = randomname.Next(41, 99);
            morale = randomname.Next(41, 99);
            chance = randomname.Next(41, 99);

            longball = randomname.Next(41, 99);
            dribbling = randomname.Next(41, 99);
            specialability = randomname.Next(41, 99);
        }
        public override Boolean Pasver()
        {
            int rustScore = Convert.ToInt32(rust * 0.4 + morale * 0.3);

            if (rustScore > 20)
                return true;

            else
                return false;

        }

        public override Boolean goalshut()
        {
            int goalshut = Convert.ToInt32(rust * 0.4 + morale * 0.3 + shot * 0.8);
            if (goalshut > 20)

                return true;
            else
                return false;
        }
    }
    class Shooter : Futboll
    {
        private int finishing;
        private int head;
        private int cool;

        public Shooter(string name, int number)
        {
            this.name = name;
            this.number = number;
            speed = randomname.Next(41, 99);
            durability = randomname.Next(50, 99);
            rust = randomname.Next(41, 99);
            shot = randomname.Next(41, 99);
            morale = randomname.Next(41, 99);
            chance = randomname.Next(41, 99);

            finishing = randomname.Next(41, 99);
            head = randomname.Next(41, 99);
            cool = randomname.Next(41, 99);
        }
        public override Boolean Pasver()
        {
            int rustScore = Convert.ToInt32(rust * 0.4 + morale * 0.3);

            if (rustScore > 20)
                return true;

            else
                return false;

        }
        public override Boolean goalshut()
        {
            int goalshut = Convert.ToInt32(rust * 0.4 + morale * 0.3 + shot * 0.8);
            if (goalshut > 20)

                return true;
            else
                return false;
        }
    }
}
