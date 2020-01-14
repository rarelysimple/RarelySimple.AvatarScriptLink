using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsRowMarkedForDeletionTests
    {
        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_FirstForm_IsMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_FirstForm_IsNotMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(new RowObject(rowId));
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_SecondForm_IsMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new FormObject("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_SecondForm_IsNotMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new FormObject("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(new RowObject(rowId));
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_IsNotPresent()
        {
            string rowId = "1||1";
            RowObject rowObject = new RowObject(rowId);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion("2||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowMarkedForDeletion_OptionObject_Null()
        {
            string rowId = "1||1";
            OptionObject optionObject = null;
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowMarkedForDeletion_OptionObject_Helper_Null()
        {
            string rowId = "1||1";
            OptionObject optionObject = null;
            Assert.IsTrue(OptionObjectHelpers.IsRowMarkedForDeletion(optionObject, rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_FirstForm_IsMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_FirstForm_IsNotMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(new RowObject(rowId));
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_SecondForm_IsMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new FormObject("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_SecondForm_IsNotMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new FormObject("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(new RowObject(rowId));
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_IsNotPresent()
        {
            string rowId = "1||1";
            RowObject rowObject = new RowObject(rowId);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion("2||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowMarkedForDeletion_OptionObject2_Null()
        {
            string rowId = "1||1";
            OptionObject2 optionObject = null;
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowMarkedForDeletion_OptionObject2_Helper_Null()
        {
            string rowId = "1||1";
            OptionObject2 optionObject = null;
            Assert.IsTrue(OptionObjectHelpers.IsRowMarkedForDeletion(optionObject, rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_FirstForm_IsMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_FirstForm_IsNotMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(new RowObject(rowId));
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_SecondForm_IsMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new FormObject("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_SecondForm_IsNotMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new FormObject("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(new RowObject(rowId));
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_IsNotPresent()
        {
            string rowId = "1||1";
            RowObject rowObject = new RowObject(rowId);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion("2||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowMarkedForDeletion_OptionObject2015_Null()
        {
            string rowId = "1||1";
            OptionObject2015 optionObject = null;
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowMarkedForDeletion_OptionObject2015_Helper_Null()
        {
            string rowId = "1||1";
            OptionObject2015 optionObject = null;
            Assert.IsTrue(OptionObjectHelpers.IsRowMarkedForDeletion(optionObject, rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_IsMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_IsNotMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(new RowObject(rowId));
            Assert.IsFalse(formObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_IsNotPresent()
        {
            string rowId = "1||1";
            RowObject rowObject = new RowObject(rowId);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            Assert.IsFalse(formObject.IsRowMarkedForDeletion("2||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowMarkedForDeletion_FormObject_Null()
        {
            string rowId = "1||1";
            FormObject formObject = null;
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowMarkedForDeletion_FormObject_Helper_Null()
        {
            string rowId = "1||1";
            FormObject formObject = null;
            Assert.IsTrue(OptionObjectHelpers.IsRowMarkedForDeletion(formObject, rowId));
        }
    }
}
