using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class Rectangle : Shape
    {
        public Point TopLeft { get; protected set; }
        public double Width { get; protected set; }
        public double Height { get; protected set; }
        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }

        public Rectangle(Point topLeft, double width, double height)
        {
            TopLeft = topLeft;
            Width = width;
            Height = height;
            Name = "rectangle";
        }

        public override bool Equals(object obj)
        {
            var input = obj as Rectangle;
            if (input == null)
            {
                return false;
            }
            return (TopLeft.Equals(input.TopLeft) && Width == input.Width && Height == input.Height);
        }
    }
}
