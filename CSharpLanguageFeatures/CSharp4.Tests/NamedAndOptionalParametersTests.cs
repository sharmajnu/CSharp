using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp4.Tests
{
    [TestClass]
    public class NamedAndOptionalParametersTests
    {
        [TestMethod]
        public void OptionalParametersMethodShouldReturnDefaultMessageWhenNoParametersArePassed()
        {
            var message = NamedAndOptionalParameters.OptionalParametersMethod();
            Assert.AreEqual("Hello, World", message, "Message is not expected");

        }

        [TestMethod]
        public void OptionalParametersMethodShouldReturnHelloNameWhenOnlyNameIsPassed()
        {
            var message = NamedAndOptionalParameters.OptionalParametersMethod("Deepak");
            Assert.AreEqual("Hello, Deepak", message, "Message is not expected");

        }

        [TestMethod]
        public void OptionalParametersMethodShouldReturnMessageAndNameWhenBothArePassed()
        {
            var message = NamedAndOptionalParameters.OptionalParametersMethod("Someone", "Message: ");
            Assert.AreEqual("Message: Someone", message, "Message is not expected");

        }


        [TestMethod]
        public void OptionalParametersMethodShouldReturnMessageWhenNamedParametersArePassed()
        {
            var message = NamedAndOptionalParameters.OptionalParametersMethod(message: "Someone", name: "Message: ");
            Assert.AreEqual("SomeoneMessage: ", message, "Message is not expected");

        }
    }
}
