using System;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{
    [TestClass]
    public class ScriptLinkValidationTests
    {
        #region IsValidUrl(string) Tests

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_ValidHttpUrl_ReturnsTrue()
        {
            // Arrange
            string url = "http://example.com";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_ValidHttpsUrl_ReturnsTrue()
        {
            // Arrange
            string url = "https://example.com";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_ValidHttpUrlWithPath_ReturnsTrue()
        {
            // Arrange
            string url = "http://example.com/path";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_ValidHttpUrlWithQueryString_ReturnsTrue()
        {
            // Arrange
            string url = "http://example.com/?e=123";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_ValidHttpsUrlWithQueryString_ReturnsTrue()
        {
            // Arrange
            string url = "https://example.com/?e=123";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_RelativeUrl_ReturnsFalse()
        {
            // Arrange
            string url = "example.com";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_RelativeUrlWithSpaces_ReturnsFalse()
        {
            // Arrange
            string url = "example domain.com";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_NullString_ReturnsFalse()
        {
            // Arrange
            string? url = null;

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_EmptyString_ReturnsFalse()
        {
            // Arrange
            string url = "";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_WhitespaceString_ReturnsFalse()
        {
            // Arrange
            string url = "   ";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_ValidFileScheme_ReturnsTrue()
        {
            // Arrange
            string url = "file:///C:/path/to/file.txt";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_ValidUrlWithFragment_ReturnsTrue()
        {
            // Arrange
            string url = "https://example.com/page#section";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_ValidUrlWithPort_ReturnsTrue()
        {
            // Arrange
            string url = "https://example.com:8443/path";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl")]
        public void IsValidUrl_ValidFtpUrl_ReturnsTrue()
        {
            // Arrange
            string url = "ftp://files.example.com/report.csv";

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(url);

            // Assert
            Assert.IsTrue(result);
        }

        #endregion

        #region IsValidUrl(Uri) Tests

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl-Uri")]
        public void IsValidUrl_ValidUri_ReturnsTrue()
        {
            // Arrange
            var uri = new Uri("http://example.com");

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(uri);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl-Uri")]
        public void IsValidUrl_AbsoluteUri_ReturnsTrue()
        {
            // Arrange
            var uri = new Uri("https://example.com/path?query=value");

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(uri);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl-Uri")]
        public void IsValidUrl_RelativeUri_ReturnsFalse()
        {
            // Arrange
            var uri = new Uri("/path/to/resource", UriKind.Relative);

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(uri);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidUrl-Uri")]
        public void IsValidUrl_NullUri_ReturnsFalse()
        {
            // Arrange
            Uri? uri = null;

            // Act
            bool result = ScriptLinkValidation.IsValidUrl(uri);

            // Assert
            Assert.IsFalse(result);
        }

        #endregion

        #region IsValidOpenFormString Tests

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_SimpleForm_ReturnsTrue()
        {
            // Arrange
            string openForm = "PR0001";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_FormWithModule_ReturnsTrue()
        {
            // Arrange
            string openForm = "[PM]PR0001";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_RadplusForm_ReturnsTrue()
        {
            // Arrange
            string openForm = "RADplus_Imaging001";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_CWSModule_ReturnsTrue()
        {
            // Arrange
            string openForm = "[CWS]RADplus_Imaging001";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_MSOModule_ReturnsTrue()
        {
            // Arrange
            string openForm = "[MSO]PR0001";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_FormWithMessage_ReturnsTrue()
        {
            // Arrange
            string openForm = "PR0001|Error occurred";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_FormWithMessageAndPatientId_ReturnsTrue()
        {
            // Arrange
            string openForm = "PR0001|Error occurred|12345";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_FormWithAllComponents_ReturnsTrue()
        {
            // Arrange
            string openForm = "[PM]PR0001|Error occurred|12345|1";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_MultipleForms_ReturnsTrue()
        {
            // Arrange
            string openForm = "PR0001&PR0002";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_InvalidFormName_ReturnsFalse()
        {
            // Arrange
            string openForm = "0001";  // Missing letter prefix

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_InvalidModule_ReturnsFalse()
        {
            // Arrange
            string openForm = "[XX]PR0001";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_NullString_ReturnsFalse()
        {
            // Arrange
            string? openForm = null;

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_EmptyString_ReturnsFalse()
        {
            // Arrange
            string openForm = "";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_WhitespaceString_ReturnsFalse()
        {
            // Arrange
            string openForm = "   ";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_LowercaseFormName_ReturnsFalse()
        {
            // Arrange
            string openForm = "pr0001";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_NumbersOnlyFormName_ReturnsFalse()
        {
            // Arrange
            string openForm = "0001";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_MultipleFormsWithSpacesAroundAmpersand_ReturnsTrue()
        {
            // Arrange
            string openForm = "PR0001 & PR0002";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("ScriptLinkValidation-IsValidOpenFormString")]
        public void IsValidOpenFormString_TabInMessage_ReturnsFalse()
        {
            // Arrange
            string openForm = "PR0001|Error\there";

            // Act
            bool result = ScriptLinkValidation.IsValidOpenFormString(openForm);

            // Assert
            Assert.IsFalse(result);
        }

        #endregion
    }
}
