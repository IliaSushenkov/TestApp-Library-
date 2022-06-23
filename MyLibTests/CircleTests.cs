using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleTest()
        {
            FindSquare.SquareCircle(5);

            var expectedSquare = Math.PI * 25;

            Assert.AreEqual(expectedSquare, FindSquare.s);

        }

        [TestMethod]
        public void TriangleTest()
        {
            FindSquare.Triangle(3, 4, 5);

            var expectedSquare = Math.Sqrt(136);
            var rightTriange = Math.Sqrt(36);

            Assert.AreNotEqual(expectedSquare, $"Треугольник не прямоугольный {FindSquare.s}");
            Assert.AreEqual(rightTriange, FindSquare.s);
        }
    }
}