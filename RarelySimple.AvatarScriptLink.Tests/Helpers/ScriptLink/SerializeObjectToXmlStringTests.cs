using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using System;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class SerializeObjectToXmlStringTests
    {
        [TestMethod]
        public void SerializeObjectToXmlString_String_AsXml()
        {
            // Arrange
            string objectToSerialize = "Test";
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<string>Test</string>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToXmlString_Double_AsXml()
        {
            // Arrange
            double objectToSerialize = 3;
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<double>3</double>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToXmlString_Int_AsXml()
        {
            // Arrange
            int objectToSerialize = 3;
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<int>3</int>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToXmlString_DateTime_AsXml()
        {
            // Arrange
            DateTime objectToSerialize = new DateTime(2020, 1, 1);
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<dateTime>2020-01-01T00:00:00</dateTime>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToXmlString_OptionObject_AsXml()
        {
            // Arrange
            OptionObject objectToSerialize = new OptionObject();
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<OptionObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine +
                "  <ErrorCode>0</ErrorCode>" + Environment.NewLine +
                "  <Forms />" + Environment.NewLine +
                "</OptionObject>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToXmlString_OptionObject2_AsXml()
        {
            // Arrange
            OptionObject2 objectToSerialize = new OptionObject2();
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<OptionObject2 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine +
                "  <ErrorCode>0</ErrorCode>" + Environment.NewLine +
                "  <Forms />" + Environment.NewLine +
                "</OptionObject2>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToXmlString_OptionObject2015_AsXml()
        {
            // Arrange
            OptionObject2015 objectToSerialize = new OptionObject2015();
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<OptionObject2015 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine +
                "  <ErrorCode>0</ErrorCode>" + Environment.NewLine +
                "  <Forms />" + Environment.NewLine +
                "</OptionObject2015>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToXmlString_FormObject_AsXml()
        {
            // Arrange
            FormObject objectToSerialize = new FormObject();
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<FormObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <MultipleIteration>false</MultipleIteration>" + Environment.NewLine +
                "  <OtherRows />" + Environment.NewLine +
                "</FormObject>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToXmlString_RowObject_AsXml()
        {
            // Arrange
            RowObject objectToSerialize = new RowObject();
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<RowObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <Fields />" + Environment.NewLine +
                "</RowObject>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToXmlString_FieldObject_AsXml()
        {
            // Arrange
            FieldObject objectToSerialize = new FieldObject();
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<FieldObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <Enabled>0</Enabled>" + Environment.NewLine +
                "  <FieldNumber />" + Environment.NewLine +
                "  <FieldValue />" + Environment.NewLine +
                "  <Lock>0</Lock>" + Environment.NewLine +
                "  <Required>0</Required>" + Environment.NewLine +
                "</FieldObject>";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToXmlString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
