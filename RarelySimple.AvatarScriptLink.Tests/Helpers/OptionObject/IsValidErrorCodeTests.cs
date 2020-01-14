using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsValidErrorCodeTests
    {
        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Integer_0_IsTrue()
        {
            Assert.IsTrue(OptionObjectHelpers.IsValidErrorCode(0));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Integer_1_IsTrue()
        {
            Assert.IsTrue(OptionObjectHelpers.IsValidErrorCode(1));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Integer_2_IsTrue()
        {
            Assert.IsTrue(OptionObjectHelpers.IsValidErrorCode(2));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Integer_3_IsTrue()
        {
            Assert.IsTrue(OptionObjectHelpers.IsValidErrorCode(3));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Integer_4_IsTrue()
        {
            Assert.IsTrue(OptionObjectHelpers.IsValidErrorCode(4));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Integer_5_IsTrue()
        {
            Assert.IsTrue(OptionObjectHelpers.IsValidErrorCode(5));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Integer_6_IsTrue()
        {
            Assert.IsTrue(OptionObjectHelpers.IsValidErrorCode(6));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Integer_10_IsFalse()
        {
            Assert.IsFalse(OptionObjectHelpers.IsValidErrorCode(10));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Alpha_IsTrue()
        {
            Assert.IsTrue(OptionObjectHelpers.IsValidErrorCode("3"));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Alpha_IsFalse()
        {
            Assert.IsFalse(OptionObjectHelpers.IsValidErrorCode("A"));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsValidErrorCode_Symbol_IsFalse()
        {
            Assert.IsFalse(OptionObjectHelpers.IsValidErrorCode("&"));
        }

    }
}
