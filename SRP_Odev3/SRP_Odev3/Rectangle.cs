using System;
using System.Collections.Generic;
using System.Text;

namespace SRP_Odev3
{
    public class Rectangle
    {
        private float en;
        private float boy;
        private int x;
        private int y;

        public Rectangle(float en, float boy,int x, int y)
        {
            this.en = en;
            this.boy = boy;
            this.x = x;
            this.y = y;
        }

        public float getEn()
        {
            return en;
        }

        public float getBoy()
        {
            return boy;
        }

        public void ciz()
        {
            Console.WriteLine("dikdörtgen çizildi");
        }

     /*   
        
        public float alanHesapla()
        {
            return en * boy;
        }

        */

    }

}
