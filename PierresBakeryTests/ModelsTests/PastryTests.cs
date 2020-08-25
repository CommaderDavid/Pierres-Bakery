using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakeryTests
{
    [TestClass]
    public class PastryTests
    {
        // Test methods go here
        [TestMethod]
        public void PastrySetPrice_DisplaysPastrySetPrice_Int()
        {
            //Arrange
            string pastry = "pastry";
            int total = 1;
            Pastry userPastry = new Pastry(pastry, total);
            // Act
            int result = userPastry.PastryTotalPrice(pastry, total);
            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void PastryTotalPrice_DisplaysPastryTotalOrderPrice_Int()
        {
            //Arrange
            string pastry = "pastry";
            int total = 5;
            Pastry userPastry = new Pastry(pastry, total);
            // Act
            int result = userPastry.PastryTotalPrice(pastry, total);
            // Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void PastryDealPrice_DisplaysPastryDealPrice_Int()
        {
            //Arrange
            string pastry = "pastry";
            int total = 9;
            Pastry userPastry = new Pastry(pastry, total);
            // Act
            int result = userPastry.PastryTotalPrice(pastry, total);
            // Assert
            Assert.AreEqual(15, result);
        }
    }
}