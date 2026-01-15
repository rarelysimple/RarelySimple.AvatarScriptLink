using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class IsRowMarkedForDeletionTests
    {
        [TestMethod]
        public void IsRowMarkedForDeletion_RowId_IsEmpty()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentNullException>(() => optionObject.IsRowMarkedForDeletion(""));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_RowId_IsNull()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentNullException>(() => optionObject.IsRowMarkedForDeletion(null));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_FirstForm_IsMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_FirstForm_IsNotMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId));
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_SecondForm_IsMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_SecondForm_IsNotMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(new RowObject(rowId));
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject_IsNotPresent()
        {
            string rowId = "1||1";
            RowObject rowObject = new(rowId);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion("2||1"));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_FirstForm_IsMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_FirstForm_IsNotMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId));
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_SecondForm_IsMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_SecondForm_IsNotMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(new RowObject(rowId));
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2_IsNotPresent()
        {
            string rowId = "1||1";
            RowObject rowObject = new(rowId);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion("2||1"));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_FirstForm_IsMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_FirstForm_IsNotMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId));
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_SecondForm_IsMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_SecondForm_IsNotMarked()
        {
            string rowId = "2||1";
            FormObject formObject1 = new("1");
            formObject1.AddRowObject(new RowObject());
            FormObject formObject2 = new("2");
            formObject2.AddRowObject(new RowObject(rowId));
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_OptionObject2015_IsNotPresent()
        {
            string rowId = "1||1";
            RowObject rowObject = new(rowId);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsRowMarkedForDeletion("2||1"));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_IsMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId, rowId, RowAction.Delete));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_IsNotMarked()
        {
            string rowId = "1||1";
            FormObject formObject = new("1");
            formObject.AddRowObject(new RowObject(rowId));
            Assert.IsFalse(formObject.IsRowMarkedForDeletion(rowId));
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_IsNotPresent()
        {
            string rowId = "1||1";
            RowObject rowObject = new(rowId);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            Assert.IsFalse(formObject.IsRowMarkedForDeletion("2||1"));
        }
    }
}
