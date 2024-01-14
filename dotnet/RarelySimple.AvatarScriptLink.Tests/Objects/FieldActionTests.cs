using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class FieldActionTests
    {
        [TestMethod]
        public void FieldAction_Disable_Returns_DISABLE()
        {
            Assert.AreEqual("DISABLE", FieldAction.Disable);
        }

        [TestMethod]
        public void FieldAction_Lock_Returns_LOCK()
        {
            Assert.AreEqual("LOCK", FieldAction.Lock);
        }

        [TestMethod]
        public void FieldAction_Optional_Returns_OPTIONAL()
        {
            Assert.AreEqual("OPTIONAL", FieldAction.Optional);
        }

        [TestMethod]
        public void FieldAction_Require_Returns_REQUIRE()
        {
            Assert.AreEqual("REQUIRE", FieldAction.Require);
        }

        [TestMethod]
        public void FieldAction_Unlock_Returns_UNLOCK()
        {
            Assert.AreEqual("UNLOCK", FieldAction.Unlock);
        }
    }
}
