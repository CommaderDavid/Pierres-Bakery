using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakeryTests 
{
    [TestClass]
    public class BakeryBreadTests 
    {
        // Test methods go here
        [TestMethod]
        public void BreadSetPrice_DisplaysBreadSetPrice_Int () 
        {
            // Arrange
            string bread = "bread";
            int total = 1;
            BakeryBread userBread = new BakeryBread(bread, total);
            //Act
            int result = userBread.BreadTotalPrice(bread, total);
            // Assert
            Assert.AreEqual (5, result);
        }

        [TestMethod]
        public void BreadTotalPrice_DisplaysBreadTotalOrderPrice_Int()
        {
            // Arrange
            string bread = "bread";
            int total = 4;
            BakeryBread userBread = new BakeryBread(bread, total);
            //Act
            int result = userBread.BreadTotalPrice(bread, total);
            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void BreadDeals_DisplaysBreadDeals_String()
        {
            // Arrange
            string bread = "bread deals";
            int total = 4;
            BakeryBread userBread = new BakeryBread(bread, total);
            //Act
            int result = userBread.BreadTotalPrice(bread, total);
            // Assert
            Assert.AreEqual(20, result);
        }

    }

    [TestClass]
    public class BakeryPastryTests 
    {
        // Test methods go here
        [TestMethod]
        public void PastrySetPrice_DisplaysPastrySetPrice_Int () 
        {
            //Arrange
            string pastry = "pastry";
            int total = 1;
            BakeryPastry userPastry = new BakeryPastry(pastry, total);
            // Act
            int result = userPastry.PastryTotalPrice(pastry, total);
            // Assert
            Assert.AreEqual (2, result);
        }

        [TestMethod]
        public void PastryTotalPrice_DisplaysPastryTotalOrderPrice_Int()
        {
            //Arrange
            string pastry = "pastry";
            int total = 5;
            BakeryPastry userPastry = new BakeryPastry(pastry, total);
            // Act
            int result = userPastry.PastryTotalPrice(pastry, total);
            // Assert
            Assert.AreEqual(10, result);
        }
    }
}