namespace RarelySimple.AvatarScriptLink.Objects.Tests
{
    [TestClass]
    public class OptionObjectTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1"
            };
            OptionObject optionObject2 = optionObject1.Clone();
            Assert.AreEqual(optionObject1, optionObject2);
        }
    }
}