﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Odev3.Models
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
