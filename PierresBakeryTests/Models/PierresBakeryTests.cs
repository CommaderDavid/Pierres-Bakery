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
    }

    [TestClass]
    public class BakeryPastryTests 
    {
        // Test methods go here
        [TestMethod]
        public void PastrySetPrice_DisplaysPastrySetPrice_Int () 
        {
            // any necessary logic to prep for test; instantiating new classes, etc.
            // Assert.AreEqual (EXPECTED RESULT, CODE TO TEST);
        }
    }
}