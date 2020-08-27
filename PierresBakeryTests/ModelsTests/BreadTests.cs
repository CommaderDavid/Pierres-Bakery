using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakeryTests 
{
    [TestClass]
    public class BreadTests 
    {
        // Test methods go here
        [TestMethod]
        public void BreadTotalOrder_DisplaysBreadOrderTotal_Int()
        {
            // Arrange
            string bread = "bread";
            int total = 12;
            Bread userBread = new Bread(bread, total);
            //Act
            int result = Bread.Total;
            // Assert
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void BreadSetPrice_DisplaysBreadSetPrice_Int() 
        {
            // Arrange
            string bread = "bread";
            int total = 1;
            Bread userBread = new Bread(bread, total);
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
            Bread userBread = new Bread(bread, total);
            //Act
            int result = userBread.BreadTotalPrice(bread, total);
            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void BreadDeals_DisplaysBreadDeals_Int()
        {
            // Arrange
            string bread = "bread";
            int total = 11;
            Bread userBread = new Bread(bread, total);
            //Act
            int result = userBread.BreadTotalPrice(bread, total);
            // Assert
            Assert.AreEqual(30, result);
        }
    }
}