using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class Point
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override bool Equals(object obj)
        {
            var input = obj as Point;
            if (input == null)
            {
                return false;
            }
            return (this.X == input.X && this.Y == input.Y);
        }
    }
}


