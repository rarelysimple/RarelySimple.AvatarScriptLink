using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;

namespace RarelySimple.AvatarScriptLink.Objects.Tests
{
    [TestClass]
    public class RowObjectTests
    {
        [TestMethod]
        public void RowObjectCloneAreEqual()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1"
            };
            RowObject rowObject2 = rowObject1.Clone();
            Assert.AreEqual(rowObject1, rowObject2);
        }

        [TestMethod]
        public void RowObjectEqualsMethodIsTrue()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1"
            };
            RowObject rowObject2 = rowObject1.Clone();
            Assert.IsTrue(rowObject1.Equals(rowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsMethodObjectIsTrue()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1"
            };
            IRowObject rowObject2 = rowObject1.Clone();
            Assert.IsTrue(rowObject1.Equals(rowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsMethodEmptyFieldsIsTrue()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject rowObject2 = rowObject1.Clone();
            Assert.IsTrue(rowObject1.Equals(rowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsMethodFieldsIsTrue()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = [ new FieldObject() ]
            };
            RowObject rowObject2 = rowObject1.Clone();
            Assert.IsTrue(rowObject1.Equals(rowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsMethodOtherRowsIsFalse()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject rowObject2 = rowObject1.Clone();
            rowObject2.Fields.Add(new FieldObject());
            Assert.IsFalse(rowObject1.Equals(rowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsMethodIsFalse()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject rowObject2 = rowObject1.Clone();
            rowObject2.RowAction = "EDIT";
            Assert.IsFalse(rowObject1.Equals(rowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsObjectMethodIsFalse()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            OptionObject2 rowObject2 = new()
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
            Assert.IsFalse(rowObject1.Equals(rowObject2));
        }

        [TestMethod]
        public void RowObjectEqualsObjectMethodNullIsFalse()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            Assert.IsFalse(rowObject1.Equals(null));
        }

        [TestMethod]
        public void RowObjectEqualsOperatorIsTrue()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject rowObject2 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            Assert.IsTrue(rowObject1 == rowObject2);
            Assert.IsFalse(rowObject1 != rowObject2);
        }

        [TestMethod]
        public void RowObjectEqualsOperatorLeftNullIsFalse()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            Assert.IsFalse(null == rowObject1);
            Assert.IsTrue(null != rowObject1);
        }

        [TestMethod]
        public void RowObjectEqualsOperatorRightNullIsFalse()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            Assert.IsFalse(rowObject1 == null);
            Assert.IsTrue(rowObject1 != null);
        }

        [TestMethod]
        public void RowObjectGetHashCodeAreEqual()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject rowObject2 = rowObject1;
            Assert.AreEqual(rowObject1.GetHashCode(), rowObject2.GetHashCode());
        }

        [TestMethod]
        public void RowObjectGetHashCodeCloneAreEqual()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject rowObject2 = rowObject1.Clone();
            Assert.AreEqual(rowObject1.GetHashCode(), rowObject2.GetHashCode());
        }

        [TestMethod]
        public void RowObjectGetHashCodeAreNotEqual()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2",
                RowAction = "",
                ParentRowId = "1",
                Fields = []
            };
            RowObject rowObject2 = rowObject1.Clone();
            rowObject2.RowAction = "EDIT";
            Assert.AreNotEqual(rowObject1.GetHashCode(), rowObject2.GetHashCode());
        }
    }
}