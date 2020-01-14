using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SplitDelimitedParameterTests
    {
        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SplitDelimitedString_Default_AreEqual()
        {
            string expected = "three";
            string[] parameters = ScriptLinkHelpers.SplitDelimitedParameter("one,two,three,four,five");
            string actual = parameters[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SplitDelimitedString_Default_Empty_AreEqual()
        {
            string expected = "";
            string[] parameters = ScriptLinkHelpers.SplitDelimitedParameter("");
            string actual = parameters[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SplitDelimitedString_Colon_AreEqual()
        {
            string expected = "three";
            string[] parameters = ScriptLinkHelpers.SplitDelimitedParameter("one:two:three:four:five", ':');
            string actual = parameters[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SplitDelimitedString_Comma_AreEqual()
        {
            string expected = "three";
            string[] parameters = ScriptLinkHelpers.SplitDelimitedParameter("one,two,three,four,five", ',');
            string actual = parameters[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SplitDelimitedString_Period_AreEqual()
        {
            string expected = "three";
            string[] parameters = ScriptLinkHelpers.SplitDelimitedParameter("one.two.three.four.five", '.');
            string actual = parameters[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void SplitDelimitedString_Pipe_AreEqual()
        {
            string expected = "three";
            string[] parameters = ScriptLinkHelpers.SplitDelimitedParameter("one|two|three|four|five", '|');
            string actual = parameters[2];

            Assert.AreEqual(expected, actual);
        }
    }
}
