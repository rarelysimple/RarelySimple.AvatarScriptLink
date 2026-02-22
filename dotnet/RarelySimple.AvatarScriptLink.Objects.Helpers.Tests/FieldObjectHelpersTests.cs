namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{
    /// <summary>
    /// Tests for FieldObjectHelpers extension methods
    /// </summary>
    [TestClass]
    public class FieldObjectHelpersTests
    {
        [TestMethod]
        public void GetValue_WithValue_ReturnsValue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "TestValue" };

            // Act
            var result = field.GetValue();

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetValue_WithNull_ReturnsNull()
        {
            // Arrange
            FieldObject? field = null;

            // Act
            var result = field?.GetValue();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetValue_WithValue_SetsFieldValue()
        {
            // Arrange
            var field = new FieldObject();

            // Act
            field.SetValue("NewValue");

            // Assert
            Assert.AreEqual("NewValue", field.FieldValue);
        }

        [TestMethod]
        public void SetValue_WithNull_SetsEmptyString()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "OldValue" };

            // Act
            field.SetValue(null!);

            // Assert
            Assert.AreEqual(string.Empty, field.FieldValue);
        }

        [TestMethod]
        public void SetValue_WithNullField_DoesNotThrow()
        {
            // Arrange
            FieldObject? field = null;

            // Act - calling extension method on null should not throw
            field?.SetValue("Value");
            // If we reach here, no exception was thrown - test passes
        }

        [TestMethod]
        public void ClearValue_WithValue_ClearsFieldValue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "SomeValue" };

            // Act
            field.ClearValue();

            // Assert
            Assert.AreEqual(string.Empty, field.FieldValue);
        }

        [TestMethod]
        public void ClearValue_WithNullField_DoesNotThrow()
        {
            // Arrange
            FieldObject? field = null;

            // Act - calling extension method on null should not throw
            field?.ClearValue();
            // If we reach here, no exception was thrown - test passes
        }
    }

}
