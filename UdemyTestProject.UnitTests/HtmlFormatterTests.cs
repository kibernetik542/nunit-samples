using NUnit.Framework;
using UdemyTestProject.Fundamentals;

namespace TakedaMedicalCMS.Tests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatterAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("xyz");

            // Specific
           // Assert.That(result, Is.EqualTo("<strong>xyz</strong>"));

            // More general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.Contain("xyz"));
            Assert.That(result, Does.EndWith("</strong>"));
        }
    }
}