using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularPolygon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPolygon.Tests
{
    [TestClass()]
    public class RegularPolygonTests
    {

        [TestMethod()]
        public void triangleAreaFormulaTestPass()
        {
            //Arrange
            Triangle triangle = new Triangle(2);

            //Act
            double result = Math.Round(triangle.calculateArea(), 2);

            //Assert
            Assert.AreEqual(1.73, result);
        }

        [TestMethod()]
        public void triangleAreaFormulaTestFail()
        {
            //Arrange
            Triangle triangle = new Triangle(2);

            //Act
            double result = Math.Round(triangle.calculateArea(), 2);

            //Assert
            Assert.AreNotEqual(20, result);
        }

        [TestMethod()]
        public void squareAreaFormulaTestPass()
        {
            //Arrange
            Square square = new Square(4);

            //Act
            double result = Math.Round(square.calculateArea(), 2);

            //Assert
            Assert.AreEqual(16, result);
        }


        [TestMethod()]
        public void squareAreaFormulaTestFail()
        {
            //Arrange
            Square square = new Square(4);

            //Act
            double result = Math.Round(square.calculateArea(), 2);

            //Assert
            Assert.AreNotEqual(8, result);
        }


        [TestMethod()]
        public void pentagonAreaFormulaTestPass()
        {
            //Arrange
            Pentagon pentagon = new Pentagon(10);

            //Act
            double result = Math.Round(pentagon.calculateArea(), 2);

            //Assert
            Assert.AreEqual(172.05, result);
        }


        [TestMethod()]
        public void spentagonAreaFormulaTestFail()
        {
            //Arrange
            Pentagon pentagon = new Pentagon(10);

            //Act
            double result = Math.Round(pentagon.calculateArea(), 2);

            //Assert
            Assert.AreNotEqual(100, result);
        }


    }
}