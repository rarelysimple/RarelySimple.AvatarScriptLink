using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class TransformToXmlTests
    {
        [TestMethod]
        public void OptionObjectTransformToXmlIsString()
        {
            OptionObject optionObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(optionObject);
            var actual = optionObject.ToXml();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void OptionObjectHelperTransformToXmlIsString()
        {
            OptionObject optionObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(optionObject);
            var actual = OptionObjectHelpers.TransformToXml(optionObject);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void OptionObject2TransformToXmlIsString()
        {
            OptionObject2 optionObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(optionObject);
            var actual = optionObject.ToXml();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void OptionObject2HelperTransformToXmlIsString()
        {
            OptionObject2 optionObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(optionObject);
            var actual = OptionObjectHelpers.TransformToXml(optionObject);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void OptionObject2015TransformToXmlIsString()
        {
            OptionObject2015 optionObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(optionObject);
            var actual = optionObject.ToXml();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void OptionObject2015HelperTransformToXmlIsString()
        {
            OptionObject2015 optionObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(optionObject);
            var actual = OptionObjectHelpers.TransformToXml(optionObject);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void FormObjectTransformToXmlIsString()
        {
            FormObject formObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(formObject);
            var actual = formObject.ToXml();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void FormObjectHelperTransformToXmlIsString()
        {
            FormObject formObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(formObject);
            var actual = OptionObjectHelpers.TransformToXml(formObject);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void RowObjectTransformToXmlIsString()
        {
            RowObject rowObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(rowObject);
            var actual = rowObject.ToXml();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void RowObjectHelperTransformToXmlIsString()
        {
            RowObject rowObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(rowObject);
            var actual = OptionObjectHelpers.TransformToXml(rowObject);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void FieldObjectTransformToXmlIsString()
        {
            FieldObject fieldObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(fieldObject);
            var actual = fieldObject.ToXml();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void FieldObjectHelperTransformToXmlIsString()
        {
            FieldObject fieldObject = new();
            var expected = ScriptLinkHelpers.SerializeObjectToXmlString(fieldObject);
            var actual = OptionObjectHelpers.TransformToXml(fieldObject);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
