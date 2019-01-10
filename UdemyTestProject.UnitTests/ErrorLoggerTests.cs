﻿using System;
using System.Runtime.Remoting.Channels;
using NUnit.Framework;
using UdemyTestProject.Fundamentals;

namespace TakedaMedicalCMS.Tests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("z");
            Assert.That(logger.LastError, Is.EqualTo("z"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
            // Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args;};
            logger.Log("a");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}