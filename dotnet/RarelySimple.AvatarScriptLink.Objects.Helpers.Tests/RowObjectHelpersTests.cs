namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{

    /// <summary>
    /// Tests for RowObjectHelpers extension methods
    /// </summary>
    [TestClass]
    public class RowObjectHelpersTests
    {
        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        public void SetField_RowObject_WithNullFieldNumber_ThrowsArgumentNullException(string operation)
        {
            // Arrange
            var row = new RowObject { RowAction = string.Empty };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });

            // Act
            Action act = operation switch
            {
                "Disabled" => () => row.SetDisabledField(null!),
                "Enabled" => () => row.SetEnabledField(null!),
                "Locked" => () => row.SetLockedField(null!),
                "Unlocked" => () => row.SetUnlockedField(null!),
                _ => throw new ArgumentOutOfRangeException(nameof(operation))
            };

            // Assert
            Assert.ThrowsException<ArgumentNullException>(act);
        }

        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        public void SetField_RowObject_WithEmptyFieldNumber_ThrowsArgumentException(string operation)
        {
            // Arrange
            var row = new RowObject { RowAction = string.Empty };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });

            // Act
            Action act = operation switch
            {
                "Disabled" => () => row.SetDisabledField(string.Empty),
                "Enabled" => () => row.SetEnabledField(string.Empty),
                "Locked" => () => row.SetLockedField(string.Empty),
                "Unlocked" => () => row.SetUnlockedField(string.Empty),
                _ => throw new ArgumentOutOfRangeException(nameof(operation))
            };

            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }

        [TestMethod]
        public void GetRowId_RowObject_WithRowId_ReturnsRowId()
        {
            // Arrange
            var row = new RowObject { RowId = "123" };

            // Act
            var result = row.GetRowId();

            // Assert
            Assert.AreEqual("123", result);
        }

        [TestMethod]
        public void GetRowId_RowObject_WithNull_ReturnsNull()
        {
            // Arrange
            RowObject? row = null;

            // Act
            var result = row?.GetRowId();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetParentRowId_RowObject_WithParentRowId_ReturnsParentRowId()
        {
            // Arrange
            var row = new RowObject { ParentRowId = "456" };

            // Act
            var result = row.GetParentRowId();

            // Assert
            Assert.AreEqual("456", result);
        }

        [TestMethod]
        public void GetRowAction_RowObject_WithRowAction_ReturnsRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "EDIT" };

            // Act
            var result = row.GetRowAction();

            // Assert
            Assert.AreEqual("EDIT", result);
        }

        [TestMethod]
        public void IsMarkedForDeletion_RowObject_WithDeleteAction_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject { RowAction = "DELETE" };

            // Act
            var result = row.IsMarkedForDeletion();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMarkedForDeletion_RowObject_WithEditAction_ReturnsFalse()
        {
            // Arrange
            var row = new RowObject { RowAction = "EDIT" };

            // Act
            var result = row.IsMarkedForDeletion();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetFieldCount_RowObject_WithFields_ReturnsCount()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject());
            row.Fields.Add(new FieldObject());

            // Act
            var result = row.GetFieldCount();

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetFieldCount_RowObject_WithNull_ReturnsZero()
        {
            // Arrange
            RowObject? row = null;

            // Act
            var result = row?.GetFieldCount() ?? 0;

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetFieldValue_RowObject_WithExistingField_ReturnsValue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });

            // Act
            var result = row.GetFieldValue("100");

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValue_RowObject_WithNonExistentField_ReturnsNull()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });

            // Act
            var result = row.GetFieldValue("999");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetFieldValue_RowObject_WithNullRow_ReturnsNull()
        {
            // Arrange
            RowObject? row = null;

            // Act
            var result = row?.GetFieldValue("100");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void IsFieldPresent_RowObject_WithField_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100" });

            // Act
            var result = row.IsFieldPresent("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldPresent_RowObject_WithoutField_ReturnsFalse()
        {
            // Arrange
            var row = new RowObject();

            // Act
            var result = row.IsFieldPresent("100");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFieldEnabled_RowObject_WithEnabledField_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            var result = row.IsFieldEnabled("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldEnabled_RowObject_WithDisabledField_ReturnsFalse()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            var result = row.IsFieldEnabled("100");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFieldLocked_RowObject_WithLockedField_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            var result = row.IsFieldLocked("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldRequired_RowObject_WithRequiredField_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });

            // Act
            var result = row.IsFieldRequired("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SetFieldValue_RowObject_WithExistingField_UpdatesValue()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "OldValue" });

            // Act
            var result = row.SetFieldValue("100", "NewValue");

            // Assert
            Assert.AreEqual("NewValue", row.Fields[0].FieldValue);
            Assert.AreEqual("EDIT", row.RowAction);
            Assert.AreSame(row, result);
        }

        [TestMethod]
        public void SetFieldValue_RowObject_WithNonExistentField_DoesNothing()
        {
            // Arrange
            var row = new RowObject();

            // Act
            var result = row.SetFieldValue("999", "Value");

            // Assert
            Assert.IsNull(result?.Fields.FirstOrDefault(f => f.FieldNumber == "999"));
        }

        [TestMethod]
        public void SetFieldValue_RowObject_WithNullRow_ReturnsNull()
        {
            // Arrange
            RowObject? row = null;

            // Act
            var result = row?.SetFieldValue("100", "Value");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void DisableAllFieldObjects_RowObject_WithoutExclusions_DisablesAll()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "100", Enabled = "1" };
            var field2 = new FieldObject { FieldNumber = "101", Enabled = "1" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            row.DisableAllFieldObjects();

            // Assert
            Assert.AreEqual("0", field1.Enabled);
            Assert.AreEqual("0", field2.Enabled);
            Assert.AreEqual("EDIT", row.RowAction);
        }

        [TestMethod]
        public void DisableAllFieldObjects_RowObject_WithNullRowAction_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            var field = new FieldObject { FieldNumber = "100", Enabled = "1" };
            row.Fields.Add(field);

            // Act
            row.DisableAllFieldObjects();

            // Assert
            Assert.AreEqual("0", field.Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void DisableAllFieldObjects_RowObject_WithExclusions_DisablesOnlyNonExcluded()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "100", Enabled = "1" };
            var field2 = new FieldObject { FieldNumber = "101", Enabled = "1" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            row.DisableAllFieldObjects(new List<string> { "101" });

            // Assert
            Assert.AreEqual("0", field1.Enabled);
            Assert.AreEqual("1", field2.Enabled);
        }

        [TestMethod]
        public void SetDisabledField_RowObject_WithExistingField_DisablesTargetField()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });

            // Act
            row.SetDisabledField("101");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("0", row.Fields[1].Enabled);
            Assert.AreEqual("EDIT", row.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_RowObject_WithNullRowAction_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void SetDisabledFields_RowObject_WithFieldNumbers_DisablesMatchingFields()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });

            // Act
            row.SetDisabledFields(["100"]);

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("1", row.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetEnabledField_RowObject_WithExistingField_EnablesTargetField()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });

            // Act
            row.SetEnabledField("100");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("0", row.Fields[1].Enabled);
            Assert.AreEqual("EDIT", row.RowAction);
        }

        [TestMethod]
        public void SetEnabledField_RowObject_WithNullRowAction_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.SetEnabledField("100");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_RowObject_WithAddRowAction_PreservesAdd()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Add };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Add, row.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_RowObject_WithDeleteRowAction_PreservesDelete()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Delete };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Delete, row.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_RowObject_WithFieldNumbers_EnablesMatchingFields()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });

            // Act
            row.SetEnabledFields(["101"]);

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("1", row.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetEnabledFields_RowObject_WithDeleteRowAction_PreservesDelete()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Delete };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.SetEnabledFields(["100"]);

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Delete, row.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_RowObject_WithAddRowAction_PreservesAdd()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Add };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.SetEnabledFields(["100"]);

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Add, row.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_RowObject_WithMissingField_ThrowsArgumentException()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act/Assert
            Assert.ThrowsException<ArgumentException>(() => row.SetDisabledField("999"));
        }

        [TestMethod]
        public void SetDisabledField_RowObject_WhenAlreadyDisabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetDisabledFields_RowObject_WhenAllAlreadyDisabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });

            // Act
            row.SetDisabledFields(["100", "101"]);

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("0", row.Fields[1].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_RowObject_WithEmptyFieldNumbers_ThrowsArgumentException()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act/Assert
            Assert.ThrowsException<ArgumentException>(() => row.SetEnabledFields(new List<string>()));
        }

        [TestMethod]
        public void SetEnabledField_RowObject_WhenAlreadyEnabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.SetEnabledField("100");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_RowObject_WhenAllAlreadyEnabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });

            // Act
            row.SetEnabledFields(["100", "101"]);

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("1", row.Fields[1].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_RowObject_WithoutExclusions_EnablesAll()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "100", Enabled = "0" };
            var field2 = new FieldObject { FieldNumber = "101", Enabled = "0" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            row.EnableAllFieldObjects();

            // Assert
            Assert.AreEqual("1", field1.Enabled);
            Assert.AreEqual("1", field2.Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_RowObject_WithExclusions_EnablesOnlyNonExcluded()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "100", Enabled = "0" };
            var field2 = new FieldObject { FieldNumber = "101", Enabled = "0" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            row.EnableAllFieldObjects(new List<string> { "101" });

            // Assert
            Assert.AreEqual("1", field1.Enabled);
            Assert.AreEqual("0", field2.Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_RowObject_WithNoFields_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };

            // Act
            row.EnableAllFieldObjects();

            // Assert
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_RowObject_WithAllExcluded_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.EnableAllFieldObjects(new List<string> { "100" });

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_RowObject_WhenAlreadyEnabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.EnableAllFieldObjects();

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_RowObject_WithNullRowAction_AndChanges_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.EnableAllFieldObjects();

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void LockAllFieldObjects_RowObject_LocksAllFields()
        {
            // Arrange
            var row = new RowObject();
            var field = new FieldObject { FieldNumber = "100", Lock = "0" };
            row.Fields.Add(field);

            // Act
            row.LockAllFieldObjects();

            // Assert
            Assert.AreEqual("1", field.Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void LockAllFieldObjects_RowObject_WithNoFields_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };

            // Act
            row.LockAllFieldObjects();

            // Assert
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void LockAllFieldObjects_RowObject_WithAllExcluded_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act
            row.LockAllFieldObjects(new List<string> { "100" });

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void LockAllFieldObjects_RowObject_WhenAlreadyLocked_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            row.LockAllFieldObjects();

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void LockAllFieldObjects_RowObject_WithNullRowAction_AndChanges_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act
            row.LockAllFieldObjects();

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_RowObject_UnlocksAllFields()
        {
            // Arrange
            var row = new RowObject();
            var field = new FieldObject { FieldNumber = "100", Lock = "1" };
            row.Fields.Add(field);

            // Act
            row.UnlockAllFieldObjects();

            // Assert
            Assert.AreEqual("0", field.Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_RowObject_WithNoFields_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };

            // Act
            row.UnlockAllFieldObjects();

            // Assert
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_RowObject_WithAllExcluded_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            row.UnlockAllFieldObjects(new List<string> { "100" });

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_RowObject_WhenAlreadyUnlocked_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act
            row.UnlockAllFieldObjects();

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_RowObject_WithNullRowAction_AndChanges_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            row.UnlockAllFieldObjects();

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void SetLockedField_RowObject_WithExistingField_LocksTargetField()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "0" });

            // Act
            row.SetLockedField("101");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual("1", row.Fields[1].Lock);
            Assert.AreEqual("EDIT", row.RowAction);
        }

        [TestMethod]
        public void SetLockedField_RowObject_WhenAlreadyLocked_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            row.SetLockedField("100");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetLockedFields_RowObject_WithFieldNumbers_LocksMatchingFields()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "0" });

            // Act
            row.SetLockedFields(["100"]);

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual("0", row.Fields[1].Lock);
        }

        [TestMethod]
        public void SetUnlockedField_RowObject_WithExistingField_UnlocksTargetField()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "1" });

            // Act
            row.SetUnlockedField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual("1", row.Fields[1].Lock);
            Assert.AreEqual("EDIT", row.RowAction);
        }

        [TestMethod]
        public void SetUnlockedField_RowObject_WhenAlreadyUnlocked_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act
            row.SetUnlockedField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetUnlockedFields_RowObject_WithFieldNumbers_UnlocksMatchingFields()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "1" });

            // Act
            row.SetUnlockedFields(["101"]);

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual("0", row.Fields[1].Lock);
        }

        [TestMethod]
        public void SetLockedField_RowObject_WithAddRowAction_PreservesAdd()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Add };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act
            row.SetLockedField("100");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Add, row.RowAction);
        }

        [TestMethod]
        public void SetUnlockedField_RowObject_WithDeleteRowAction_PreservesDelete()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Delete };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            row.SetUnlockedField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Delete, row.RowAction);
        }

        [TestMethod]
        public void SetLockedField_RowObject_WithMissingField_ThrowsArgumentException()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => row.SetLockedField("999"));
        }

        [TestMethod]
        public void SetUnlockedFields_RowObject_WithEmptyFieldNumbers_ThrowsArgumentException()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => row.SetUnlockedFields(new List<string>()));
        }

        [TestMethod]
        public void SetLockedFields_RowObject_WithDuplicateFieldNumbers_LocksFieldAndSetsRowActionOnce()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act
            row.SetLockedFields(["100", "100"]);

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void SetUnlockedFields_RowObject_WithDuplicateFieldNumbers_UnlocksFieldAndSetsRowActionOnce()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            row.SetUnlockedFields(["100", "100"]);

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }
    }

}
