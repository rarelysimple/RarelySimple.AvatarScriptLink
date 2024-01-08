using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Tests.Decorators
{
    [TestClass]
    public class FieldObjectDecoratorTests
    {
        [TestMethod]
        public void TestFieldObjectIsNotModified()
        {
            var expected = new FieldObject()
            {
                Enabled = "1",
                FieldNumber = "123.45",
                FieldValue = "sample value",
                Lock = "0",
                Required = "1"
            };
            var decorator = new FieldObjectDecorator(expected);
            Assert.IsFalse(decorator.IsModified());
        }

        [TestMethod]
        public void TestFieldObjectIsModified()
        {
            var expected = new FieldObject()
            {
                Enabled = "1",
                FieldNumber = "123.45",
                FieldValue = "sample value",
                Lock = "0",
                Required = "1"
            };
            var decorator = new FieldObjectDecorator(expected)
            {
                FieldValue = "modified"
            };
            Assert.IsTrue(decorator.IsModified());
        }

        [TestMethod]
        public void TestFieldObjectReturnsUnmodified()
        {
            var expected = new FieldObject()
            {
                Enabled = "1",
                FieldNumber = "123.45",
                FieldValue = "sample value",
                Lock = "0",
                Required = "1"
            };
            var decorator = new FieldObjectDecorator(expected);
            var actual = decorator.Return().AsFieldObject();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFieldObjectReturnsModified()
        {
            var expected = new FieldObject()
            {
                Enabled = "1",
                FieldNumber = "123.45",
                FieldValue = "sample value",
                Lock = "0",
                Required = "1"
            };
            var decorator = new FieldObjectDecorator(expected)
            {
                FieldValue = "modified"
            };
            var actual = decorator.Return().AsFieldObject();
            Assert.AreNotEqual(expected, actual);
        }
    }
}
