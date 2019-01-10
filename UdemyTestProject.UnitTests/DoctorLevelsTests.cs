using System.Linq;
using NUnit.Framework;
using UdemyTestProject.Fundamentals;

namespace TakedaMedicalCMS.Tests
{
    [TestFixture]
    public class DoctorLevelsTests
    {
        // SetUp
        // TearDown
        private Math _math;

        [SetUp]
        public void SetUp() => _math = new Math();

        [Test]
        //[Ignore("I don't want any doctor pass the trust level :)")]
        public void CheckTrustLevelOfDoctor()
        {
            var result = _math.Add(5, 6);
            Assert.That(result, Is.EqualTo(11));
        }

        [Test]
        [TestCase(5, 4, 5)]
        [TestCase(9, 12, 12)]
        [TestCase(7, 7, 7)]
        public void Max_WhenCalled_ReturnGreaterArgument(int x, int y, int expectedResult)
        {
            var result = _math.Max(x, y);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Max_SecondNumberIsGreater_ReturnSecondNumber()
        {
            var result = _math.Max(5, 16);
            Assert.That(result, Is.EqualTo(16));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(9);

            // Assert.That(result, Is.Not.Empty);
            // Assert.That(result, Is.Ordered);
            // Assert.That(result, Is.Unique);
            // Assert.That(result.Count(), Is.EqualTo(5));
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5, 7, 9 }));
        }
    }
}