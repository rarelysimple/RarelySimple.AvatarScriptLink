namespace RarelySimple.AvatarScriptLink.Objects.Tests
{
    [TestClass]
    public class FieldObjectTests
    {
        [TestMethod]
        public void TestFieldObject_HasExpectedDefaults() 
        { 
            var fieldObject = new FieldObject();
            Assert.IsNotNull(fieldObject);
            Assert.IsNotNull(fieldObject.Enabled);
            Assert.AreEqual("", fieldObject.Enabled);
            Assert.IsNotNull(fieldObject.FieldNumber);
            Assert.AreEqual("", fieldObject.FieldNumber);
            Assert.IsNotNull(fieldObject.FieldValue);
            Assert.AreEqual("", fieldObject.FieldValue);
            Assert.IsNotNull(fieldObject.Lock);
            Assert.AreEqual("", fieldObject.Lock);
            Assert.IsNotNull(fieldObject.Required);
            Assert.AreEqual("", fieldObject.Required);
        }

        [TestMethod]
        public void TestFieldObject_Enabled_CanSetAndGet()
        {
            var expected = "1";
            var fieldObject = FieldObject.Initialize();
            fieldObject.Enabled = expected;
            Assert.AreEqual(expected, fieldObject.Enabled);
        }

        [TestMethod]
        public void TestFieldObject_FieldNumber_CanSetAndGet()
        {
            var expected = "12345.0";
            var fieldObject = FieldObject.Initialize();
            fieldObject.FieldNumber = expected;
            Assert.AreEqual(expected, fieldObject.FieldNumber);
        }

        [TestMethod]
        public void TestFieldObject_FieldValue_CanSetAndGet()
        {
            var expected = "field value";
            var fieldObject = FieldObject.Initialize();
            fieldObject.FieldValue = expected;
            Assert.AreEqual(expected, fieldObject.FieldValue);
        }

        [TestMethod]
        public void TestFieldObject_Lock_CanSetAndGet()
        {
            var expected = "0";
            var fieldObject = FieldObject.Initialize();
            fieldObject.Lock = expected;
            Assert.AreEqual(expected, fieldObject.Lock);
        }

        [TestMethod]
        public void TestFieldObject_Required_CanSetAndGet()
        {
            var expected = "0";
            var fieldObject = FieldObject.Initialize();
            fieldObject.Required = expected;
            Assert.AreEqual(expected, fieldObject.Required);
        }

        [TestMethod]
        public void TestFieldObject_AreEqual()
        {
            var expected = new FieldObject()
            {
                Enabled = "1",
                FieldNumber = "12345.0",
                FieldValue = "abcdef",
                Lock = "0",
                Required = "1"
            };
            var actual = new FieldObject()
            {
                Enabled = "1",
                FieldNumber = "12345.0",
                FieldValue = "abcdef",
                Lock = "0",
                Required = "1"
            };
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFieldObject_AreNotEqual()
        {
            var expected = new FieldObject()
            {
                Enabled = "1",
                FieldNumber = "12345.0",
                FieldValue = "abcdef",
                Lock = "0",
                Required = "1"
            };
            var actual = new FieldObject()
            {
                Enabled = "1",
                FieldNumber = "12346.0",
                FieldValue = "abcdef",
                Lock = "0",
                Required = "1"
            };
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestFieldObject_Clone_AreEqual()
        {
            var expected = new FieldObject()
            {
                Enabled = "1",
                FieldNumber = "12345.0",
                FieldValue = "abcdef",
                Lock = "0",
                Required = "1"
            };
            var actual = expected.Clone();
            Assert.AreEqual(expected, actual);
        }
    }
}
