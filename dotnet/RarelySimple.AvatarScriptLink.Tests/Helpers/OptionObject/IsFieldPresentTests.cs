using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsFieldPresentTests
    {
        [TestMethod]
        public void IsFieldPresent_OptionObject_FirstForm_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject_SecondForm_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsFieldPresent("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldPresent_OptionObject_Null()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            Assert.IsFalse(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldPresent_OptionObject_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldPresent(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2_FirstForm_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2_SecondForm_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsFieldPresent("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldPresent_OptionObject2_Null()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            Assert.IsFalse(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldPresent_OptionObject2_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldPresent(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2015_FirstForm_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2015_SecondForm_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2015_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsFieldPresent("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldPresent_OptionObject2015_Null()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            Assert.IsFalse(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldPresent_OptionObject2015_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldPresent(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_FormObject_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_FormObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            Assert.IsFalse(formObject.IsFieldPresent("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldPresent_FormObject_Null()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            Assert.IsFalse(formObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldPresent_FormObject_Helper_Null()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldPresent(formObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_RowObject_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_RowObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsFalse(rowObject.IsFieldPresent("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldPresent_RowObject_Null()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldPresent_RowObject_Helper_Null()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldPresent(rowObject, fieldNumber));
        }
    }
}
