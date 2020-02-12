using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using System;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class DeserializeObjectFromXmlStringTests
    {
        [TestMethod]
        public void DeserializeObject_Double_FromXml()
        {
            // Arrange
            string objectToDeserialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<double>3</double>";
            double expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<double>(objectToDeserialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_Double_Error()
        {
            // Arrange
            string objectToDeserialize = "<Not XML or Json>";
            double expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<double>(objectToDeserialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_Int_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<int>3</int>";
            int expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<int>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_Int_Error()
        {
            // Arrange
            string objectToDeserialize = "<Not XML or Json>";
            int expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<int>(objectToDeserialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_DateTime_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<dateTime>2020-01-01T00:00:00</dateTime>";
            DateTime expected = new DateTime(2020, 1, 1);

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<DateTime>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_DateTime_Error()
        {
            // Arrange
            string objectToSerialize = "<Not XML or Json>";
            DateTime expected = new DateTime(2020, 1, 1);

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<DateTime>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<OptionObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine +
                "  <ErrorCode>0</ErrorCode>" + Environment.NewLine +
                "  <Forms />" + Environment.NewLine +
                "</OptionObject>";
            OptionObject expected = new OptionObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<OptionObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_OptionObject_Error()
        {
            // Arrange
            string objectToSerialize = "<Not XML or Json>";
            OptionObject expected = new OptionObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<OptionObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<OptionObject2 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine +
                "  <ErrorCode>0</ErrorCode>" + Environment.NewLine +
                "  <Forms />" + Environment.NewLine +
                "</OptionObject2>";
            OptionObject2 expected = new OptionObject2();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<OptionObject2>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_OptionObject2_Error()
        {
            // Arrange
            string objectToSerialize = "<Not XML or Json>";
            OptionObject2 expected = new OptionObject2();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<OptionObject2>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2015_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<OptionObject2015 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine +
                "  <ErrorCode>0</ErrorCode>" + Environment.NewLine +
                "  <Forms />" + Environment.NewLine +
                "</OptionObject2015>";
            OptionObject2015 expected = new OptionObject2015();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<OptionObject2015>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_OptionObject2015_Error()
        {
            // Arrange
            string objectToSerialize = "<Not XML or Json>";
            OptionObject2015 expected = new OptionObject2015();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<OptionObject2015>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FormObject_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<FormObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <MultipleIteration>false</MultipleIteration>" + Environment.NewLine +
                "  <OtherRows />" + Environment.NewLine +
                "</FormObject>";
            FormObject expected = new FormObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<FormObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_FormObject_Error()
        {
            // Arrange
            string objectToSerialize = "<Not XML or Json>";
            FormObject expected = new FormObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<FormObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_RowObject_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<RowObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <Fields />" + Environment.NewLine +
                "</RowObject>";
            RowObject expected = new RowObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<RowObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_RowObject_Error()
        {
            // Arrange
            string objectToSerialize = "<Not XML or Json>";
            RowObject expected = new RowObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<RowObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FieldObject_FromXml()
        {
            // Arrange
            /*string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<FieldObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <Enabled>0</Enabled>" + Environment.NewLine +
                "  <FieldNumber />" + Environment.NewLine +
                "  <FieldValue />" + Environment.NewLine +
                "  <Lock>0</Lock>" + Environment.NewLine +
                "  <Required>0</Required>" + Environment.NewLine +
                "</FieldObject>";*/
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<FieldObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <Enabled></Enabled>" + Environment.NewLine +
                "  <FieldNumber />" + Environment.NewLine +
                "  <FieldValue />" + Environment.NewLine +
                "  <Lock></Lock>" + Environment.NewLine +
                "  <Required></Required>" + Environment.NewLine +
                "</FieldObject>";
            FieldObject expected = new FieldObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<FieldObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_FieldObject_Error()
        {
            // Arrange
            string objectToSerialize = "<Not XML or Json>";
            FieldObject expected = new FieldObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<FieldObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
