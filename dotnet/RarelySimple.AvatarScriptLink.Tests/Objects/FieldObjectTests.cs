using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class FieldObjectTests
    {
        private FieldObject newFieldObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.newFieldObject = new FieldObject();
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_Enabled_CanSetAndGet()
        {
            var expected = "1";
            newFieldObject.Enabled = expected;
            var actual = newFieldObject.Enabled;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_FieldNumber_CanSetAndGet()
        {
            var expected = "12345.0";
            newFieldObject.FieldNumber = expected;
            var actual = newFieldObject.FieldNumber;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_FieldValue_CanSetAndGet()
        {
            var expected = "field value";
            newFieldObject.FieldValue = expected;
            var actual = newFieldObject.FieldValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_Lock_CanSetAndGet()
        {
            var expected = "0";
            newFieldObject.Lock = expected;
            var actual = newFieldObject.Lock;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_Required_CanSetAndGet()
        {
            var expected = "0";
            newFieldObject.Required = expected;
            var actual = newFieldObject.Required;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_AreEqual()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            FieldObject fieldObject2 = new()
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };

            Assert.IsTrue(fieldObject1.Equals(fieldObject2));
            Assert.IsTrue(fieldObject1 == fieldObject2);
            Assert.IsFalse(fieldObject1 != fieldObject2);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_AreNotEqual()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            FieldObject fieldObject2 = new()
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST DIFFERENT",
                Lock = "0",
                Required = "0"
            };

            Assert.IsFalse(fieldObject1.Equals(fieldObject2));
            Assert.IsFalse(fieldObject1 == fieldObject2);
            Assert.IsTrue(fieldObject1 != fieldObject2);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsEnabled_IsFalse()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Build();
            Assert.IsFalse(fieldObject1.IsEnabled());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsEnabled_IsTrue()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            Assert.IsTrue(fieldObject1.IsEnabled());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsLocked_IsFalse()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            Assert.IsFalse(fieldObject1.IsLocked());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsLocked_IsTrue()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled().Locked()
                .Build();
            Assert.IsTrue(fieldObject1.IsLocked());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsModifiedDirectly_IsTrue()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            fieldObject1.FieldValue = "TEST MODIFIED";
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsModifiedIndirectly_IsTrue()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            fieldObject1.SetFieldValue("TEST MODIFIED");
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsRequired_IsFalse()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            Assert.IsFalse(fieldObject1.IsRequired());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsRequired_IsTrue()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled().Required()
                .Build();
            Assert.IsTrue(fieldObject1.IsRequired());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsDisabled_AreEqual()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            fieldObject1.SetAsDisabled();
            Assert.AreEqual("0", fieldObject1.Enabled);
            Assert.AreEqual("0", fieldObject1.Required);
            Assert.IsFalse(fieldObject1.IsEnabled());
            Assert.IsFalse(fieldObject1.IsRequired());
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsEnabled_AreEqual()
        {
            string expected = "1";
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Build();
            fieldObject1.SetAsEnabled();
            Assert.AreEqual(expected, fieldObject1.Enabled);
            Assert.IsTrue(fieldObject1.IsEnabled());
            Assert.IsFalse(fieldObject1.IsRequired());
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsLocked_AreEqual()
        {
            string expected = "1";
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            fieldObject1.SetAsLocked();
            Assert.AreEqual(expected, fieldObject1.Lock);
            Assert.IsTrue(fieldObject1.IsLocked());
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsModified_AreEqual()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            fieldObject1.SetAsModified();
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsOptional_AreEqual()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Required()
                .Build();
            fieldObject1.SetAsOptional();
            Assert.AreEqual("0", fieldObject1.Enabled);
            Assert.AreEqual("0", fieldObject1.Required);
            Assert.IsFalse(fieldObject1.IsEnabled());
            Assert.IsFalse(fieldObject1.IsRequired());
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsRequired_AreEqual()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            fieldObject1.SetAsRequired();
            Assert.AreEqual("1", fieldObject1.Enabled);
            Assert.AreEqual("1", fieldObject1.Required);
            Assert.IsTrue(fieldObject1.IsEnabled());
            Assert.IsTrue(fieldObject1.IsRequired());
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsUnlocked_AreEqual()
        {
            string expected = "0";
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123").FieldValue("TEST")
                .Enabled()
                .Build();
            fieldObject1.SetAsUnlocked();
            Assert.AreEqual(expected, fieldObject1.Lock);
            Assert.IsFalse(fieldObject1.IsLocked());
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_ToHtmlString_WithoutHtmlHeaders_NotNull()
        {
            var actual = newFieldObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_ToHtmlString_WithHtmlHeaders_NotNull()
        {
            var actual = newFieldObject.ToHtmlString(true);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_Constructor_1Parameter_NoError()
        {
            string expected = "123.45";
            FieldObject fieldObject = new(expected);
            Assert.AreEqual(expected, fieldObject.FieldNumber);
            Assert.AreEqual("", fieldObject.FieldValue);
            Assert.AreEqual("0", fieldObject.Enabled);
            Assert.AreEqual("0", fieldObject.Lock);
            Assert.AreEqual("0", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void FieldObject_Constructor_1Parameter_Error()
        {
            string expected = "";
            FieldObject fieldObject = new(expected);
            Assert.AreEqual(expected, fieldObject.FieldNumber);
            Assert.AreEqual("", fieldObject.FieldValue);
            Assert.AreEqual("1", fieldObject.Enabled);
            Assert.AreEqual("1", fieldObject.Lock);
            Assert.AreEqual("1", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_Constructor_2Parameter_NoError()
        {
            string fieldNumber = "123.45";
            string fieldValue = "TEST";
            FieldObject fieldObject = new(fieldNumber, fieldValue);
            Assert.AreEqual(fieldNumber, fieldObject.FieldNumber);
            Assert.AreEqual(fieldValue, fieldObject.FieldValue);
            Assert.AreEqual("0", fieldObject.Enabled);
            Assert.AreEqual("0", fieldObject.Lock);
            Assert.AreEqual("0", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void FieldObject_Constructor_2Parameter_Error()
        {
            string fieldNumber = "";
            string fieldValue = "TEST";
            FieldObject fieldObject = new(fieldNumber, fieldValue);
            Assert.AreEqual(fieldNumber, fieldObject.FieldNumber);
            Assert.AreEqual(fieldValue, fieldObject.FieldValue);
            Assert.AreEqual("1", fieldObject.Enabled);
            Assert.AreEqual("1", fieldObject.Lock);
            Assert.AreEqual("1", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_Constructor_5Parameter_NoError()
        {
            string fieldNumber = "123.45";
            string fieldValue = "TEST";
            FieldObject fieldObject = new(fieldNumber, fieldValue, true, true, true);
            Assert.AreEqual(fieldNumber, fieldObject.FieldNumber);
            Assert.AreEqual(fieldValue, fieldObject.FieldValue);
            Assert.AreEqual("1", fieldObject.Enabled);
            Assert.AreEqual("1", fieldObject.Lock);
            Assert.AreEqual("1", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void FieldObject_Constructor_5Parameter_Error()
        {
            string fieldNumber = "";
            string fieldValue = "TEST";
            FieldObject fieldObject = new(fieldNumber, fieldValue, true, true, true);
            Assert.AreEqual(fieldNumber, fieldObject.FieldNumber);
            Assert.AreEqual(fieldValue, fieldObject.FieldValue);
            Assert.AreEqual("1", fieldObject.Enabled);
            Assert.AreEqual("1", fieldObject.Lock);
            Assert.AreEqual("1", fieldObject.Required);
        }

        [TestMethod]
        public void FieldObject_Clone_AreEqual()
        {
            FieldObject fieldObject = new("123", "Test");

            FieldObject cloneObject = fieldObject.Clone();

            Assert.AreEqual(fieldObject, cloneObject);
        }

        [TestMethod]
        public void FieldObject_Clone_AreNotEqual()
        {
            FieldObject fieldObject = new("123", "Test");
            FieldObject cloneObject = fieldObject.Clone();

            fieldObject.SetFieldValue("Modified");

            Assert.AreNotEqual(fieldObject, cloneObject);
        }
    }
}
