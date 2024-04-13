using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsFieldLockedTests
    {
        [TestMethod]
        public void IsFieldLocked_OptionObject_FirstForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject_SecondForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject_FirstForm_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject_SecondForm_IsNotLocked()
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
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_OptionObject_IsNotPresent()
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
            Assert.IsTrue(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2_FirstForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2_SecondForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2_FirstForm_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2_SecondForm_IsNotLocked()
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
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_OptionObject2_IsNotPresent()
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
            Assert.IsTrue(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2015_FirstForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2015_SecondForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject1 = new("1");
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2015_FirstForm_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2015_SecondForm_IsNotLocked()
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
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_OptionObject2015_IsNotPresent()
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
            Assert.IsTrue(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        public void IsFieldLocked_FormObject_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_FormObject_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_FormObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldLocked("234"));
        }

        [TestMethod]
        public void IsFieldLocked_RowObject_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_RowObject_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_RowObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsTrue(rowObject.IsFieldLocked("234"));
        }
    }
}
