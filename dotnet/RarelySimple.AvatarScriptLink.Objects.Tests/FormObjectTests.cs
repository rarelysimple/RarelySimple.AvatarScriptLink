using RarelySimple.AvatarScriptLink.Objects.Interfaces;

namespace RarelySimple.AvatarScriptLink.Objects.Tests
{
    [TestClass]
    public class FormObjectTests
    {
        [TestMethod]
        public void FormObjectCloneAreEqual()
        {
            FormObject formObject1 = new()
            {
                FormId = "1"
            };
            FormObject formObject2 = formObject1.Clone();
            Assert.AreEqual(formObject1, formObject2);
        }

        [TestMethod]
        public void FormObjectClone_WhenOtherRowsAreNull_TreatsOtherRowsAsEmptyCollection()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                OtherRows = null
            };

            FormObject formObject2 = formObject1.Clone();

            Assert.IsNotNull(formObject2.OtherRows);
            Assert.AreEqual(0, formObject2.OtherRows.Count);
        }

        [TestMethod]
        public void FormObjectEqualsMethodIsTrue()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = new RowObject()
            };
            FormObject formObject2 = formObject1.Clone();
            Assert.IsTrue(formObject1.Equals(formObject2));
        }

        [TestMethod]
        public void FormObjectEqualsMethodObjectIsTrue()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = new RowObject()
            };
            IFormObject formObject2 = formObject1.Clone();
            Assert.IsTrue(formObject1.Equals(formObject2));
        }

        [TestMethod]
        public void FormObjectEqualsMethodEmptyOtherRowsIsTrue()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            FormObject formObject2 = formObject1.Clone();
            Assert.IsTrue(formObject1.Equals(formObject2));
        }

        [TestMethod]
        public void FormObjectEqualsMethodOtherRowsIsTrue()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = [ new RowObject() ]
            };
            FormObject formObject2 = formObject1.Clone();
            Assert.IsTrue(formObject1.Equals(formObject2));
        }

        [TestMethod]
        public void FormObjectEqualsMethodOtherRowsIsFalse()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            FormObject formObject2 = formObject1.Clone();
            formObject2.OtherRows.Add(new RowObject());
            Assert.IsFalse(formObject1.Equals(formObject2));
        }

        [TestMethod]
        public void FormObjectEqualsMethodIsFalse()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            FormObject formObject2 = formObject1.Clone();
            formObject2.CurrentRow = new RowObject();
            Assert.IsFalse(formObject1.Equals(formObject2));
        }

        [TestMethod]
        public void FormObjectEqualsObjectMethodIsFalse()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            OptionObject2 formObject2 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SystemCode = "TEST"
            };
            Assert.IsFalse(formObject1.Equals(formObject2));
        }

        [TestMethod]
        public void FormObjectEqualsObjectMethodNullIsFalse()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            Assert.IsFalse(formObject1.Equals(null));
        }

        [TestMethod]
        public void FormObjectEqualsOperatorIsTrue()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            Assert.IsTrue(formObject1 == formObject2);
            Assert.IsFalse(formObject1 != formObject2);
        }

        [TestMethod]
        public void FormObjectEqualsOperatorLeftNullIsFalse()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            Assert.IsFalse(null == formObject1);
            Assert.IsTrue(null != formObject1);
        }

        [TestMethod]
        public void FormObjectEqualsOperatorRightNullIsFalse()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            Assert.IsFalse(formObject1 == null);
            Assert.IsTrue(formObject1 != null);
        }

        [TestMethod]
        public void FormObjectGetHashCodeAreEqual()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            FormObject formObject2 = formObject1;
            Assert.AreEqual(formObject1.GetHashCode(), formObject2.GetHashCode());
        }

        [TestMethod]
        public void FormObjectGetHashCodeCloneAreEqual()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            FormObject formObject2 = formObject1.Clone();
            Assert.AreEqual(formObject1.GetHashCode(), formObject2.GetHashCode());
        }

        [TestMethod]
        public void FormObjectGetHashCodeCloneAreNotEqual()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            FormObject formObject2 = formObject1.Clone();
            formObject2.MultipleIteration = false;
            Assert.AreNotEqual(formObject1.GetHashCode(), formObject2.GetHashCode());
        }

        #region Collection Presence Helper Tests

        [TestMethod]
        public void TestFormObject_HasOtherRows_WhenEmpty()
        {
            var formObject = FormObject.Initialize();
            Assert.IsFalse(formObject.HasOtherRows());
        }

        [TestMethod]
        public void TestFormObject_HasOtherRows_WhenNotEmpty()
        {
            var formObject = FormObject.Initialize();
            formObject.OtherRows.Add(RowObject.Initialize());
            Assert.IsTrue(formObject.HasOtherRows());
        }

        [TestMethod]
        public void TestFormObject_HasOtherRows_WhenMultipleRows()
        {
            var formObject = FormObject.Initialize();
            formObject.OtherRows.Add(RowObject.Initialize());
            formObject.OtherRows.Add(RowObject.Initialize());
            Assert.IsTrue(formObject.HasOtherRows());
        }

        [TestMethod]
        public void TestFormObject_HasCurrentRow_WhenNull()
        {
            var formObject = FormObject.Initialize();
            formObject.CurrentRow = null;
            Assert.IsFalse(formObject.HasCurrentRow());
        }

        [TestMethod]
        public void TestFormObject_HasCurrentRow_WhenSet()
        {
            var formObject = FormObject.Initialize();
            formObject.CurrentRow = RowObject.Initialize();
            Assert.IsTrue(formObject.HasCurrentRow());
        }

        #endregion
    }
}