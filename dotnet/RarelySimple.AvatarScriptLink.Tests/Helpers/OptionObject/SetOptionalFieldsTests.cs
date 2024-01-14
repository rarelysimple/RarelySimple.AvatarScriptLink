using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetOptionalFieldsTests
    {
        [TestMethod]
        public void SetOptionalFields_OptionObject_ListFieldNumbers()
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
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetOptionalFields_OptionObject_Null_ListFieldNumbers()
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
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject_ListFieldNumbers_Null()
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
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject_Null_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject_Helper_ListFieldObjects_Null()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject_Null_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject_Helper_ListFieldNumbers_Null()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2_ListFieldNumbers()
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
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetOptionalFields_OptionObject2_Null_ListFieldNumbers()
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
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2_ListFieldNumbers_Null()
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
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2_Null_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2_Helper_ListFieldObjects_Null()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2_Null_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2_Helper_ListFieldNumbers_Null()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2015_ListFieldNumbers()
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
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetOptionalFields_OptionObject2015_Null_ListFieldNumbers()
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
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2015_ListFieldNumbers_Null()
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
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2015_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2015_Null_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2015_Helper_ListFieldObjects_Null()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2015_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2015_Null_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_OptionObject2015_Helper_ListFieldNumbers_Null()
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
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_FormObject_ListFieldNumbers()
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
            formObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetOptionalFields_FormObject_Null_ListFieldNumbers()
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
            formObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_FormObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_FormObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetOptionalFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_FormObject_Null_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetOptionalFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_FormObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetOptionalFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_RowObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetOptionalFields_RowObject_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = null;
            rowObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_RowObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_RowObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetOptionalFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_RowObject_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = null;
            OptionObjectHelpers.SetOptionalFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetOptionalFields_RowObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetOptionalFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }
    }
}
