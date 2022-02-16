using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathematicsLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            // Arrange
            int n = 0;
            int expected = 1;

            // Act
            int actual = Algebra.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void FactorialTest_One_to_Seven_Input()
        {
            // Arrange
            int n = 5;
            int expected = 120;

            // Act
            int actual = Algebra.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Negative_Input()
        {
            // Arrange
            int n = -2;
            int expected = -9999;

            // Act
            int actual = Algebra.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_greater_than_seven_Input()
        {
            // Arrange
            int n = 8;
            int expected = -999;

            // Act
            int actual = Algebra.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            int a = 6, b = 8;
            int expected = 14;

            //Act
            int actual = Algebra.Add(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            int a = 6, b = 8;
            int expected = 14;

            //Act
            int actual = Algebra.Add(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

