using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using System;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class SerializeObjectToJsonStringTests
    {
        [TestMethod]
        public void SerializeObjectToJsonString_String_AsXml()
        {
            // Arrange
            string objectToSerialize = "Test";
            string expected = "\"Test\"";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToJsonString_Double_AsXml()
        {
            // Arrange
            double objectToSerialize = 3;
            string expected = "3.0";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToJsonString_Int_AsXml()
        {
            // Arrange
            int objectToSerialize = 3;
            string expected = "3";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToJsonString_DateTime_AsXml()
        {
            // Arrange
            DateTime objectToSerialize = new DateTime(2020, 1, 1);
            string expected = "\"2020-01-01T00:00:00\"";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToJsonString_OptionObject_AsXml()
        {
            // Arrange
            OptionObject objectToSerialize = new OptionObject();
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"SystemCode\":null}";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToJsonString_OptionObject2_AsXml()
        {
            // Arrange
            OptionObject2 objectToSerialize = new OptionObject2();
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null}";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToJsonString_OptionObject2015_AsXml()
        {
            // Arrange
            OptionObject2015 objectToSerialize = new OptionObject2015();
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToJsonString_FormObject_AsXml()
        {
            // Arrange
            FormObject objectToSerialize = new FormObject();
            string expected = "{\"CurrentRow\":null,\"FormId\":null,\"MultipleIteration\":false,\"OtherRows\":[]}";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToJsonString_RowObject_AsXml()
        {
            // Arrange
            RowObject objectToSerialize = new RowObject();
            string expected = "{\"Fields\":[],\"ParentRowId\":null,\"RowAction\":null,\"RowId\":null}";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObjectToJsonString_FieldObject_AsXml()
        {
            // Arrange
            FieldObject objectToSerialize = new FieldObject();
            string expected = "{\"Enabled\":\"0\",\"FieldNumber\":\"\",\"FieldValue\":\"\",\"Lock\":\"0\",\"Required\":\"0\",\"Modified\":false}";

            // Act
            var actual = ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
