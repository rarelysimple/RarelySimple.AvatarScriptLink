using RarelySimple.AvatarScriptLink.Helpers;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers.ScriptLink
{
    [TestClass]
    public class SafeGetDateTimeTests
    {
        [TestMethod]
        public void SafeGetDateTime_MMDDYYYYDash_ReturnsDate()
        {
            // Arrange
            string dateString = "10-10-2010";
            DateTime expected = new DateTime(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkHelpers.SafeGetDateTime(dateString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SafeGetDateTime_MMDDYYYYForwardSlash_ReturnsDate()
        {
            // Arrange
            string dateString = "10/10/2010";
            DateTime expected = new DateTime(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkHelpers.SafeGetDateTime(dateString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SafeGetDateTime_MMDDYYForwardSlash_ReturnsDate()
        {
            // Arrange
            string dateString = "10-10-10";
            DateTime expected = new DateTime(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkHelpers.SafeGetDateTime(dateString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SafeGetDateTime_MMDDYYDash_ReturnsDate()
        {
            // Arrange
            string dateString = "10-10-10";
            DateTime expected = new DateTime(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkHelpers.SafeGetDateTime(dateString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SafeGetDateTime_USText_ReturnsDate()
        {
            // Arrange
            string dateString = "October 10, 2010";
            DateTime expected = new DateTime(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkHelpers.SafeGetDateTime(dateString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SafeGetDateTime_WorldText_ReturnsDateTime()
        {
            // Arrange
            string dateString = "10 October, 2010";
            DateTime expected = new DateTime(2010, 10, 10);

            // Act
            DateTime actual = ScriptLinkHelpers.SafeGetDateTime(dateString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SafeGetDateTime_BadDate_ReturnsNewDateTime()
        {
            // Arrange
            string dateString = "Not a date.";
            DateTime expected = new DateTime();

            // Act
            DateTime actual = ScriptLinkHelpers.SafeGetDateTime(dateString);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
