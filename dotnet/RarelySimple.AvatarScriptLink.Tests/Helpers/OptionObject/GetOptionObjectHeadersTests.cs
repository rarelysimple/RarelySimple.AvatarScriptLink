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
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders((IOptionObject2015)optionObject);
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
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders((IOptionObject2015)optionObject);
            bool isPresent = headers.Contains(expected);
            Assert.IsTrue(isPresent);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetOptionObjectHeaders_OptionObject_Null()
        {
            OptionObject nullOptionObject = null;
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders((IOptionObject)nullOptionObject);
            Assert.AreEqual(5, headers.Count);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetOptionObjectHeaders_OptionObject2_Null()
        {
            OptionObject2 nullOptionObject = null;
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders((IOptionObject2)nullOptionObject);
            Assert.AreEqual(5, headers.Count);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetOptionObjectHeaders_OptionObject2015_Null()
        {
            OptionObject2015 nullOptionObject = null;
            List<string> headers = OptionObjectHelpers.GetOptionObjectHeaders((IOptionObject2015)nullOptionObject);
            Assert.AreEqual(5, headers.Count);
        }
    }
}
