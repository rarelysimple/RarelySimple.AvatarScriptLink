using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class GetOptionObjectHeadersTests
    {
        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject_IsNotNull()
        {
            OptionObject optionObject = new();
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders((IOptionObject)optionObject);
            Assert.IsNotNull(headers);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject2_IsNotNull()
        {
            OptionObject2 optionObject = new();
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders((IOptionObject2)optionObject);
            Assert.IsNotNull(headers);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject2015_IsNotNull()
        {
            OptionObject2015 optionObject = new();
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders(optionObject);
            Assert.IsNotNull(headers);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject_ContainsExpected_EntityID_Entry()
        {
            OptionObject optionObject = new();
            string expected = "Entity ID: " + optionObject.EntityID;
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders((IOptionObject)optionObject);
            bool isPresent = headers.Contains(expected);
            Assert.IsTrue(isPresent);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject2_ContainsExpected_EntityID_Entry()
        {
            OptionObject2 optionObject = new();
            string expected = "Entity ID: " + optionObject.EntityID;
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders((IOptionObject2)optionObject);
            bool isPresent = headers.Contains(expected);
            Assert.IsTrue(isPresent);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject2015_ContainsExpected_EntityID_Entry()
        {
            OptionObject2015 optionObject = new();
            string expected = "Entity ID: " + optionObject.EntityID;
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders(optionObject);
            bool isPresent = headers.Contains(expected);
            Assert.IsTrue(isPresent);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetOptionObjectHeaders_OptionObject2015_Null()
        {
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders(null);
            Assert.AreEqual(14, headers.Count);
        }
    }
}
