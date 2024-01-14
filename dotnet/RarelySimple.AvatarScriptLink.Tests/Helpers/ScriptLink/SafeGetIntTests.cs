using RarelySimple.AvatarScriptLink.Helpers;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SafeGetIntTests
    {
        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SafeGetInt_Zero_AreEqual()
        {
            int expected = 0;
            int actual = ScriptLinkHelpers.SafeGetInt("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SafeGetInt_Ten_AreEqual()
        {
            int expected = 10;
            int actual = ScriptLinkHelpers.SafeGetInt("10");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SafeGetInt_NegativeTen_AreEqual()
        {
            int expected = -10;
            int actual = ScriptLinkHelpers.SafeGetInt("-10");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SafeGetInt_Decimal_AreEqual_Zero()
        {
            int expected = 0;
            int actual = ScriptLinkHelpers.SafeGetInt("10.12345");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SafeGetInt_Alpha_AreEqual_Zero()
        {
            int expected = 0;
            int actual = ScriptLinkHelpers.SafeGetInt("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SafeGetInt_Symbol_AreEqual_Zero()
        {
            int expected = 0;
            int actual = ScriptLinkHelpers.SafeGetInt("@");

            Assert.AreEqual(expected, actual);
        }
    }
}
