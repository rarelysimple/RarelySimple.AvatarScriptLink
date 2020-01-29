using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers.ScriptLink
{
    [TestClass]
    public class SafeGetBoolTests
    {
        [TestMethod]
        public void SafeGetBool_Zero_IsFalse()
        {
            // Arrange
            string boolString = "0";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_One_IsTrue()
        {
            // Arrange
            string boolString = "1";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SafeGetBool_Two_IsFalse()
        {
            // Arrange
            string boolString = "2";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_N_IsFalse()
        {
            // Arrange
            string boolString = "N";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_No_IsFalse()
        {
            // Arrange
            string boolString = "No";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_NO_IsFalse()
        {
            // Arrange
            string boolString = "NO";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_no_IsFalse()
        {
            // Arrange
            string boolString = "no";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_Y_IsTrue()
        {
            // Arrange
            string boolString = "Y";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SafeGetBool_Yes_IsTrue()
        {
            // Arrange
            string boolString = "Yes";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SafeGetBool_YES_IsTrue()
        {
            // Arrange
            string boolString = "YES";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SafeGetBool_yes_IsTrue()
        {
            // Arrange
            string boolString = "yes";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SafeGetBool_F_IsFalse()
        {
            // Arrange
            string boolString = "F";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_False_IsFalse()
        {
            // Arrange
            string boolString = "False";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_FALSE_IsFalse()
        {
            // Arrange
            string boolString = "FALSE";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_false_IsFalse()
        {
            // Arrange
            string boolString = "false";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SafeGetBool_T_IsTrue()
        {
            // Arrange
            string boolString = "T";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SafeGetBool_True_IsTrue()
        {
            // Arrange
            string boolString = "True";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SafeGetBool_TRUE_IsTrue()
        {
            // Arrange
            string boolString = "TRUE";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SafeGetBool_true_IsTrue()
        {
            // Arrange
            string boolString = "true";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SafeGetBool_NotABool_IsFalse()
        {
            // Arrange
            string boolString = "Not a bool.";

            // Act
            bool actual = ScriptLinkHelpers.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
