using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public  double Area()
        {
            return Math.PI * radius * radius;
        }

        public  double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
    public class Square : IShape
    {
        private double length;
        public Square(double length)
        {
                this.length = length;
        }
        public double Area()
        {
            return length * length;
        }

        public double Perimeter()
        {
            return 4 * length;
          
        }
    }
    public class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public  double Area()
        {
            return length * width;
        }

        public  double Perimeter()
        {
            return 2 * (length + width);
        }
    }
}
