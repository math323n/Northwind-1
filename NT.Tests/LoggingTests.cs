using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Text;

namespace NT.Tests
{
    [TestClass]
    public class LoggingTests
    {
        [TestMethod]
        public void LoggingTest()
        {

            // Arrange
            Exception ex;
            string message;

            // Act
            ex = new Exception();
            message = "Message: " + ex.Message + Environment.NewLine + "StackTrace: " + ex.StackTrace +
                       "" + Environment.NewLine + "Date: " + DateTime.Now.ToString() + "\n-----------------------------------------------------------------------------";
            // Assert
            Assert.IsNotNull(message);
        }
    }

}