using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class GetNextAvailableRowIdTests
    {
        [TestMethod]
        public void GetNextRowId_FormObjectNonMI()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(new RowObject());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => formObject.GetNextAvailableRowId());
        }

        [TestMethod]
        public void GetNextRowId_FormObjectNoCurrentRow()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            string rowId = formObject.GetNextAvailableRowId();
            Assert.AreEqual("1||1", rowId);
        }

        [TestMethod]
        public void GetNextRowId_FormObjectHasCurrentRow()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject.AddRowObject(new RowObject());
            string rowId = formObject.GetNextAvailableRowId();
            Assert.AreEqual("1||2", rowId);
        }

        [TestMethod]
        public void GetNextRowId_FormObjectHasOtherRow()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject.AddRowObject(new RowObject());
            formObject.AddRowObject(new RowObject());
            string rowId = formObject.GetNextAvailableRowId();
            Assert.AreEqual("1||3", rowId);
        }

        [TestMethod]
        public void GetNextRowId_FormObjectHasMaximumRows()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject.AddRowObject(new RowObject());

            int rowsToAdd = 9998;
            for (int i = 0; i < rowsToAdd; ++i)
            {
                string tempRowId = formObject.FormId + "||" + (i + 2).ToString();
                formObject.OtherRows.Add(new RowObject(tempRowId));
            }

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => formObject.GetNextAvailableRowId());
        }

        [TestMethod]
        public void GetNextRowId_OptionObjectHelpers_FormObjectNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetNextAvailableRowId(null));
        }

        [TestMethod]
        public void GetNextRowId_OptionObjectHelpers_FormObjectNonMI()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(new RowObject());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => OptionObjectHelpers.GetNextAvailableRowId(formObject));
        }

        [TestMethod]
        public void GetNextRowId_OptionObjectHelpers_FormObjectNoCurrentRow()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            string rowId = OptionObjectHelpers.GetNextAvailableRowId(formObject);
            Assert.AreEqual("1||1", rowId);
        }

        [TestMethod]
        public void GetNextRowId_OptionObjectHelpers_FormObjectHasCurrentRow()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject.AddRowObject(new RowObject());
            string rowId = OptionObjectHelpers.GetNextAvailableRowId(formObject);
            Assert.AreEqual("1||2", rowId);
        }

        [TestMethod]
        public void GetNextRowId_OptionObjectHelpers_FormObjectHasOtherRow()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject.AddRowObject(new RowObject());
            formObject.AddRowObject(new RowObject());
            string rowId = OptionObjectHelpers.GetNextAvailableRowId(formObject);
            Assert.AreEqual("1||3", rowId);
        }

        [TestMethod]
        public void GetNextRowId_OptionObjectHelpers_FormObjectHasMaximumRows()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject.AddRowObject(new RowObject());

            int rowsToAdd = 9998;
            for (int i = 0; i < rowsToAdd; ++i)
            {
                string tempRowId = formObject.FormId + "||" + (i + 2).ToString();
                formObject.OtherRows.Add(new RowObject(tempRowId));
            }

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => OptionObjectHelpers.GetNextAvailableRowId(formObject));
        }
    }
}
