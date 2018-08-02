using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class Shape
    {
        public string Name { get; protected set; }
        public virtual double Area => throw new InvalidOperationException();

        public override string ToString()
        {
            return Name;
        }
    }
}