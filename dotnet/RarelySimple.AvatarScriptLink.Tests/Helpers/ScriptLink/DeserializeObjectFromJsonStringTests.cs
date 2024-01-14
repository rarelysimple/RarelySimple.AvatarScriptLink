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
        [ExpectedException(typeof(ArgumentException))]
        public void DeserializeObject_Double_Error()
        {
            // Arrange
            string objectToDeserialize = "<Not XML or Json>";
            double expected = 3;

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<double>(objectToDeserialize);

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
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<int>(objectToDeserialize);

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
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<int>(objectToDeserialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_DateTime_FromJson()
        {
            // Arrange
            string objectToSerialize = "\"2020-01-01T00:00:00\"";
            DateTime expected = new DateTime(2020, 1, 1);

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<DateTime>(objectToSerialize);

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
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<DateTime>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"SystemCode\":null}";
            OptionObject expected = new OptionObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject>(objectToSerialize);

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
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null}";
            OptionObject2 expected = new OptionObject2();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2>(objectToSerialize);

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
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_OptionObject2015_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject2015 expected = new OptionObject2015();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2015>(objectToSerialize);

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
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2015>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FormObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"CurrentRow\":null,\"FormId\":null,\"MultipleIteration\":false,\"OtherRows\":[]}";
            FormObject expected = new FormObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<FormObject>(objectToSerialize);

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
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<FormObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_RowObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"Fields\":[],\"ParentRowId\":null,\"RowAction\":null,\"RowId\":null}";
            RowObject expected = new RowObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<RowObject>(objectToSerialize);

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
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<RowObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeserializeObject_FieldObject_FromJson()
        {
            // Arrange
            string objectToSerialize = "{\"Enabled\":\"\",\"FieldNumber\":\"\",\"FieldValue\":\"\",\"Lock\":\"\",\"Required\":\"\",\"Modified\":false}";
            FieldObject expected = new FieldObject();

            // Act
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<FieldObject>(objectToSerialize);

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
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<FieldObject>(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
