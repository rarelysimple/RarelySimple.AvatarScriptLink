using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetFieldValueTests
    {
        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_FieldObject_AreEqual()
        {
            var expected = new FieldObject();
            var actual = new FieldObject();

            expected.FieldValue = "Test";
            actual = (FieldObject)OptionObjectHelpers.SetFieldValue(actual, "Test");

            Assert.AreEqual(expected.FieldValue, actual.FieldValue);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldValue_FieldObject_Null()
        {
            var expected = new FieldObject();
            FieldObject actual = null;

            expected.FieldValue = "Test";
            actual = (FieldObject)OptionObjectHelpers.SetFieldValue(actual, "Test");

            Assert.AreEqual(expected.FieldValue, actual.FieldValue);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_RowObject_AreEqual()
        {
            string expected = "Test";

            var fieldObject = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);

            rowObject = (RowObject)OptionObjectHelpers.SetFieldValue(rowObject, "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(rowObject, "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldValue_RowObject_Null()
        {
            string expected = "Test";

            var fieldObject = new FieldObject
            {
                FieldNumber = "123"
            };
            RowObject rowObject = null;

            rowObject = (RowObject)OptionObjectHelpers.SetFieldValue(rowObject, "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(rowObject, "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_FormObject_CurrentRow_NotMI_AreEqual()
        {
            string expected = "Test";

            var fieldObject = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject = new RowObject
            {
                RowId = "1||1"
            };
            rowObject.Fields.Add(fieldObject);
            var formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            formObject = (FormObject)OptionObjectHelpers.SetFieldValue(formObject, "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(formObject, "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_FormObject_CurrentRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject03.Fields.Add(fieldObject03);
            var formObject = new FormObject
            {
                CurrentRow = rowObject01,
                MultipleIteration = true
            };
            formObject.OtherRows.Add(rowObject02);
            formObject.OtherRows.Add(rowObject03);

            formObject = (FormObject)OptionObjectHelpers.SetFieldValue(formObject, "2||2", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(formObject, "2||2", "123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void SetFieldValue_FormObject_CurrentRow_MI_Error()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject03.Fields.Add(fieldObject03);
            var formObject = new FormObject
            {
                CurrentRow = rowObject01,
                MultipleIteration = true
            };
            formObject.OtherRows.Add(rowObject02);
            formObject.OtherRows.Add(rowObject03);

            formObject = (FormObject)OptionObjectHelpers.SetFieldValue(formObject, "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(formObject, "123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_FormObject_OtherRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject03.Fields.Add(fieldObject03);
            var formObject = new FormObject
            {
                CurrentRow = rowObject01
            };
            formObject.OtherRows.Add(rowObject02);
            formObject.OtherRows.Add(rowObject03);
            formObject.MultipleIteration = true;

            formObject = (FormObject)OptionObjectHelpers.SetFieldValue(formObject, "2||2", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(formObject, "2||2", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldValue_FormObject_Null()
        {
            string expected = "Test";

            var fieldObject = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject = new RowObject
            {
                RowId = "1||1"
            };
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = null;

            formObject = (FormObject)OptionObjectHelpers.SetFieldValue(formObject, "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(formObject, "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject)OptionObjectHelpers.SetFieldValue(optionObject, "122", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "122");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject_OtherRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject)OptionObjectHelpers.SetFieldValue(optionObject, "2", "2||3", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "2", "2||3", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject_CurrentRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject)OptionObjectHelpers.SetFieldValue(optionObject, "2", "2||1", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "2", "2||1", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject_CurrentRow_NotMI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject)OptionObjectHelpers.SetFieldValue(optionObject, "1", "1||1", "122", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "122");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldValue_OptionObject_Null()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject("122");
            var fieldObject02 = new FieldObject("123");
            var fieldObject03 = new FieldObject("123");
            var fieldObject04 = new FieldObject("123");
            var rowObject01 = new RowObject("1||1");
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject("2||1");
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject("2||2");
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject("2||3");
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            OptionObject optionObject = null;

            optionObject = (OptionObject)OptionObjectHelpers.SetFieldValue(optionObject, "2", "2||3", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "2", "2||3", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject2_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject2)OptionObjectHelpers.SetFieldValue(optionObject, "122", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "122");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject2_OtherRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject2)OptionObjectHelpers.SetFieldValue(optionObject, "2", "2||3", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "2", "2||3", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject2_CurrentRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject2)OptionObjectHelpers.SetFieldValue(optionObject, "2", "2||1", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "2", "2||1", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject2_CurrentRow_NotMI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject2)OptionObjectHelpers.SetFieldValue(optionObject, "1", "1||1", "122", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "122");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldValue_OptionObject2_Null()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject("122");
            var fieldObject02 = new FieldObject("123");
            var fieldObject03 = new FieldObject("123");
            var fieldObject04 = new FieldObject("123");
            var rowObject01 = new RowObject("1||1");
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject("2||1");
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject("2||2");
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject("2||3");
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            OptionObject2 optionObject = null;

            optionObject = (OptionObject2)OptionObjectHelpers.SetFieldValue(optionObject, "2", "2||3", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "2", "2||3", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject2015_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2015();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject2015)OptionObjectHelpers.SetFieldValue(optionObject, "122", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "122");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject2015_OtherRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2015();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject2015)OptionObjectHelpers.SetFieldValue(optionObject, "2", "2||3", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "2", "2||3", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject2015_CurrentRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2015();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject2015)OptionObjectHelpers.SetFieldValue(optionObject, "2", "2||1", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "2", "2||1", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SetFieldValue_OptionObject2015_CurrentRow_NotMI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject
            {
                FieldNumber = "122"
            };
            var fieldObject02 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject03 = new FieldObject
            {
                FieldNumber = "123"
            };
            var fieldObject04 = new FieldObject
            {
                FieldNumber = "123"
            };
            var rowObject01 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject
            {
                RowId = "2||1"
            };
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject
            {
                RowId = "2||2"
            };
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject
            {
                RowId = "2||3"
            };
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2015();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = (OptionObject2015)OptionObjectHelpers.SetFieldValue(optionObject, "1", "1||1", "122", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "122");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldValue_OptionObject2015_Null()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject("122");
            var fieldObject02 = new FieldObject("123");
            var fieldObject03 = new FieldObject("123");
            var fieldObject04 = new FieldObject("123");
            var rowObject01 = new RowObject("1||1");
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject("2||1");
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject("2||2");
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject("2||3");
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject01
            };
            var formObject02 = new FormObject
            {
                FormId = "2",
                CurrentRow = rowObject02
            };
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            OptionObject2015 optionObject = null;

            optionObject = (OptionObject2015)OptionObjectHelpers.SetFieldValue(optionObject, "2", "2||3", "123", "Test");
            string actual = OptionObjectHelpers.GetFieldValue(optionObject, "2", "2||3", "123");

            Assert.AreEqual(expected, actual);
        }
    }
}
