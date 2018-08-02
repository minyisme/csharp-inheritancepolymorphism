using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class Circle : Shape
    {
        public Point Center { get; protected set; }
        public double Radius { get; protected set; }
        public override double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public Circle(Point p, double radius)
        {
            Center = p;
            Radius = radius;
            Name = "Circle";
        }

        public Circle(Point p, int radius) : this(radius)
        {
        }

        public Circle(Point p, float radius) : this(radius)
        {
        }

        public Circle(double radius)
        {
            Center = new Point(0, 0);
            Radius = radius;
            Name = "Circle";
        }

        public override bool Equals(object obj)
        {
            var input = obj as Circle;
            if (input == null)
            {
                return false;
            }
            return (Center.Equals(input.Center) && Radius == input.Radius);
        }
    }
}
