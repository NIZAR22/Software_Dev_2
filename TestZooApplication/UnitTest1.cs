using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooApplication;

namespace TestZooApplication
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CalculateAdultPriceTest_IsANumber()
        {
            // Arrange
            var adultCost = new adultCost();
            // Act
            int result = adultCost.getInteger;
            //Setup
            Mock<UnitTests.IMath> mockMath = new Mock<UnitTests.IMath>();
            mockMath
                .Setup(r => r.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int x, int y) => x + y);
            UnitTest.AdultCost adultCost2 = new UnitTest.Cost(mockMath.Object);

            //Assert
            Assert.AreEqual(result, 1);
        }
    }
}

namespace ZooApplication
{
    public class Mock<T>
    {
        public Mock()
        {
        }
    }
}