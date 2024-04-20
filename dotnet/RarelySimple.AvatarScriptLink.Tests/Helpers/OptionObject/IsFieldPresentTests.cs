using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class IsFieldPresentTests
    {
        [TestMethod]
        public void IsFieldPresent_OptionObject_FirstForm_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject_SecondForm_IsPresent()
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
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject_IsNotPresent()
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
            Assert.IsFalse(optionObject.IsFieldPresent("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldPresent_OptionObject_IsNotPresent_NullFieldNumber()
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
            Assert.IsFalse(optionObject.IsFieldPresent(null));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2_FirstForm_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2_SecondForm_IsPresent()
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
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2_IsNotPresent()
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
            Assert.IsFalse(optionObject.IsFieldPresent("234"));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2015_FirstForm_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2015_SecondForm_IsPresent()
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
            Assert.IsTrue(optionObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject2015_IsNotPresent()
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
            Assert.IsFalse(optionObject.IsFieldPresent("234"));
        }

        [TestMethod]
        public void IsFieldPresent_FormObject_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_FormObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsFalse(formObject.IsFieldPresent("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldPresent_FormObject_IsNotPresent_NullFieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new("1");
            Assert.IsFalse(formObject1.IsFieldPresent(null));
        }

        [TestMethod]
        public void IsFieldPresent_RowObject_IsPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", true, false, false));
            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void IsFieldPresent_RowObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsFalse(rowObject.IsFieldPresent("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldPresent_RowObject_IsNotPresent_NullFieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsFalse(rowObject.IsFieldPresent(null));
        }
    }
}
