using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class IsFieldRequiredTests
    {
        [TestMethod]
        public void IsFieldRequired_OptionObject_FirstForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject_SecondForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject_FirstForm_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject_SecondForm_IsNotRequired()
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
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_OptionObject_IsNotPresent()
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
            Assert.IsTrue(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldRequired_OptionObject_IsRequired_NullFieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldRequired(null));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2_FirstForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2_SecondForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2_FirstForm_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2_SecondForm_IsNotRequired()
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
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_OptionObject2_IsNotPresent()
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
            Assert.IsTrue(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2015_FirstForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2015_SecondForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2015_FirstForm_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2015_SecondForm_IsNotRequired()
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
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_OptionObject2015_IsNotPresent()
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
            Assert.IsTrue(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        public void IsFieldRequired_FormObject_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_FormObject_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_FormObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldRequired_FormObject_IsRequired_NullFieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldRequired(null));
        }

        [TestMethod]
        public void IsFieldRequired_RowObject_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_RowObject_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_RowObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsTrue(rowObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldRequired_RowObject_IsRequired_NullFieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            Assert.IsTrue(rowObject.IsFieldRequired(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldRequired_FieldObject_IsRequired_NullFieldNumber()
        {
            Assert.IsTrue(OptionObjectHelpers.IsFieldRequired(null));
        }
    }
}
