using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using System;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetUnlockedFieldsTests
    {
        [TestMethod]
        public void SetUnlockedFields_OptionObject_ListFieldNumbers()
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
            optionObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedFields_OptionObject_Null_ListFieldNumbers()
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
            optionObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject_ListFieldNumbers_Null()
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
            optionObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject_Null_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject_Helper_ListFieldObjects_Null()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject_Null_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject_Helper_ListFieldNumbers_Null()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject2_ListFieldNumbers()
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
            optionObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedFields_OptionObject2_Null_ListFieldNumbers()
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
            optionObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2_ListFieldNumbers_Null()
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
            optionObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject2_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2_Null_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2_Helper_ListFieldObjects_Null()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject2_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2_Null_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2_Helper_ListFieldNumbers_Null()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject2015_ListFieldNumbers()
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
            optionObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedFields_OptionObject2015_Null_ListFieldNumbers()
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
            optionObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2015_ListFieldNumbers_Null()
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
            optionObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject2015_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2015_Null_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2015_Helper_ListFieldObjects_Null()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject2015_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2015_Null_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_OptionObject2015_Helper_ListFieldNumbers_Null()
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
            OptionObjectHelpers.SetUnlockedFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_FormObject_ListFieldNumbers()
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
            formObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedFields_FormObject_Null_ListFieldNumbers()
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
            formObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_FormObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_FormObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetUnlockedFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_FormObject_Null_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetUnlockedFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_FormObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetUnlockedFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_RowObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedFields_RowObject_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = null;
            rowObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_RowObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetUnlockedFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedFields_RowObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetUnlockedFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_RowObject_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = null;
            OptionObjectHelpers.SetUnlockedFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedFields_RowObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetUnlockedFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }
    }
}
