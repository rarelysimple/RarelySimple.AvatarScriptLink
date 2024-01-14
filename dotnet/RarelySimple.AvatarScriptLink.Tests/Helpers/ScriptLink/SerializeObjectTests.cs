using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class SerializeObjectTests
    {
        [TestMethod]
        public void SerializeObject_String_AsJson()
        {
            string expected = "Test";
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<string>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_Double_AsJson()
        {
            double expected = 3;
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<double>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_Int_AsJson()
        {
            int expected = 3;
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<int>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_DateTime_AsJson()
        {
            DateTime expected = new DateTime(2020, 1, 1);
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<DateTime>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_OptionObject_AsJson()
        {
            OptionObject expected = new OptionObject();
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_OptionObject2_AsJson()
        {
            OptionObject2 expected = new OptionObject2();
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_OptionObject2015_AsJson()
        {
            OptionObject2015 expected = new OptionObject2015();
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<OptionObject2015>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_FormObject_AsJson()
        {
            FormObject expected = new FormObject();
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<FormObject>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_RowObject_AsJson()
        {
            RowObject expected = new RowObject();
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<RowObject>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_FieldObject_AsJson()
        {
            FieldObject expected = new FieldObject();
            var serialized = ScriptLinkHelpers.SerializeObjectToJsonString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromJsonString<FieldObject>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_String_AsXml()
        {
            string expected = "Test";
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<string>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_Double_AsXml()
        {
            double expected = 3;
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<double>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_Int_AsXml()
        {
            int expected = 3;
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<int>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_DateTime_AsXml()
        {
            DateTime expected = new DateTime(2020, 1, 1);
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<DateTime>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_OptionObject_AsXml()
        {
            OptionObject expected = new OptionObject();
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<OptionObject>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_OptionObject2_AsXml()
        {
            OptionObject2 expected = new OptionObject2();
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<OptionObject2>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_OptionObject2015_AsXml()
        {
            OptionObject2015 expected = new OptionObject2015();
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<OptionObject2015>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_FormObject_AsXml()
        {
            FormObject expected = new FormObject();
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<FormObject>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_RowObject_AsXml()
        {
            RowObject expected = new RowObject();
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<RowObject>(serialized);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_FieldObject_AsXml()
        {
            FieldObject expected = new FieldObject();
            var serialized = ScriptLinkHelpers.SerializeObjectToXmlString(expected);
            var actual = ScriptLinkHelpers.DeserializeObjectFromXmlString<FieldObject>(serialized);
            Assert.AreEqual(expected, actual);
        }
    }
}
