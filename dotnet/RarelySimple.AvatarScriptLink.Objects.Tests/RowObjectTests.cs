namespace RarelySimple.AvatarScriptLink.Objects.Tests
{
    [TestClass]
    public class RowObjectTests
    {
        [TestMethod]
        public void RowObjectCloneAreEqual()
        {
            RowObject RowObject1 = new()
            {
                RowId = "1"
            };
            RowObject RowObject2 = RowObject1.Clone();
            Assert.AreEqual(RowObject1, RowObject2);
        }

        [TestMethod]
        public void RowObjectEqualsMethodIsTrue()
        {
            RowObject RowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1"
            };
            RowObject RowObject2 = RowObject1.Clone();
            Assert.IsTrue(RowObject1.Equals(RowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsMethodEmptyFieldsIsTrue()
        {
            RowObject RowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject RowObject2 = RowObject1.Clone();
            Assert.IsTrue(RowObject1.Equals(RowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsMethodFieldsIsTrue()
        {
            RowObject RowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = [ new FieldObject() ]
            };
            RowObject RowObject2 = RowObject1.Clone();
            Assert.IsTrue(RowObject1.Equals(RowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsMethodOtherRowsIsFalse()
        {
            RowObject RowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject RowObject2 = RowObject1.Clone();
            RowObject2.Fields.Add(new FieldObject());
            Assert.IsFalse(RowObject1.Equals(RowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsMethodIsFalse()
        {
            RowObject RowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject RowObject2 = RowObject1.Clone();
            RowObject2.RowAction = "EDIT";
            Assert.IsFalse(RowObject1.Equals(RowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsObjectMethodIsFalse()
        {
            RowObject RowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            OptionObject2 RowObject2 = new()
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
            Assert.IsFalse(RowObject1.Equals(RowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsOperatorIsTrue()
        {
            RowObject RowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject RowObject2 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            Assert.IsTrue(RowObject1 == RowObject2);
        }

        [TestMethod]
        public void RowObjectEqualsOperatorLeftNullIsFalse()
        {
            RowObject RowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            Assert.IsFalse(null == RowObject1);
        }

        [TestMethod]
        public void RowObjectEqualsOperatorRightNullIsFalse()
        {
            RowObject RowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            Assert.IsFalse(RowObject1 == null);
        }
    }
}