using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class GetFieldValuesTests
    {
        private OptionObject optionObject;
        private FormObject formObject;
        private FormObject formObject02;
        private RowObject rowObject;
        private RowObject rowObject02;
        private FieldObject fieldObject;
        private FieldObject fieldObject02;
        private FieldObject fieldObject03;

        [TestInitialize]
        public void TestInitialize()
        {
            this.fieldObject = new FieldObject();
            fieldObject.Enabled = "1";
            fieldObject.FieldNumber = "123.45";
            fieldObject.FieldValue = "Test Value";
            fieldObject.Lock = "0";
            fieldObject.Required = "0";

            this.fieldObject02 = new FieldObject();
            fieldObject02.Enabled = "1";
            fieldObject02.FieldNumber = "123.46";
            fieldObject02.FieldValue = "Test Value 02";
            fieldObject02.Lock = "0";
            fieldObject02.Required = "0";

            this.rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            rowObject.Fields.Add(fieldObject02);

            this.formObject = new FormObject();
            formObject.CurrentRow = rowObject;
            formObject.OtherRows.Add(rowObject);

            this.fieldObject03 = new FieldObject();
            fieldObject03.Enabled = "1";
            fieldObject03.FieldNumber = "123.47";
            fieldObject03.FieldValue = "Test Value 03";
            fieldObject03.Lock = "0";
            fieldObject03.Required = "0";

            this.rowObject02 = new RowObject();
            rowObject02.Fields.Add(fieldObject03);

            this.formObject02 = new FormObject();
            formObject02.CurrentRow = rowObject02;

            this.optionObject = new OptionObject();
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
        [ExpectedException(typeof(System.ArgumentException))]
        public void GetFieldValue_RowObject_IsNotPresent_AreNotEqual()
        {
            string actual = OptionObjectHelpers.GetFieldValue(rowObject, "234.56");
            Assert.AreNotEqual("Test Value", actual);
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
