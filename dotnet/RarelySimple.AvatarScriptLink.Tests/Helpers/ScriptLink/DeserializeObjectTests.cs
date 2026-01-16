using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class DeserializeObjectTests
    {
        [TestMethod]
        public void DeserializeObject_Double_FromXml()
        {
            // Arrange
            string objectToDeserialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<double>3</double>";
            double expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<double>(objectToDeserialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_Double_FromJson()
        {
            // Arrange
            string objectToDeserialize = "3.0";
            double expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<double>(objectToDeserialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_Double_Error()
        {
            string objectToDeserialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObject<double>(objectToDeserialize));
        }

        [TestMethod]
        public void DeserializeObject_Int_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<int>3</int>";
            int expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<int>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_Int_FromJson()
        {
            // Arrange
            string objectToDeserialize = "3";
            int expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<int>(objectToDeserialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_Int_Error()
        {
            string objectToDeserialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObject<int>(objectToDeserialize));
        }

        [TestMethod]
        public void DeserializeObject_DateTime_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<dateTime>2020-01-01T00:00:00</dateTime>";
            DateTime expected = new(2020, 1, 1);

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<DateTime>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_DateTime_FromJson()
        {
            // Arrange
            string objectToSerialize = "\"2020-01-01T00:00:00\"";
            DateTime expected = new(2020, 1, 1);

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<DateTime>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_DateTime_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObject<DateTime>(objectToSerialize));
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
            OptionObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<OptionObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"SystemCode\":null}";
            OptionObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<OptionObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObject<OptionObject>(objectToSerialize));
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
            OptionObject2 expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<OptionObject2>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null}";
            OptionObject2 expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<OptionObject2>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObject<OptionObject2>(objectToSerialize));
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
            OptionObject2015 expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<OptionObject2015>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2015_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject2015 expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<OptionObject2015>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2015_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObject<OptionObject2015>(objectToSerialize));
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
            FormObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<FormObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FormObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"CurrentRow\":null,\"FormId\":null,\"MultipleIteration\":false,\"OtherRows\":[]}";
            FormObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<FormObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FormObject_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObject<FormObject>(objectToSerialize));
        }

        [TestMethod]
        public void DeserializeObject_RowObject_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<RowObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <Fields />" + Environment.NewLine +
                "</RowObject>";
            RowObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<RowObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_RowObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"Fields\":[],\"ParentRowId\":null,\"RowAction\":null,\"RowId\":null}";
            RowObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<RowObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_RowObject_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObject<RowObject>(objectToSerialize));
        }

        [TestMethod]
        public void DeserializeObject_FieldObject_FromXml()
        {
            // Arrange
            string objectToSerialize = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<FieldObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <Enabled />" + Environment.NewLine +
                "  <FieldNumber />" + Environment.NewLine +
                "  <FieldValue />" + Environment.NewLine +
                "  <Lock />" + Environment.NewLine +
                "  <Required />" + Environment.NewLine +
                "</FieldObject>";
            FieldObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<FieldObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FieldObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"Enabled\":\"\",\"FieldNumber\":\"\",\"FieldValue\":\"\",\"Lock\":\"\",\"Required\":\"\",\"Modified\":false}";
            FieldObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObject<FieldObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FieldObject_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObject<FieldObject>(objectToSerialize));
        }
    }
}
