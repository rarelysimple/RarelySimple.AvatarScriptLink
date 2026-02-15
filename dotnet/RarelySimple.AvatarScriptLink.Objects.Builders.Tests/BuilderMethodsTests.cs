namespace RarelySimple.AvatarScriptLink.Objects.Builders.Tests
{
    [TestClass]
    public class FieldObjectBuildersTests
    {
        [TestMethod]
        public void CreateFieldObject_WithFieldNumber_ReturnsFieldObjectWithFieldNumber()
        {
            // Arrange
            string fieldNumber = "001";

            // Act
            FieldObject result = FieldObjectBuilders.CreateFieldObject(fieldNumber);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(fieldNumber, result.FieldNumber);
        }

        [TestMethod]
        public void WithFieldNumber_SetsFieldNumber()
        {
            // Arrange
            var field = new FieldObject();
            string fieldNumber = "002";

            // Act
            FieldObject result = field.WithFieldNumber(fieldNumber);

            // Assert
            Assert.AreSame(field, result); // Check fluent interface
            Assert.AreEqual(fieldNumber, field.FieldNumber);
        }

        [TestMethod]
        public void WithFieldValue_SetsFieldValue()
        {
            // Arrange
            var field = new FieldObject();
            string value = "Test Value";

            // Act
            FieldObject result = field.WithFieldValue(value);

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual(value, field.FieldValue);
        }

        [TestMethod]
        public void AsEnabled_EnablesField()
        {
            // Arrange
            var field = new FieldObject { Enabled = "0" };

            // Act
            FieldObject result = field.AsEnabled(true);

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("1", field.Enabled);
        }

        [TestMethod]
        public void AsEnabled_DisablesField()
        {
            // Arrange
            var field = new FieldObject { Enabled = "1" };

            // Act
            FieldObject result = field.AsEnabled(false);

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("0", field.Enabled);
        }

        [TestMethod]
        public void AsLocked_LocksField()
        {
            // Arrange
            var field = new FieldObject { Lock = "0" };

            // Act
            FieldObject result = field.AsLocked(true);

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("1", field.Lock);
        }

        [TestMethod]
        public void AsRequired_MarksRequired()
        {
            // Arrange
            var field = new FieldObject { Required = "0" };

            // Act
            FieldObject result = field.AsRequired(true);

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("1", field.Required);
        }

        [TestMethod]
        public void FluentBuilder_ChainsMethods()
        {
            // Arrange & Act
            FieldObject result = FieldObjectBuilders.CreateFieldObject("001")
                .WithFieldValue("Test")
                .AsEnabled(true)
                .AsRequired(true);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("001", result.FieldNumber);
            Assert.AreEqual("Test", result.FieldValue);
            Assert.AreEqual("1", result.Enabled);
            Assert.AreEqual("1", result.Required);
        }
    }

    [TestClass]
    public class FormObjectBuildersTests
    {
        [TestMethod]
        public void CreateFormObject_WithFormId_ReturnsFormObjectWithFormId()
        {
            // Arrange
            string formId = "TestForm";

            // Act
            FormObject result = FormObjectBuilders.CreateFormObject(formId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(formId, result.FormId);
        }

        [TestMethod]
        public void WithFormId_SetsFormId()
        {
            // Arrange
            var form = new FormObject();
            string formId = "Form123";

            // Act
            FormObject result = form.WithFormId(formId);

            // Assert
            Assert.AreSame(form, result);
            Assert.AreEqual(formId, form.FormId);
        }

        [TestMethod]
        public void WithMultipleIteration_SetsMultipleIteration()
        {
            // Arrange
            var form = new FormObject();

            // Act
            FormObject result = form.WithMultipleIteration(true);

            // Assert
            Assert.AreSame(form, result);
            Assert.IsTrue(form.MultipleIteration);
        }

        [TestMethod]
        public void WithCurrentRow_SetsCurrentRow()
        {
            // Arrange
            var form = new FormObject();
            var row = new RowObject { RowId = "1" };

            // Act
            FormObject result = form.WithCurrentRow(row);

            // Assert
            Assert.AreSame(form, result);
            Assert.AreSame(row, form.CurrentRow);
        }

        [TestMethod]
        public void AddRow_AddsRowToOtherRows()
        {
            // Arrange
            var form = new FormObject();
            var row = new RowObject { RowId = "2" };

            // Act
            FormObject result = form.AddRow(row);

            // Assert
            Assert.AreSame(form, result);
            Assert.AreEqual(1, form.OtherRows.Count);
            Assert.AreSame(row, form.OtherRows[0]);
        }

        [TestMethod]
        public void AddRow_IgnoresNullRow()
        {
            // Arrange
            var form = new FormObject();

            // Act
            FormObject result = form.AddRow(null);

            // Assert
            Assert.AreSame(form, result);
            Assert.AreEqual(0, form.OtherRows.Count);
        }

        [TestMethod]
        public void FluentBuilder_ChainsMethods()
        {
            // Arrange
            var row1 = new RowObject { RowId = "1" };
            var row2 = new RowObject { RowId = "2" };

            // Act
            FormObject result = FormObjectBuilders.CreateFormObject("TestForm")
                .WithMultipleIteration(true)
                .WithCurrentRow(row1)
                .AddRow(row2);

            // Assert
            Assert.AreEqual("TestForm", result.FormId);
            Assert.IsTrue(result.MultipleIteration);
            Assert.AreSame(row1, result.CurrentRow);
            Assert.AreEqual(1, result.OtherRows.Count);
        }
    }

    [TestClass]
    public class RowObjectBuildersTests
    {
        [TestMethod]
        public void CreateRowObject_WithRowId_ReturnsRowObjectWithRowId()
        {
            // Arrange
            string rowId = "1";

            // Act
            RowObject result = RowObjectBuilders.CreateRowObject(rowId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(rowId, result.RowId);
        }

        [TestMethod]
        public void WithRowId_SetsRowId()
        {
            // Arrange
            var row = new RowObject();
            string rowId = "123";

            // Act
            RowObject result = row.WithRowId(rowId);

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual(rowId, row.RowId);
        }

        [TestMethod]
        public void WithParentRowId_SetsParentRowId()
        {
            // Arrange
            var row = new RowObject();
            string parentRowId = "parent123";

            // Act
            RowObject result = row.WithParentRowId(parentRowId);

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual(parentRowId, row.ParentRowId);
        }

        [TestMethod]
        public void WithRowAction_SetsRowAction()
        {
            // Arrange
            var row = new RowObject();

            // Act
            RowObject result = row.WithRowAction("ADD");

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual("ADD", row.RowAction);
        }

        [TestMethod]
        public void AddField_AddsFieldToFields()
        {
            // Arrange
            var row = new RowObject();
            var field = new FieldObject { FieldNumber = "001" };

            // Act
            RowObject result = row.AddField(field);

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual(1, row.Fields.Count);
            Assert.AreSame(field, row.Fields[0]);
        }

        [TestMethod]
        public void AddField_IgnoresNullField()
        {
            // Arrange
            var row = new RowObject();

            // Act
            RowObject result = row.AddField(null);

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual(0, row.Fields.Count);
        }
    }

    [TestClass]
    public class OptionObjectBuildersTests
    {
        [TestMethod]
        public void CreateOptionObject_WithEntityId_ReturnsOptionObjectWithEntityId()
        {
            // Arrange
            string entityId = "Patient123";

            // Act
            OptionObject result = OptionObjectBuilders.CreateOptionObject(entityId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(entityId, result.EntityID);
        }

        [TestMethod]
        public void WithEntityId_SetsEntityId()
        {
            // Arrange
            var option = new OptionObject();
            string entityId = "Test456";

            // Act
            OptionObject result = option.WithEntityId(entityId);

            // Assert
            Assert.AreSame(option, result);
            Assert.AreEqual(entityId, option.EntityID);
        }

        [TestMethod]
        public void WithErrorCodeAndMessage_SetsErrorCodeAndMessage()
        {
            // Arrange
            var option = new OptionObject();
            double errorCode = 1;
            string errorMessage = "Test Error";

            // Act
            OptionObject result = option.WithErrorCodeAndMessage(errorCode, errorMessage);

            // Assert
            Assert.AreSame(option, result);
            Assert.AreEqual(errorCode, option.ErrorCode);
            Assert.AreEqual(errorMessage, option.ErrorMesg);
        }

        [TestMethod]
        public void WithErrorCodeAndMessage_HandlesNullMessage()
        {
            // Arrange
            var option = new OptionObject();

            // Act
            option.WithErrorCodeAndMessage(2, null);

            // Assert
            Assert.AreEqual(string.Empty, option.ErrorMesg);
        }

        [TestMethod]
        public void AddForm_AddsFormToForms()
        {
            // Arrange
            var option = new OptionObject();
            var form = new FormObject { FormId = "TestForm" };

            // Act
            OptionObject result = option.AddForm(form);

            // Assert
            Assert.AreSame(option, result);
            Assert.AreEqual(1, option.Forms.Count);
            Assert.AreSame(form, option.Forms[0]);
        }

        [TestMethod]
        public void AddForm_IgnoresNullForm()
        {
            // Arrange
            var option = new OptionObject();

            // Act
            OptionObject result = option.AddForm(null);

            // Assert
            Assert.AreSame(option, result);
            Assert.AreEqual(0, option.Forms.Count);
        }
    }
}
