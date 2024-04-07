using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class GetFieldValueTests
    {
        [TestMethod]
        public void GetFieldValueOptionObjectReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), optionObject.GetFieldValue("123").GetType());
            Assert.AreEqual(expected2.GetType(), optionObject.GetFieldValue("123").GetType());
            Assert.AreEqual(expected1.GetType(), optionObject.GetFieldValue("1", "1||1", "123").GetType());
            Assert.AreEqual(expected2.GetType(), optionObject.GetFieldValue("1", "1||2", "123").GetType());
        }

        [TestMethod]
        public void GetFieldValueOptionObjectReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, optionObject.GetFieldValue("123"));
            Assert.AreNotEqual(expected2, optionObject.GetFieldValue("123"));
            Assert.AreEqual(expected1, optionObject.GetFieldValue("1", "1||1", "123"));
            Assert.AreEqual(expected2, optionObject.GetFieldValue("1", "1||2", "123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueOptionObjectMissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, optionObject.GetFieldValue("124"));
            Assert.AreNotEqual(expected2, optionObject.GetFieldValue("124"));
            Assert.AreEqual(expected1, optionObject.GetFieldValue("1", "1||1", "124"));
            Assert.AreEqual(expected2, optionObject.GetFieldValue("1", "1||2", "124"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetFieldValueOptionObjectNullReturnsError()
        {
            OptionObject optionObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, optionObject.GetFieldValue("124"));
            Assert.AreNotEqual(expected2, optionObject.GetFieldValue("124"));
            Assert.AreEqual(expected1, optionObject.GetFieldValue("1", "1||1", "124"));
            Assert.AreEqual(expected2, optionObject.GetFieldValue("1", "1||2", "124"));
        }

        [TestMethod]
        public void GetFieldValueHelperOptionObjectReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "123").GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "123").GetType());
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "123").GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "123").GetType());
        }

        [TestMethod]
        public void GetFieldValueHelperOptionObjectReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "123"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "123"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "123"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueHelperOptionObjectMissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "124"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFieldValueHelperOptionObjectNullReturnsError()
        {
            OptionObject optionObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "124"));
        }

        [TestMethod]
        public void GetFieldValueOptionObject2ReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), optionObject.GetFieldValue("123").GetType());
            Assert.AreEqual(expected2.GetType(), optionObject.GetFieldValue("123").GetType());
            Assert.AreEqual(expected1.GetType(), optionObject.GetFieldValue("1", "1||1", "123").GetType());
            Assert.AreEqual(expected2.GetType(), optionObject.GetFieldValue("1", "1||2", "123").GetType());
        }

        [TestMethod]
        public void GetFieldValueOptionObject2ReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, optionObject.GetFieldValue("123"));
            Assert.AreNotEqual(expected2, optionObject.GetFieldValue("123"));
            Assert.AreEqual(expected1, optionObject.GetFieldValue("1", "1||1", "123"));
            Assert.AreEqual(expected2, optionObject.GetFieldValue("1", "1||2", "123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueOptionObject2MissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, optionObject.GetFieldValue("124"));
            Assert.AreNotEqual(expected2, optionObject.GetFieldValue("124"));
            Assert.AreEqual(expected1, optionObject.GetFieldValue("1", "1||1", "124"));
            Assert.AreEqual(expected2, optionObject.GetFieldValue("1", "1||2", "124"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetFieldValueOptionObject2NullReturnsError()
        {
            OptionObject2 optionObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, optionObject.GetFieldValue("124"));
            Assert.AreNotEqual(expected2, optionObject.GetFieldValue("124"));
            Assert.AreEqual(expected1, optionObject.GetFieldValue("1", "1||1", "124"));
            Assert.AreEqual(expected2, optionObject.GetFieldValue("1", "1||2", "124"));
        }

        [TestMethod]
        public void GetFieldValueHelperOptionObject2ReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "123").GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "123").GetType());
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "123").GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "123").GetType());
        }

        [TestMethod]
        public void GetFieldValueHelperOptionObject2ReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "123"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "123"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "123"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueHelperOptionObject2MissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "124"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFieldValueHelperOptionObject2NullReturnsError()
        {
            OptionObject2 optionObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "124"));
        }

        [TestMethod]
        public void GetFieldValueOptionObject2015ReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), optionObject.GetFieldValue("123").GetType());
            Assert.AreEqual(expected2.GetType(), optionObject.GetFieldValue("123").GetType());
            Assert.AreEqual(expected1.GetType(), optionObject.GetFieldValue("1", "1||1", "123").GetType());
            Assert.AreEqual(expected2.GetType(), optionObject.GetFieldValue("1", "1||2", "123").GetType());
        }

        [TestMethod]
        public void GetFieldValueOptionObject2015ReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, optionObject.GetFieldValue("123"));
            Assert.AreNotEqual(expected2, optionObject.GetFieldValue("123"));
            Assert.AreEqual(expected1, optionObject.GetFieldValue("1", "1||1", "123"));
            Assert.AreEqual(expected2, optionObject.GetFieldValue("1", "1||2", "123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueOptionObject2015MissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, optionObject.GetFieldValue("124"));
            Assert.AreNotEqual(expected2, optionObject.GetFieldValue("124"));
            Assert.AreEqual(expected1, optionObject.GetFieldValue("1", "1||1", "124"));
            Assert.AreEqual(expected2, optionObject.GetFieldValue("1", "1||2", "124"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetFieldValueOptionObject2015NullReturnsError()
        {
            OptionObject2015 optionObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, optionObject.GetFieldValue("124"));
            Assert.AreNotEqual(expected2, optionObject.GetFieldValue("124"));
            Assert.AreEqual(expected1, optionObject.GetFieldValue("1", "1||1", "124"));
            Assert.AreEqual(expected2, optionObject.GetFieldValue("1", "1||2", "124"));
        }

        [TestMethod]
        public void GetFieldValueHelperOptionObject2015ReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "123").GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "123").GetType());
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "123").GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "123").GetType());
        }

        [TestMethod]
        public void GetFieldValueHelperOptionObject2015ReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "123"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "123"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "123"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueHelperOptionObject2015MissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "124"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFieldValueHelperOptionObject2015NullReturnsError()
        {
            OptionObject2015 optionObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "124"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||1", "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(optionObject, "1", "1||2", "124"));
        }

        [TestMethod]
        public void GetFieldValueFormObjectReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), formObject.GetFieldValue("123").GetType());
            Assert.AreEqual(expected2.GetType(), formObject.GetFieldValue("123").GetType());
            Assert.AreEqual(expected1.GetType(), formObject.GetFieldValue("1||1", "123").GetType());
            Assert.AreEqual(expected2.GetType(), formObject.GetFieldValue("1||2", "123").GetType());
        }

        [TestMethod]
        public void GetFieldValueFormObjectReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, formObject.GetFieldValue("123"));
            Assert.AreNotEqual(expected2, formObject.GetFieldValue("123"));
            Assert.AreEqual(expected1, formObject.GetFieldValue("1||1", "123"));
            Assert.AreEqual(expected2, formObject.GetFieldValue("1||2", "123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueFormObjectMissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, formObject.GetFieldValue("124"));
            Assert.AreNotEqual(expected2, formObject.GetFieldValue("124"));
            Assert.AreEqual(expected1, formObject.GetFieldValue("1||1", "124"));
            Assert.AreEqual(expected2, formObject.GetFieldValue("1||2", "124"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetFieldValueFormObjectNullReturnsError()
        {
            FormObject formObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, formObject.GetFieldValue("124"));
            Assert.AreNotEqual(expected2, formObject.GetFieldValue("124"));
            Assert.AreEqual(expected1, formObject.GetFieldValue("1||1", "124"));
            Assert.AreEqual(expected2, formObject.GetFieldValue("1||2", "124"));
        }

        [TestMethod]
        public void GetFieldValueHelperFormObjectReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(formObject, "123").GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(formObject, "123").GetType());
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(formObject, "1||1", "123").GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(formObject, "1||2", "123").GetType());
        }

        [TestMethod]
        public void GetFieldValueHelperFormObjectReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(formObject, "123"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(formObject, "123"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(formObject, "1||1", "123"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(formObject, "1||2", "123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueHelperFormObjectMissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new("1", rowObject1);
            formObject.OtherRows.Add(rowObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(formObject, "124"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(formObject, "124"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(formObject, "1||1", "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(formObject, "1||2", "124"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFieldValueHelperFormObjectNullReturnsError()
        {
            FormObject formObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(formObject, "124"));
            Assert.AreNotEqual(expected2, OptionObjectHelpers.GetFieldValue(formObject, "124"));
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(formObject, "1||1", "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(formObject, "1||2", "124"));
        }

        [TestMethod]
        public void GetFieldValueRowObjectReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), rowObject1.GetFieldValue("123").GetType());
            Assert.AreEqual(expected2.GetType(), rowObject2.GetFieldValue("123").GetType());
        }

        [TestMethod]
        public void GetFieldValueRowObjectReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, rowObject1.GetFieldValue("123"));
            Assert.AreEqual(expected2, rowObject2.GetFieldValue("123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueRowObjectMissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, rowObject1.GetFieldValue("124"));
            Assert.AreEqual(expected2, rowObject2.GetFieldValue("124"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetFieldValueRowObjectNullReturnsError()
        {
            RowObject rowObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, rowObject.GetFieldValue("124"));
            Assert.AreEqual(expected2, rowObject.GetFieldValue("124"));
        }

        [TestMethod]
        public void GetFieldValueHelperRowObjectReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(rowObject1, "123").GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(rowObject2, "123").GetType());
        }

        [TestMethod]
        public void GetFieldValueHelperRowObjectReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(rowObject1, "123"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(rowObject2, "123"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFieldValueHelperRowObjectMissingFieldReturnsError()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            RowObject rowObject1 = new("1||1");
            FieldObject fieldObject2 = new("123", "TESTED");
            RowObject rowObject2 = new("1||2");
            rowObject1.Fields.Add(fieldObject1);
            rowObject2.Fields.Add(fieldObject2);
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(rowObject1, "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(rowObject2, "124"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFieldValueHelperRowObjectNullReturnsError()
        {
            RowObject rowObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(rowObject, "124"));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(rowObject, "124"));
        }

        [TestMethod]
        public void GetFieldValueHelperFieldObjectReturnsString()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            FieldObject fieldObject2 = new("123", "TESTED");
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1.GetType(), OptionObjectHelpers.GetFieldValue(fieldObject1).GetType());
            Assert.AreEqual(expected2.GetType(), OptionObjectHelpers.GetFieldValue(fieldObject2).GetType());
        }

        [TestMethod]
        public void GetFieldValueHelperFieldObjectReturnsExpected()
        {
            FieldObject fieldObject1 = new("123", "TEST");
            FieldObject fieldObject2 = new("123", "TESTED");
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(fieldObject1));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(fieldObject2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFieldValueHelperFieldObjectNullReturnsError()
        {
            FieldObject fieldObject = null;
            string expected1 = "TEST";
            string expected2 = "TESTED";
            Assert.AreEqual(expected1, OptionObjectHelpers.GetFieldValue(fieldObject));
            Assert.AreEqual(expected2, OptionObjectHelpers.GetFieldValue(fieldObject));
        }
    }
}
