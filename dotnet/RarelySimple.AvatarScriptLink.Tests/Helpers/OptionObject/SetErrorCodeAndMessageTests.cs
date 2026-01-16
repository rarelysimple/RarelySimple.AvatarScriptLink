using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class SetErrorCodeAndMessageTests
    {
        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_Null_Error()
        {
            double errorCode = 0;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(null, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_0_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject();
            double errorCode = 0;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_1_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject();
            double errorCode = 1;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_2_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject();
            double errorCode = 2;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_3_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject();
            double errorCode = 3;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_4_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject();
            double errorCode = 4;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_5_Error()
        {
            var optionObject = new OptionObject();
            double errorCode = 5;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_5_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject();
            double errorCode = 5;
            string message = "https://scriptlink.rarelysimple.com";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_6_Error()
        {
            var optionObject = new OptionObject();
            double errorCode = 6;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_6_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject();
            double errorCode = 6;
            string message = "[PM]USER001";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_7_Error()
        {
            var optionObject = new OptionObject();
            double errorCode = 7;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject_Negative1_Error()
        {
            var optionObject = new OptionObject();
            double errorCode = -1;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_Null_Error()
        {
            double errorCode = 0;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(null, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_0_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2();
            double errorCode = 0;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_1_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2();
            double errorCode = 1;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_2_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2();
            double errorCode = 2;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_3_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2();
            double errorCode = 3;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_4_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2();
            double errorCode = 4;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_5_Error()
        {
            var optionObject = new OptionObject2();
            double errorCode = 5;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_5_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2();
            double errorCode = 5;
            string message = "https://www.rarelysimple.com";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_6_Error()
        {
            var optionObject = new OptionObject2();
            double errorCode = 6;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_6_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2();
            double errorCode = 6;
            string message = "[PM]USER001";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_7_Error()
        {
            var optionObject = new OptionObject2();
            double errorCode = 7;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2_Negative1_Error()
        {
            var optionObject = new OptionObject2();
            double errorCode = -1;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_Null_Error()
        {
            double errorCode = 0;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(null, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_0_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            double errorCode = 0;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_1_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            double errorCode = 1;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_2_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            double errorCode = 2;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_3_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            double errorCode = 3;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_4_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            double errorCode = 4;
            string message = "Test Message";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_5_Error()
        {
            var optionObject = new OptionObject2015();
            double errorCode = 5;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_5_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            double errorCode = 5;
            string message = "https://scriptlink.rarelysimple.com";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_6_Error()
        {
            var optionObject = new OptionObject2015();
            double errorCode = 6;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_6_AreEqual()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            double errorCode = 6;
            string message = "[PM]USER001";

            // Act
            OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message);

            // Assert
            Assert.AreEqual(errorCode, optionObject.ErrorCode);
            Assert.AreEqual(message, optionObject.ErrorMesg);
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_7_Error()
        {
            var optionObject = new OptionObject2015();
            double errorCode = 7;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }

        [TestMethod]
        public void SetErrorCodeAndMessage_OptionObject2015_Negative1_Error()
        {
            var optionObject = new OptionObject2015();
            double errorCode = -1;
            string message = "Test Message";
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.SetErrorCodeAndMessage(optionObject, errorCode, message));
        }
    }
}
