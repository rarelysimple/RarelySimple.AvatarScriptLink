namespace RarelySimple.AvatarScriptLink.Objects.Tests
{
    [TestClass]
    public class FormObjectTests
    {
        [TestMethod]
        public void FormObjectCloneAreEqual()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1"
            };
            FormObject FormObject2 = FormObject1.Clone();
            Assert.AreEqual(FormObject1, FormObject2);
        }

        [TestMethod]
        public void FormObjectEqualsMethodIsTrue()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = new RowObject()
            };
            FormObject FormObject2 = FormObject1.Clone();
            Assert.IsTrue(FormObject1.Equals(FormObject2));
        }

        [TestMethod]
        public void FormObjectEqualsMethodEmptyOtherRowsIsTrue()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            FormObject FormObject2 = FormObject1.Clone();
            Assert.IsTrue(FormObject1.Equals(FormObject2));
        }

        [TestMethod]
        public void FormObjectEqualsMethodOtherRowsIsTrue()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = [ new RowObject() ]
            };
            FormObject FormObject2 = FormObject1.Clone();
            Assert.IsTrue(FormObject1.Equals(FormObject2));
        }

        [TestMethod]
        public void FormObjectEqualsMethodOtherRowsIsFalse()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            FormObject FormObject2 = FormObject1.Clone();
            FormObject2.OtherRows.Add(new RowObject());
            Assert.IsFalse(FormObject1.Equals(FormObject2));
        }

        [TestMethod]
        public void FormObjectEqualsMethodIsFalse()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            FormObject FormObject2 = FormObject1.Clone();
            FormObject2.CurrentRow = new RowObject();
            Assert.IsFalse(FormObject1.Equals(FormObject2));
        }

        [TestMethod]
        public void FormObjectEqualsObjectMethodIsFalse()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            OptionObject2 FormObject2 = new()
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
            Assert.IsFalse(FormObject1.Equals(FormObject2));
        }

        [TestMethod]
        public void FormObjectEqualsOperatorIsTrue()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            FormObject FormObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            Assert.IsTrue(FormObject1 == FormObject2);
        }

        [TestMethod]
        public void FormObjectEqualsOperatorLeftNullIsFalse()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            Assert.IsFalse(null == FormObject1);
        }

        [TestMethod]
        public void FormObjectEqualsOperatorRightNullIsFalse()
        {
            FormObject FormObject1 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = new RowObject(),
                OtherRows = []
            };
            Assert.IsFalse(FormObject1 == null);
        }
    }
}