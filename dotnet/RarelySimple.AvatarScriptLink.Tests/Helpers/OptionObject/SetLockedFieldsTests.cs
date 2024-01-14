using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetLockedFieldsTests
    {
        [TestMethod]
        public void SetLockedFields_OptionObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedFields(fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedFields_OptionObject_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;
            optionObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldObjects);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject_Null_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;
            OptionObjectHelpers.SetLockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject_Helper_ListFieldObjects_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;
            OptionObjectHelpers.SetLockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedFields(fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedFields_OptionObject2_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;
            optionObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldObjects);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2_Null_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;
            OptionObjectHelpers.SetLockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2_Helper_ListFieldObjects_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;
            OptionObjectHelpers.SetLockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2015_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedFields(fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedFields_OptionObject2015_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;
            optionObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2015_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2015_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldObjects);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2015_Null_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;
            OptionObjectHelpers.SetLockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2015_Helper_ListFieldObjects_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2015_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2015_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;
            OptionObjectHelpers.SetLockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_OptionObject2015_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_FormObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetLockedFields(fieldNumbers);
            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedFields_FormObject_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = null;
            formObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_FormObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_FormObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetLockedFields(formObject, fieldNumbers);
            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_FormObject_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = null;
            OptionObjectHelpers.SetLockedFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_FormObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetLockedFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_RowObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetLockedFields(fieldNumbers);
            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedFields_RowObject_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = null;
            rowObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_RowObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetLockedFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedFields_RowObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetLockedFields(rowObject, fieldNumbers);
            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_RowObject_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = null;
            OptionObjectHelpers.SetLockedFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedFields_RowObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetLockedFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }
    }
}
