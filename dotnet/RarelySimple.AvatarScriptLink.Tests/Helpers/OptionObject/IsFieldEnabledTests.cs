using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsFieldEnabledTests
    {
        [TestMethod]
        public void IsFieldEnabled_OptionObject_FirstForm_IsEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject_SecondForm_IsEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject_FirstForm_IsNotEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject_SecondForm_IsNotEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldEnabled_OptionObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldEnabled_OptionObject_Null()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldEnabled_OptionObject_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldEnabled(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject2_FirstForm_IsEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject2_SecondForm_IsEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject2_FirstForm_IsNotEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject2_SecondForm_IsNotEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldEnabled_OptionObject2_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldEnabled_OptionObject2_Null()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldEnabled_OptionObject2_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldEnabled(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject2015_FirstForm_IsEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject2015_SecondForm_IsEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject2015_FirstForm_IsNotEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject2015_SecondForm_IsNotEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldEnabled_OptionObject2015_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldEnabled_OptionObject2015_Null()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldEnabled_OptionObject2015_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldEnabled(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_FormObject_IsEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_FormObject_IsNotEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldEnabled_FormObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldEnabled_FormObject_Null()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldEnabled_FormObject_Helper_Null()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldEnabled(formObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_RowObject_IsEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void IsFieldEnabled_RowObject_IsNotEnabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldEnabled_RowObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsTrue(rowObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldEnabled_RowObject_Null()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldEnabled_RowObject_Helper_Null()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldEnabled(rowObject, fieldNumber));
        }
    }
}
