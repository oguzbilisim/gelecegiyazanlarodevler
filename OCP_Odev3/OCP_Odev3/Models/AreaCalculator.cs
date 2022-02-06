using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Odev3.Models
{
    public class AreaCalculator
    {
        public double Area(Shape [] shapes) { 
        double area = 0;
        foreach(var s in shapes)
            {
                area += s.Area();
            }
            return area;
           
        }
    }
}
