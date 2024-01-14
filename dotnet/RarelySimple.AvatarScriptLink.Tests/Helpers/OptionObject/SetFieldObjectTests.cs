using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetFieldObjectTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject_NullAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, null, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject_EmptyAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, "", fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject_Null_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Disable, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Disable, fieldNumber);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject_Disabled_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Disable, "234");

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject_Null_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject_Locked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Lock, "234");

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject_Null_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Optional, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Optional, fieldNumber);

            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject_Optional_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Optional, "234");

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject_Null_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject_Required_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Require, "234");

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject_Null_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Unlock, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Unlock, fieldNumber);

            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject_Unlocked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Unlock, "234");

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2_NullAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, null, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2_EmptyAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, "", fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2_Null_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Disable, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Disable, fieldNumber);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2_Disabled_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Disable, "234");

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2_Null_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2_Locked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Lock, "234");

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2_Null_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Optional, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Optional, fieldNumber);

            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2_Optional_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Optional, "234");

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2_Null_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2_Required_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Require, "234");

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2_Null_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Unlock, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Unlock, fieldNumber);

            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2_Unlocked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Unlock, "234");

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2015_NullAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, null, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2015_EmptyAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, "", fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2015_Null_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Disable, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2015_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Disable, fieldNumber);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2015_Disabled_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Disable, "234");

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2015_Null_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2015_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2015_Locked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Lock, "234");

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2015_Null_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Optional, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2015_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Optional, fieldNumber);

            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2015_Optional_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Optional, "234");

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2015_Null_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2015_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2015_Required_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Require, "234");

            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_OptionObject2015_Null_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Unlock, fieldNumber);

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_OptionObject2015_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Unlock, fieldNumber);

            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_OptionObject2015_Unlocked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObject(optionObject, FieldAction.Unlock, "234");

            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_FormObject_NullAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, null, fieldNumber);

            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_FormObject_EmptyAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, "", fieldNumber);

            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_FormObject_Null_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = null;

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Disable, fieldNumber);

            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_FormObject_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Disable, fieldNumber);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_FormObject_Disabled_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Disable, "234");

            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_FormObject_Null_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = null;

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_FormObject_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_FormObject_Locked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Lock, "234");

            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_FormObject_Null_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = null;

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Optional, fieldNumber);

            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_FormObject_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Optional, fieldNumber);

            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_FormObject_Optional_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Optional, "234");

            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_FormObject_Null_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = null;

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_FormObject_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_FormObject_Required_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Require, "234");

            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_FormObject_Null_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = null;

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Unlock, fieldNumber);

            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_FormObject_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Unlock, fieldNumber);

            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_FormObject_Unlocked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObject(formObject, FieldAction.Unlock, "234");

            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_RowObject_NullAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, null, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_RowObject_EmptyAction()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, "", fieldNumber);

            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_RowObject_Null_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Disable, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_RowObject_Disabled()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Disable, fieldNumber);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
            Assert.AreEqual(RowAction.Edit, rowObject.RowAction);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_RowObject_Disabled_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Disable, "234");

            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_RowObject_Null_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_RowObject_Locked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Lock, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
            Assert.AreEqual(RowAction.Edit, rowObject.RowAction);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_RowObject_Locked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Lock, "234");

            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_RowObject_Null_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Optional, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_RowObject_Optional()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Optional, fieldNumber);

            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
            Assert.AreEqual(RowAction.Edit, rowObject.RowAction);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_RowObject_Optional_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Optional, "234");

            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_RowObject_Null_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_RowObject_Required()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Require, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
            Assert.AreEqual(RowAction.Edit, rowObject.RowAction);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_RowObject_Required_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Require, "234");

            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObject_RowObject_Null_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Unlock, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObject_RowObject_Unlocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Unlock, fieldNumber);

            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
            Assert.AreEqual(RowAction.Edit, rowObject.RowAction);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObject_RowObject_Unlocked_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObject(rowObject, FieldAction.Unlock, "234");

            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }
    }
}
