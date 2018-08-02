using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritancePolymorphismPractice.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestCircleConstructor()
        {
            var point = new Point(1.5, 1.5);
            var circle = new Circle(point, 1.5);

            Assert.AreEqual(circle.Area, (Math.PI*1.5*1.5));
            Assert.AreEqual(circle.Name, "Circle");
            Assert.IsNotNull(circle);
        }

        [TestMethod]
        public void TestCircleEqualsOverride()
        {
            var point = new Point(1.5, 1.5);
            var point2 = new Point(1.5, 1.5);
            var circle = new Circle(point, 1.5);
            var circle2 = new Circle(point2, 1.5);

            Assert.AreEqual(circle.Equals(circle2), true);
        }

        [TestMethod]
        public void TestCircleConstructorInt()
        {
            var point = new Point(1.5, 1.5);
            var circle = new Circle(point, 1);

            Assert.AreEqual(circle.Radius.GetType(), typeof(double));
        }

        [TestMethod]
        public void TestCircleConstructorFloat()
        {
            var point = new Point(1.5, 1.5);
            var circle = new Circle(point, 1.0f);

            Assert.AreEqual(circle.Radius.GetType(), typeof(double));
        }
    }

    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestRectangleConstructor()
        {
            var topLeft = new Point(1.5, 1.5);
            var rectangle = new Rectangle(topLeft, 1.5, 1.5);

            Assert.IsNotNull(rectangle);
            Assert.AreEqual(rectangle.Name, "rectangle");
            Assert.AreEqual(rectangle.Area, 1.5 * 1.5);
        }

        [TestMethod]
        public void TestRectangleEqualsOverride()
        {
            var point = new Point(1.5, 1.5);
            var point2 = new Point(1.5, 1.5);
            var rectangle = new Rectangle(point, 1.5, 1.5);
            var rectangle2 = new Rectangle(point2, 1.5, 1.5);

            Assert.AreEqual(rectangle.Equals(rectangle2), true);
        }
    }

    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void TestEqualsOverride()
        {
            var point = new Point(1.5, 1.5);
            var point2 = new Point(1.5, 1.5);

            Assert.AreEqual(point.Equals(point2), true);
        }
    }

    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void TestShapeToStringOverride()
        {
            var shape = new Shape();
            Assert.AreEqual(null, shape.ToString());
            
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestShapeSetError()
        {
            var shape = new Shape();
            Console.WriteLine(shape.Area);
        }
    }

    //[TestClass]
    //public class SquareTests
    //{
    //    [TestMethod]
    //    public void TestSquareConstructor()
    //    {
    //        var point = new Point(1.5, 1.5);
    //        var square = new Square
    //    }
    //}

    [TestClass]
    public class StaticTests
    {
        [TestMethod]
        public void TestStaticCircle()
        {
            var point = new Point(1.5, 1.5);
            var circle = new Circle(point, 1.5);

            Assert.AreEqual(Program.GetShapeArea(circle), circle.Area);
        }

        [TestMethod]
        public void TestStaticRectangle()
        {
            var point = new Point(1.5, 1.5);
            var rectangle = new Rectangle(point, 1.5, 1.5);

            Assert.AreEqual(Program.GetShapeArea(rectangle), rectangle.Area);
        }

        //[TestMethod]
        //public void TestStaticSquare()
        //{
        //    var point = new Point(1.5, 1.5);
        //    var rectangle = new Rectangle(point, 1.5, 1.5);

        //    Assert.AreEqual(Program.GetShapeArea(circle), circle.Area);
        //}
    }
}
