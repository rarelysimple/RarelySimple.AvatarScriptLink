using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class GetFieldValuesTests
    {
        private OptionObject optionObject = new();
        private FormObject formObject = new();
        private FormObject formObject02 = new();
        private RowObject rowObject = new();
        private RowObject rowObject02 = new();
        private FieldObject fieldObject = new();
        private FieldObject fieldObject02 = new();
        private FieldObject fieldObject03 = new();

        [TestInitialize]
        public void TestInitialize()
        {
            fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123.45",
                FieldValue = "Test Value",
                Lock = "0",
                Required = "0"
            };

            fieldObject02 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123.46",
                FieldValue = "Test Value 02",
                Lock = "0",
                Required = "0"
            };

            rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            rowObject.Fields.Add(fieldObject02);

            formObject = new FormObject
            {
                CurrentRow = rowObject
            };
            formObject.OtherRows.Add(rowObject);

            fieldObject03 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123.47",
                FieldValue = "Test Value 03",
                Lock = "0",
                Required = "0"
            };

            rowObject02 = new RowObject();
            rowObject02.Fields.Add(fieldObject03);

            formObject02 = new FormObject
            {
                CurrentRow = rowObject02
            };

            optionObject = new OptionObject();
            optionObject.Forms.Add(formObject);
            optionObject.Forms.Add(formObject02);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_FieldObject_IsPresent_AreEqual()
        {
            string actual = OptionObjectHelpers.GetFieldValue(fieldObject);
            Assert.AreEqual("Test Value", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_RowObject_IsPresent_AreEqual()
        {
            string actual = OptionObjectHelpers.GetFieldValue(rowObject, "123.45");
            Assert.AreEqual("Test Value", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_RowObject_SecondField_IsPresent_AreEqual()
        {
            string actual = OptionObjectHelpers.GetFieldValue(rowObject, "123.46");
            Assert.AreEqual("Test Value 02", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_RowObject_SecondForm_IsPresent_AreEqual()
        {
            string actual = OptionObjectHelpers.GetFieldValue(rowObject02, "123.47");
            Assert.AreEqual("Test Value 03", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_RowObject_IsNotPresent_AreNotEqual()
        {
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetFieldValue(rowObject, "234.56"));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_OptionObject_FieldNumber_IsEmpty()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetFieldValues(optionObject, ""));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_FormObject_FieldNumber_IsEmpty()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetFieldValues(formObject, ""));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_FormObject_CurrentRow_IsPresent_AreEqual()
        {
            List<string> values = OptionObjectHelpers.GetFieldValues(formObject, "123.45");
            string actual = values.Count > 0 ? values[0] : "Got empty response from helper.";
            Assert.AreEqual("Test Value", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_FormObject_CurrentRow_SecondField_IsPresent_AreEqual()
        {
            List<string> values = OptionObjectHelpers.GetFieldValues(formObject, "123.46");
            string actual = values.Count > 0 ? values[0] : "Got empty response from helper.";
            Assert.AreEqual("Test Value 02", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_FormObject_CurrentRow_SecondForm_IsPresent_AreEqual()
        {
            List<string> values = OptionObjectHelpers.GetFieldValues(formObject02, "123.47");
            string actual = values.Count > 0 ? values[0] : "Got empty response from helper.";
            Assert.AreEqual("Test Value 03", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_FormObject_CurrentRow_IsNotPresent_AreNotEqual()
        {
            List<string> values = OptionObjectHelpers.GetFieldValues(formObject, "234.56");
            string actual = values.Count > 0 ? values[0] : "Got empty response from helper.";
            Assert.AreNotEqual("Test Value", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_OptionObject_CurrentRow_IsPresent_AreEqual()
        {
            List<string> values = OptionObjectHelpers.GetFieldValues(optionObject, "123.45");
            string actual = values.Count > 0 ? values[0] : "Got empty response from helper.";
            Assert.AreEqual("Test Value", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_OptionObject_CurrentRow_SecondField_IsPresent_AreEqual()
        {
            List<string> values = OptionObjectHelpers.GetFieldValues(optionObject, "123.46");
            string actual = values.Count > 0 ? values[0] : "Got empty response from helper.";
            Assert.AreEqual("Test Value 02", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_OptionObject_CurrentRow_SecondForm_IsPresent_AreEqual()
        {
            List<string> values = OptionObjectHelpers.GetFieldValues(optionObject, "123.47");
            string actual = values.Count > 0 ? values[0] : "Got empty response from helper.";
            Assert.AreEqual("Test Value 03", actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetFieldValue_OptionObject_CurrentRow_IsNotPresent_AreNotEqual()
        {
            List<string> values = OptionObjectHelpers.GetFieldValues(optionObject, "234.56");
            string actual = values.Count > 0 ? values[0] : "Got empty response from helper.";
            Assert.AreNotEqual("Test Value", actual);
        }
    }
}
