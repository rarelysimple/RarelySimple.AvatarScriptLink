using RarelySimple.AvatarScriptLink.Helpers;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class GetLocalizedStringTests
    {
        private const string ParameterCannotBeNull = "parameterCannotBeNull";
        
        [TestMethod]
        public void GetLocalizedString_ValidKey_ReturnsString()
        {
            // Arrange
            string key = ParameterCannotBeNull;

            // Act
            var actual = ScriptLinkHelpers.GetLocalizedString(key);

            // Assert
            Assert.AreEqual(typeof(string), actual.GetType());
        }

        [TestMethod]
        public void GetLocalizedString_InvalidKey_ReturnsNull()
        {
            // Arrange
            string key = "invalidKey";

            // Act
            var actual = ScriptLinkHelpers.GetLocalizedString(key);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetLocalizedString_EmptyCulture_ReturnsString()
        {
            // Arrange
            string key = ParameterCannotBeNull;
            string culture = "";

            // Act
            var actual = ScriptLinkHelpers.GetLocalizedString(key, culture);

            // Assert
            Assert.AreEqual(typeof(string), actual.GetType());
        }

        [TestMethod]
        public void GetLocalizedString_AvailableCulture_ReturnsString()
        {
            // Arrange
            string key = ParameterCannotBeNull;
            string culture = "en-US";

            // Act
            var actual = ScriptLinkHelpers.GetLocalizedString(key, culture);

            // Assert
            Assert.AreEqual(typeof(string), actual.GetType());
        }

        [TestMethod]
        public void GetLocalizedString_UnavailableCulture_ReturnsString()
        {
            // Arrange
            string key = ParameterCannotBeNull;
            string culture = "sl";

            // Act
            var actual = ScriptLinkHelpers.GetLocalizedString(key, culture);

            // Assert
            Assert.AreEqual(typeof(string), actual.GetType());
        }

        [TestMethod]
        public void GetLocalizedString_AvailableCultureInfo_ReturnsString()
        {
            // Arrange
            string key = ParameterCannotBeNull;
            CultureInfo culture = CultureInfo.GetCultureInfo("en-US");

            // Act
            var actual = ScriptLinkHelpers.GetLocalizedString(key, culture);

            // Assert
            Assert.AreEqual(typeof(string), actual.GetType());
        }

        [TestMethod]
        public void GetLocalizedString_UnavailableCultureInfo_ReturnsString()
        {
            // Arrange
            string key = ParameterCannotBeNull;
            CultureInfo culture = CultureInfo.GetCultureInfo("sl");

            // Act
            var actual = ScriptLinkHelpers.GetLocalizedString(key, culture);

            // Assert
            Assert.AreEqual(typeof(string), actual.GetType());
        }
    }
}
