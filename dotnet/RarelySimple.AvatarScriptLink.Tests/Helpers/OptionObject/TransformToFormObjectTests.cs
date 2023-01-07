using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class TransformToFormObjectTests
    {
        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FormObjectFromJson_NullString()
        {
            string json = null;
            FormObject expected = new FormObject();
            Assert.AreEqual(expected, OptionObjectHelpers.TransformToFieldObject(json));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObjectFromJson_Success()
        {
            string json = "{\"CurrentRow\":null,\"FormId\":1,\"MultipleIteration\":false,\"OtherRows\":[]}";
            FormObject expected = new FormObject
            {
                FormId = "1"
            };
            FormObject actual = (FormObject)OptionObjectHelpers.TransformToFormObject(json);
            Assert.IsNotNull(actual.FormId);
            Assert.AreEqual(expected.FormId, actual.FormId);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObjectFromJson_Failure()
        {
            string json = "{\"CurrentRow\":null,\"FormId\":2,\"MultipleIteration\":false,\"OtherRows\":[]}";
            FormObject expected = new FormObject
            {
                FormId = "1"
            };
            FormObject actual = (FormObject)OptionObjectHelpers.TransformToFormObject(json);
            Assert.IsNotNull(actual.FormId);
            Assert.AreNotEqual(expected.FormId, actual.FormId);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObjectFromXml_Success()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                       + "<FormObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                       + "  <FormId>1</FormId>" + Environment.NewLine
                       + "  <MultipleIteration>false</MultipleIteration>" + Environment.NewLine
                       + "  <OtherRows />" + Environment.NewLine
                       + "</FormObject>";
            FormObject expected = new FormObject
            {
                FormId = "1"
            };
            FormObject actual = (FormObject)OptionObjectHelpers.TransformToFormObject(xml);
            Assert.IsNotNull(actual.FormId);
            Assert.AreEqual(expected.FormId, actual.FormId);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObjectFromXml_Failure()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                       + "<FormObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                       + "  <FormId>2</FormId>" + Environment.NewLine
                       + "  <MultipleIteration>false</MultipleIteration>" + Environment.NewLine
                       + "  <OtherRows />" + Environment.NewLine
                       + "</FormObject>";
            FormObject expected = new FormObject
            {
                FormId = "1"
            };
            FormObject actual = (FormObject)OptionObjectHelpers.TransformToFormObject(xml);
            Assert.IsNotNull(actual.FormId);
            Assert.AreNotEqual(expected.FormId, actual.FormId);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
