using System;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{
    /// <summary>
    /// Tests for internal ArgumentGuards validation helpers.
    /// </summary>
    [TestClass]
    public class ArgumentGuardsTests
    {
        [TestMethod]
        public void ValidateFieldNumber_ArgumentGuards_WithNullFieldNumber_ThrowsArgumentNullException()
        {
            var ex = Assert.ThrowsException<ArgumentNullException>(
                () => ArgumentGuards.ValidateFieldNumber(null!, "fieldNumber"));

            Assert.AreEqual("fieldNumber", ex.ParamName);
        }

        [TestMethod]
        public void ValidateFieldNumber_ArgumentGuards_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsException<ArgumentException>(
                () => ArgumentGuards.ValidateFieldNumber(string.Empty, "fieldNumber"));

            Assert.AreEqual("fieldNumber", ex.ParamName);
        }

        [TestMethod]
        public void ValidateFieldNumber_ArgumentGuards_WithValidFieldNumber_DoesNotThrow()
        {
            ArgumentGuards.ValidateFieldNumber("100", "fieldNumber");
        }

        [TestMethod]
        public void ValidateAndNormalizeFieldNumbers_ArgumentGuards_WithNullFieldNumbers_ThrowsArgumentNullException()
        {
            var ex = Assert.ThrowsException<ArgumentNullException>(
                () => ArgumentGuards.ValidateAndNormalizeFieldNumbers(null!, "fieldNumbers"));

            Assert.AreEqual("fieldNumbers", ex.ParamName);
        }

        [TestMethod]
        public void ValidateAndNormalizeFieldNumbers_ArgumentGuards_WithEmptyFieldNumbers_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsException<ArgumentException>(
                () => ArgumentGuards.ValidateAndNormalizeFieldNumbers(new List<string>(), "fieldNumbers"));

            Assert.AreEqual("fieldNumbers", ex.ParamName);
        }

        [TestMethod]
        public void ValidateAndNormalizeFieldNumbers_ArgumentGuards_WithOnlyEmptyValues_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsException<ArgumentException>(
                () => ArgumentGuards.ValidateAndNormalizeFieldNumbers(new List<string> { string.Empty, null!, string.Empty }, "fieldNumbers"));

            Assert.AreEqual("fieldNumbers", ex.ParamName);
        }

        [TestMethod]
        public void ValidateAndNormalizeFieldNumbers_ArgumentGuards_WithDuplicatesAndEmptyValues_ReturnsDistinctNonEmptyValues()
        {
            var result = ArgumentGuards.ValidateAndNormalizeFieldNumbers(
                new List<string> { "100", string.Empty, "100", "101", "101" },
                "fieldNumbers");

            CollectionAssert.AreEqual(new List<string> { "100", "101" }, result);
        }

        [TestMethod]
        public void ValidateAndGetFieldNumbers_ArgumentGuards_WithNullFieldObjects_ThrowsArgumentNullException()
        {
            var ex = Assert.ThrowsException<ArgumentNullException>(
                () => ArgumentGuards.ValidateAndGetFieldNumbers(null!, "fieldObjects"));

            Assert.AreEqual("fieldObjects", ex.ParamName);
        }

        [TestMethod]
        public void ValidateAndGetFieldNumbers_ArgumentGuards_WithEmptyFieldObjects_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsException<ArgumentException>(
                () => ArgumentGuards.ValidateAndGetFieldNumbers(new List<FieldObject>(), "fieldObjects"));

            Assert.AreEqual("fieldObjects", ex.ParamName);
        }

        [TestMethod]
        public void ValidateAndGetFieldNumbers_ArgumentGuards_WithNoValidFieldNumbers_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsException<ArgumentException>(
                () => ArgumentGuards.ValidateAndGetFieldNumbers(
                    new List<FieldObject> { null!, new FieldObject { FieldNumber = string.Empty }, new FieldObject { FieldNumber = null! } },
                    "fieldObjects"));

            Assert.AreEqual("fieldObjects", ex.ParamName);
        }

        [TestMethod]
        public void ValidateAndGetFieldNumbers_ArgumentGuards_WithDuplicatesAndInvalidEntries_ReturnsDistinctFieldNumbers()
        {
            var result = ArgumentGuards.ValidateAndGetFieldNumbers(
                new List<FieldObject>
                {
                    new FieldObject { FieldNumber = "100" },
                    null!,
                    new FieldObject { FieldNumber = string.Empty },
                    new FieldObject { FieldNumber = "100" },
                    new FieldObject { FieldNumber = "101" }
                },
                "fieldObjects");

            CollectionAssert.AreEqual(new List<string> { "100", "101" }, result);
        }
    }
}
