using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleDefinition.Tests
{
    [TestClass]
    public class TreangleDefinitionTests
    {
        [TestMethod]
        public void TriangleDefinition_acute()
        {
            // arrange

            double a = 5;
            double b = 5;
            double c = 5;
            string expected = "acute";

            //act

            string actual=Triangle.TriangleDefinition(a,b,c);

            //assert

            Assert.AreEqual(expected,actual);

        }
        [TestMethod]
        public void TriangleDefinition_impossible()
        {
            // arrange

            double a = 5;
            double b = 5;
            double c = 25;
            string expected = "impossible";

            //act

            string actual = Triangle.TriangleDefinition(a, b, c);

            //assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TriangleDefinition_rectangular()
        {
            // arrange

            double a = 3;
            double b = 4;
            double c = 5;
            string expected = "rectangular";

            //act

            string actual = Triangle.TriangleDefinition(a, b, c);

            //assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TriangleDefinition_obtuse()
        {
            // arrange

            double a = 10;
            double b = 10;
            double c = 17.32;
            string expected = "obtuse";

            //act

            string actual = Triangle.TriangleDefinition(a, b, c);

            //assert

            Assert.AreEqual(expected, actual);

        }

    }
}
