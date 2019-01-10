using System;
using NUnit.Framework;
using UdemyTestProject.Fundamentals;

namespace TakedaMedicalCMS.Tests
{
    #region MsTest
    //[TestClass]
    //public class ReservationTests
    //{
    //    [TestMethod]
    //    public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
    //    {
    //        // Arrange
    //        var reservation = new Reservation();

    //        // Act
    //        var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

    //        // Assert
    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
    //    {
    //        // Arrange
    //        var user = new User();
    //        var reservation = new Reservation { MadeBy = user};

    //        // Act
    //        var result = reservation.CanBeCancelledBy(user);

    //        // Assert
    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
    //    {
    //        // Arrange
    //        var reservation = new Reservation{ MadeBy = new User()};

    //        // Act
    //        var result = reservation.CanBeCancelledBy(new User());

    //        // Assert
    //        Assert.IsFalse(result);
    //    }
    //}
    #endregion

    #region NUnit
    [TestFixture]
    public class SecurityTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            // Assert.IsTrue(result);
            // Assert.That(result == true);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }
    }
    #endregion
}