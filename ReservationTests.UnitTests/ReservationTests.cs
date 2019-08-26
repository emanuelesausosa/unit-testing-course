using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace ReservationTests.UnitTests
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void CanBeCancelledBy_isAdmin_ReturnTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            // Assert
            Assert.IsTrue(result);

        }
    }
}
