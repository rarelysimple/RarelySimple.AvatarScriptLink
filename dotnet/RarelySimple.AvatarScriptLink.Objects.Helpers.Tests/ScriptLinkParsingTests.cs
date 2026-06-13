namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{
    [TestClass]
    public class ScriptLinkParsingTests
    {
        #region SafeGetInt Tests

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetInt")]
        public void SafeGetInt_Zero_ReturnsZero()
        {
            // Arrange
            string intString = "0";
            int expected = 0;

            // Act
            int actual = ScriptLinkParsing.SafeGetInt(intString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetInt")]
        public void SafeGetInt_PositiveInteger_ReturnsValue()
        {
            // Arrange
            string intString = "42";
            int expected = 42;

            // Act
            int actual = ScriptLinkParsing.SafeGetInt(intString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetInt")]
        public void SafeGetInt_NegativeInteger_ReturnsValue()
        {
            // Arrange
            string intString = "-42";
            int expected = -42;

            // Act
            int actual = ScriptLinkParsing.SafeGetInt(intString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetInt")]
        public void SafeGetInt_DecimalString_ReturnsZero()
        {
            // Arrange
            string intString = "10.5";
            int expected = 0;

            // Act
            int actual = ScriptLinkParsing.SafeGetInt(intString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetInt")]
        public void SafeGetInt_AlphabeticString_ReturnsZero()
        {
            // Arrange
            string intString = "abc";
            int expected = 0;

            // Act
            int actual = ScriptLinkParsing.SafeGetInt(intString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetInt")]
        public void SafeGetInt_SpecialCharacters_ReturnsZero()
        {
            // Arrange
            string intString = "@#$";
            int expected = 0;

            // Act
            int actual = ScriptLinkParsing.SafeGetInt(intString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetInt")]
        public void SafeGetInt_NullString_ReturnsZero()
        {
            // Arrange
            string? intString = null;
            int expected = 0;

            // Act
            int actual = ScriptLinkParsing.SafeGetInt(intString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetInt")]
        public void SafeGetInt_EmptyString_ReturnsZero()
        {
            // Arrange
            string intString = "";
            int expected = 0;

            // Act
            int actual = ScriptLinkParsing.SafeGetInt(intString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetInt")]
        public void SafeGetInt_LargeNumber_ReturnsValue()
        {
            // Arrange
            string intString = "2147483647"; // Max int
            int expected = 2147483647;

            // Act
            int actual = ScriptLinkParsing.SafeGetInt(intString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region SafeGetBool Tests

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_One_ReturnsTrue()
        {
            // Arrange
            string boolString = "1";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_Zero_ReturnsFalse()
        {
            // Arrange
            string boolString = "0";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_TUppercase_ReturnsTrue()
        {
            // Arrange
            string boolString = "T";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_TrueLowercase_ReturnsTrue()
        {
            // Arrange
            string boolString = "true";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_TrueUppercase_ReturnsTrue()
        {
            // Arrange
            string boolString = "TRUE";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_YUppercase_ReturnsTrue()
        {
            // Arrange
            string boolString = "Y";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_YesLowercase_ReturnsTrue()
        {
            // Arrange
            string boolString = "yes";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_YesMixedCase_ReturnsTrue()
        {
            // Arrange
            string boolString = "Yes";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_FUppercase_ReturnsFalse()
        {
            // Arrange
            string boolString = "F";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_FalseLowercase_ReturnsFalse()
        {
            // Arrange
            string boolString = "false";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_FalseUppercase_ReturnsFalse()
        {
            // Arrange
            string boolString = "FALSE";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_NUppercase_ReturnsFalse()
        {
            // Arrange
            string boolString = "N";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_NoLowercase_ReturnsFalse()
        {
            // Arrange
            string boolString = "no";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_NoUppercase_ReturnsFalse()
        {
            // Arrange
            string boolString = "NO";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_InvalidString_ReturnsFalse()
        {
            // Arrange
            string boolString = "not a bool";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_NullString_ReturnsFalse()
        {
            // Arrange
            string? boolString = null;

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_EmptyString_ReturnsFalse()
        {
            // Arrange
            string boolString = "";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetBool")]
        public void SafeGetBool_TwoString_ReturnsFalse()
        {
            // Arrange
            string boolString = "2";

            // Act
            bool actual = ScriptLinkParsing.SafeGetBool(boolString);

            // Assert
            Assert.IsFalse(actual);
        }

        #endregion

        #region SafeGetDateTime Tests

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetDateTime")]
        public void SafeGetDateTime_ValidDateMMDDYYYYSlash_ReturnsDate()
        {
            // Arrange
            string dateTimeString = "10/10/2010";
            DateTime expected = new(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkParsing.SafeGetDateTime(dateTimeString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetDateTime")]
        public void SafeGetDateTime_ValidDateMMDDYYYYDash_ReturnsDate()
        {
            // Arrange
            string dateTimeString = "10-10-2010";
            DateTime expected = new(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkParsing.SafeGetDateTime(dateTimeString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetDateTime")]
        public void SafeGetDateTime_ValidDateMMDDYYDash_ReturnsDate()
        {
            // Arrange
            string dateTimeString = "10-10-10";
            DateTime expected = new(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkParsing.SafeGetDateTime(dateTimeString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetDateTime")]
        public void SafeGetDateTime_ValidDateTextFormat_ReturnsDate()
        {
            // Arrange
            string dateTimeString = "October 10, 2010";
            DateTime expected = new(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkParsing.SafeGetDateTime(dateTimeString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetDateTime")]
        public void SafeGetDateTime_InvalidDateString_ReturnsMinDate()
        {
            // Arrange
            string dateTimeString = "not a date";
            DateTime expected = new();

            // Act
            DateTime actual = ScriptLinkParsing.SafeGetDateTime(dateTimeString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetDateTime")]
        public void SafeGetDateTime_NullString_ReturnsMinDate()
        {
            // Arrange
            string? dateTimeString = null;
            DateTime expected = new();

            // Act
            DateTime actual = ScriptLinkParsing.SafeGetDateTime(dateTimeString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetDateTime")]
        public void SafeGetDateTime_EmptyString_ReturnsMinDate()
        {
            // Arrange
            string dateTimeString = "";
            DateTime expected = new();

            // Act
            DateTime actual = ScriptLinkParsing.SafeGetDateTime(dateTimeString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkParsing-SafeGetDateTime")]
        public void SafeGetDateTime_ValidDateWithTime_ReturnsDateTime()
        {
            // Arrange
            string dateTimeString = "10/10/2010 14:30:00";
            DateTime expected = new(2010, 10, 10, 14, 30, 0);

            // Act
            DateTime actual = ScriptLinkParsing.SafeGetDateTime(dateTimeString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}
