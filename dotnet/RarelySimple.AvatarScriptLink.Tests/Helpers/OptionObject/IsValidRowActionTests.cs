using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsValidRowActionTests
    {
        [TestMethod]
        public void IsValidRowAction_Null()
        {
            string rowAction = null;
            Assert.IsTrue(OptionObjectHelpers.IsValidRowAction(rowAction));   // Confirm with Netsmart
        }
        [TestMethod]
        public void IsValidRowAction_Blank()
        {
            string rowAction = "";
            Assert.IsTrue(OptionObjectHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_ADD()
        {
            string rowAction = "ADD";
            Assert.IsTrue(OptionObjectHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_DELETE()
        {
            string rowAction = "DELETE";
            Assert.IsTrue(OptionObjectHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_EDIT()
        {
            string rowAction = "EDIT";
            Assert.IsTrue(OptionObjectHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_QuestionMark()
        {
            string rowAction = "?";
            Assert.IsFalse(OptionObjectHelpers.IsValidRowAction(rowAction));
        }

        [TestMethod]
        public void IsValidRowAction_RowActionNone()
        {
            string rowAction = RowAction.None;
            Assert.IsTrue(OptionObjectHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_RowActionAdd()
        {
            string rowAction = RowAction.Add;
            Assert.IsTrue(OptionObjectHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_RowActionDelete()
        {
            string rowAction = RowAction.Delete;
            Assert.IsTrue(OptionObjectHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_RowActionEdit()
        {
            string rowAction = RowAction.Edit;
            Assert.IsTrue(OptionObjectHelpers.IsValidRowAction(rowAction));
        }
    }
}
