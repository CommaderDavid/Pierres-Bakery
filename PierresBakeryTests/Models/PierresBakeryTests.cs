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
            BakeryBread userBread = new BakeryBread(bread);
            //Act
            int result = userBread.BreadTotalPrice(bread);
            // Assert
            Assert.AreEqual (5, result);
        }

        [TestMethod]
        public void BreadTotalPrice_DisplaysBreadTotalOrderPrice_Int()
        {
            // Arrange
            string bread = "bread";
            BakeryBread userBread = new BakeryBread(bread);
            //Act
            int result = userBread.BreadTotalPrice(bread);
            // Assert
            Assert.AreEqual(5, result);
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
            BakeryPastry userPastry = new BakeryPastry(pastry);
            // Act
            int result = userPastry.PastryTotalPrice(pastry);
            // Assert
            Assert.AreEqual (2, result);
        }
    }
}