using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class DeserializeObjectFromJsonStringTests
    {
        [TestMethod]
        public void DeserializeObject_Double_FromJson()
        {
            // Arrange
            string objectToDeserialize = "3.0";
            double expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<double>(objectToDeserialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_Double_Error()
        {
            string objectToDeserialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObjectFromJsonString<double>(objectToDeserialize));
        }

        [TestMethod]
        public void DeserializeObject_Int_FromJson()
        {
            // Arrange
            string objectToDeserialize = "3";
            int expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<int>(objectToDeserialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_Int_Error()
        {
            string objectToDeserialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObjectFromJsonString<int>(objectToDeserialize));
        }

        [TestMethod]
        public void DeserializeObject_DateTime_FromJson()
        {
            // Arrange
            string objectToSerialize = "\"2020-01-01T00:00:00\"";
            DateTime expected = new(2020, 1, 1);

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<DateTime>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_DateTime_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObjectFromJsonString<DateTime>(objectToSerialize));
        }

        [TestMethod]
        public void DeserializeObject_OptionObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"SystemCode\":null}";
            OptionObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject>(objectToSerialize));
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null}";
            OptionObject2 expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2>(objectToSerialize));
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2015_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject2015 expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2015>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2015_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2015>(objectToSerialize));
        }

        [TestMethod]
        public void DeserializeObject_FormObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"CurrentRow\":null,\"FormId\":null,\"MultipleIteration\":false,\"OtherRows\":[]}";
            FormObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<FormObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FormObject_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObjectFromJsonString<FormObject>(objectToSerialize));
        }

        [TestMethod]
        public void DeserializeObject_RowObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"Fields\":[],\"ParentRowId\":null,\"RowAction\":null,\"RowId\":null}";
            RowObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<RowObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_RowObject_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObjectFromJsonString<RowObject>(objectToSerialize));
        }

        [TestMethod]
        public void DeserializeObject_FieldObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"Enabled\":\"\",\"FieldNumber\":\"\",\"FieldValue\":\"\",\"Lock\":\"\",\"Required\":\"\",\"Modified\":false}";
            FieldObject expected = new();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<FieldObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FieldObject_Error()
        {
            string objectToSerialize = "<Not XML or Json>";
            Assert.ThrowsException<ArgumentException>(() => ScriptLinkHelpers.DeserializeObjectFromJsonString<FieldObject>(objectToSerialize));
        }
    }
}
