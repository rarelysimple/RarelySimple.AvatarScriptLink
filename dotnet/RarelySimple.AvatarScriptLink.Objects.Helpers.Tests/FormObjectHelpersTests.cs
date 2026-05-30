namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{

    /// <summary>
    /// Tests for FormObjectHelpers extension methods
    /// </summary>
    [TestClass]
    public class FormObjectHelpersTests
    {
        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        [DataRow("Required")]
        [DataRow("Optional")]
        public void SetField_FormObject_WithNullFieldNumber_ThrowsArgumentNullException(string operation)
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });

            // Act
            Action act = operation switch
            {
                "Disabled" => () => form.SetDisabledField(null!),
                "Enabled" => () => form.SetEnabledField(null!),
                "Locked" => () => form.SetLockedField(null!),
                "Unlocked" => () => form.SetUnlockedField(null!),
                "Required" => () => form.SetRequiredField(null!),
                "Optional" => () => form.SetOptionalField(null!),
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
        [DataRow("Required")]
        [DataRow("Optional")]
        public void SetField_FormObject_WithEmptyFieldNumber_ThrowsArgumentException(string operation)
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });

            // Act
            Action act = operation switch
            {
                "Disabled" => () => form.SetDisabledField(string.Empty),
                "Enabled" => () => form.SetEnabledField(string.Empty),
                "Locked" => () => form.SetLockedField(string.Empty),
                "Unlocked" => () => form.SetUnlockedField(string.Empty),
                "Required" => () => form.SetRequiredField(string.Empty),
                "Optional" => () => form.SetOptionalField(string.Empty),
                _ => throw new ArgumentOutOfRangeException(nameof(operation))
            };

            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }

        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        [DataRow("Required")]
        [DataRow("Optional")]
        public void SetField_FormObject_WithFieldOnlyInOtherRow_OnlyAppliesToMatchingRow(string operation)
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty }, MultipleIteration = true };
            var otherRow = new RowObject { RowId = "2", RowAction = string.Empty };

            switch (operation)
            {
                case "Disabled":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Enabled = "1" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
                    form.OtherRows.Add(otherRow);

                    form.SetDisabledField("100");

                    Assert.AreEqual("1", form.CurrentRow.Fields[0].Enabled);
                    Assert.AreEqual("0", otherRow.Fields[0].Enabled);
                    break;
                case "Enabled":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Enabled = "0" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
                    form.OtherRows.Add(otherRow);

                    form.SetEnabledField("100");

                    Assert.AreEqual("0", form.CurrentRow.Fields[0].Enabled);
                    Assert.AreEqual("1", otherRow.Fields[0].Enabled);
                    break;
                case "Locked":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Lock = "0" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
                    form.OtherRows.Add(otherRow);

                    form.SetLockedField("100");

                    Assert.AreEqual("0", form.CurrentRow.Fields[0].Lock);
                    Assert.AreEqual("1", otherRow.Fields[0].Lock);
                    break;
                case "Unlocked":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Lock = "1" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
                    form.OtherRows.Add(otherRow);

                    form.SetUnlockedField("100");

                    Assert.AreEqual("1", form.CurrentRow.Fields[0].Lock);
                    Assert.AreEqual("0", otherRow.Fields[0].Lock);
                    break;
                case "Required":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Required = "0" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "0" });
                    form.OtherRows.Add(otherRow);

                    form.SetRequiredField("100");

                    Assert.AreEqual("0", form.CurrentRow.Fields[0].Required);
                    Assert.AreEqual("1", otherRow.Fields[0].Required);
                    break;
                case "Optional":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Required = "1" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });
                    form.OtherRows.Add(otherRow);

                    form.SetOptionalField("100");

                    Assert.AreEqual("1", form.CurrentRow.Fields[0].Required);
                    Assert.AreEqual("0", otherRow.Fields[0].Required);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation));
            }

            Assert.AreEqual(string.Empty, form.CurrentRow.RowAction);
            Assert.AreEqual(RowObject.RowActions.Edit, otherRow.RowAction);
        }

        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        [DataRow("Required")]
        [DataRow("Optional")]
        public void SetFields_FormObject_WithMixedRowMatches_OnlyAppliesToMatchingRows(string operation)
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty }, MultipleIteration = true };
            var otherRow = new RowObject { RowId = "2", RowAction = string.Empty };

            switch (operation)
            {
                case "Disabled":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "200", Enabled = "1" });
                    form.OtherRows.Add(otherRow);

                    form.SetDisabledFields(["100"]);

                    Assert.AreEqual("0", form.CurrentRow.Fields[0].Enabled);
                    Assert.AreEqual("1", otherRow.Fields[0].Enabled);
                    break;
                case "Enabled":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "200", Enabled = "0" });
                    form.OtherRows.Add(otherRow);

                    form.SetEnabledFields(["100"]);

                    Assert.AreEqual("1", form.CurrentRow.Fields[0].Enabled);
                    Assert.AreEqual("0", otherRow.Fields[0].Enabled);
                    break;
                case "Locked":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "200", Lock = "0" });
                    form.OtherRows.Add(otherRow);

                    form.SetLockedFields(["100"]);

                    Assert.AreEqual("1", form.CurrentRow.Fields[0].Lock);
                    Assert.AreEqual("0", otherRow.Fields[0].Lock);
                    break;
                case "Unlocked":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "200", Lock = "1" });
                    form.OtherRows.Add(otherRow);

                    form.SetUnlockedFields(["100"]);

                    Assert.AreEqual("0", form.CurrentRow.Fields[0].Lock);
                    Assert.AreEqual("1", otherRow.Fields[0].Lock);
                    break;
                case "Required":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "0" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "200", Required = "0" });
                    form.OtherRows.Add(otherRow);

                    form.SetRequiredFields(["100"]);

                    Assert.AreEqual("1", form.CurrentRow.Fields[0].Required);
                    Assert.AreEqual("0", otherRow.Fields[0].Required);
                    break;
                case "Optional":
                    form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });
                    otherRow.Fields.Add(new FieldObject { FieldNumber = "200", Required = "1" });
                    form.OtherRows.Add(otherRow);

                    form.SetOptionalFields(["100"]);

                    Assert.AreEqual("0", form.CurrentRow.Fields[0].Required);
                    Assert.AreEqual("1", otherRow.Fields[0].Required);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation));
            }

            Assert.AreEqual(RowObject.RowActions.Edit, form.CurrentRow.RowAction);
            Assert.AreEqual(string.Empty, otherRow.RowAction);
        }

        [TestMethod]
        public void GetFormId_FormObject_ReturnsFormId()
        {
            // Arrange
            var form = new FormObject { FormId = "42" };

            // Act
            var result = form.GetFormId();

            // Assert
            Assert.AreEqual("42", result);
        }

        [TestMethod]
        public void GetRowCount_FormObject_WithCurrentAndOtherRows_ReturnsCount()
        {
            // Arrange
            var form = new FormObject
            {
                CurrentRow = new RowObject { RowId = "1" },
                MultipleIteration = true
            };
            form.OtherRows.Add(new RowObject { RowId = "2" });
            form.OtherRows.Add(new RowObject { RowId = "3" });

            // Act
            var result = form.GetRowCount();

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetRowCount_FormObject_WithNoRows_ReturnsZero()
        {
            // Arrange
            var form = new FormObject { CurrentRow = null!, OtherRows = null!, MultipleIteration = true };

            // Act
            var result = form.GetRowCount();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetNextAvailableRowId_FormObject_WithGaps_ReturnsFirstAvailableRowId()
        {
            // Arrange
            var form = new FormObject
            {
                FormId = "FORM1",
                MultipleIteration = true,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };
            form.OtherRows.Add(new RowObject { RowId = "FORM1||3" });

            // Act
            var result = form.GetNextAvailableRowId();

            // Assert
            Assert.AreEqual("FORM1||2", result);
        }

        [TestMethod]
        public void GetNextAvailableRowId_FormObject_NonMultipleIterationWithCurrentRow_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var form = new FormObject
            {
                FormId = "FORM1",
                MultipleIteration = false,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };

            // Act / Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => form.GetNextAvailableRowId());
        }

        [TestMethod]
        public void GetNextAvailableRowId_FormObject_WithSparseIdsNearMaximum_ReturnsMissingInRangeId()
        {
            // Arrange
            var form = new FormObject
            {
                FormId = "FORM1",
                MultipleIteration = true,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };

            for (int i = 2; i <= 9999; i++)
            {
                if (i == 5000)
                {
                    continue;
                }

                form.OtherRows.Add(new RowObject { RowId = $"FORM1||{i}" });
            }

            // Keeps row count at previous guard threshold without occupying the missing in-range candidate.
            form.OtherRows.Add(new RowObject { RowId = "FORM1||10000" });

            // Act
            var result = form.GetNextAvailableRowId();

            // Assert
            Assert.AreEqual("FORM1||5000", result);
        }

        [TestMethod]
        public void GetNextAvailableRowId_FormObject_WithAllInRangeIdsUsed_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var form = new FormObject
            {
                FormId = "FORM1",
                MultipleIteration = true,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };

            for (int i = 2; i <= 9999; i++)
            {
                form.OtherRows.Add(new RowObject { RowId = $"FORM1||{i}" });
            }

            // Act / Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => form.GetNextAvailableRowId());
        }

        [TestMethod]
        public void AddRowObject_FormObject_DefaultOverload_SetsAddAction()
        {
            // Arrange
            var form = new FormObject { FormId = "FORM2", MultipleIteration = true };

            // Act
            form.AddRowObject();

            // Assert
            Assert.IsNotNull(form.CurrentRow);
            Assert.AreEqual("FORM2||1", form.CurrentRow.RowId);
            Assert.AreEqual(RowObject.RowActions.Add, form.CurrentRow.RowAction);
        }

        [TestMethod]
        public void AddRowObject_FormObject_WithRowIdParentRowIdOverload_AssignsProvidedValues()
        {
            // Arrange
            var form = new FormObject { FormId = "FORM3", MultipleIteration = true };

            // Act
            form.AddRowObject("FORM3||10", "PARENT1");

            // Assert
            Assert.IsNotNull(form.CurrentRow);
            Assert.AreEqual("FORM3||10", form.CurrentRow.RowId);
            Assert.AreEqual("PARENT1", form.CurrentRow.ParentRowId);
            Assert.AreEqual(RowObject.RowActions.Add, form.CurrentRow.RowAction);
        }

        [TestMethod]
        public void AddRowObjectWithParentRowId_FormObject_AssignsParentAndAddAction()
        {
            // Arrange
            var form = new FormObject { FormId = "FORM4", MultipleIteration = true };

            // Act
            form.AddRowObjectWithParentRowId("PARENT2");

            // Assert
            Assert.IsNotNull(form.CurrentRow);
            Assert.AreEqual("PARENT2", form.CurrentRow.ParentRowId);
            Assert.AreEqual(RowObject.RowActions.Add, form.CurrentRow.RowAction);
        }

        [TestMethod]
        public void AddRowObject_FormObject_WithNullFormObject_ThrowsArgumentNullException()
        {
            // Arrange
            FormObject form = null!;

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => FormObjectHelpers.AddRowObject(form, new RowObject()));
        }

        [TestMethod]
        public void AddRowObject_FormObject_WithNullRowObject_ThrowsArgumentNullException()
        {
            // Arrange
            var form = new FormObject { FormId = "FORM5", MultipleIteration = true };

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => form.AddRowObject((RowObject)null!));
        }

        [TestMethod]
        public void AddRowObject_FormObject_WithNullOtherRows_InitializesAndAddsRow()
        {
            // Arrange
            var form = new FormObject
            {
                FormId = "FORM6",
                MultipleIteration = true,
                CurrentRow = new RowObject { RowId = "FORM6||1" },
                OtherRows = null!
            };

            // Act
            form.AddRowObject(new RowObject { RowAction = RowObject.RowActions.Add });

            // Assert
            Assert.IsNotNull(form.OtherRows);
            Assert.AreEqual(1, form.OtherRows.Count);
            Assert.AreEqual("FORM6||2", form.OtherRows[0].RowId);
        }

        [TestMethod]
        public void AddRowObject_FormObject_WithCurrentRow_AddsOtherRowWithGeneratedId()
        {
            // Arrange
            var form = new FormObject
            {
                FormId = "FORM1",
                MultipleIteration = true,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };

            // Act
            form.AddRowObject(new RowObject { RowAction = RowObject.RowActions.Add });

            // Assert
            Assert.AreEqual(1, form.OtherRows.Count);
            Assert.AreEqual("FORM1||2", form.OtherRows[0].RowId);
            Assert.AreEqual(RowObject.RowActions.Add, form.OtherRows[0].RowAction);
        }

        [TestMethod]
        public void AddRowObject_FormObject_WithNoCurrentRow_SetsCurrentRowAndGeneratedId()
        {
            // Arrange
            var form = new FormObject { FormId = "FORM2", MultipleIteration = true };

            // Act
            form.AddRowObject(new RowObject { RowAction = RowObject.RowActions.Add });

            // Assert
            Assert.IsNotNull(form.CurrentRow);
            Assert.AreEqual("FORM2||1", form.CurrentRow.RowId);
            Assert.AreEqual(RowObject.RowActions.Add, form.CurrentRow.RowAction);
        }

        [TestMethod]
        public void AddRowObject_FormObject_WithNoCurrentRowAndDuplicateOtherRowId_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject
            {
                FormId = "FORM2",
                MultipleIteration = true,
                CurrentRow = null!
            };
            form.OtherRows.Add(new RowObject { RowId = "FORM2||5" });

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => form.AddRowObject(new RowObject { RowId = "FORM2||5", RowAction = RowObject.RowActions.Add }));
        }

        [TestMethod]
        public void AddRowObject_FormObject_WithDuplicateRowId_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject
            {
                FormId = "FORM1",
                MultipleIteration = true,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => form.AddRowObject(new RowObject { RowId = "FORM1||1" }));
        }

        [TestMethod]
        public void AddRowObject_FormObject_NonMultipleIterationWithCurrentRow_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject
            {
                FormId = "FORM1",
                MultipleIteration = false,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => form.AddRowObject());
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_WithCurrentRow_MarksDelete()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "FORM1||1", RowAction = RowObject.RowActions.None } };

            // Act
            form.DeleteRowObject("FORM1||1");

            // Assert
            Assert.AreEqual(RowObject.RowActions.Delete, form.CurrentRow.RowAction);
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_WithOtherRow_MarksDelete()
        {
            // Arrange
            var form = new FormObject
            {
                MultipleIteration = true,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };
            form.OtherRows.Add(new RowObject { RowId = "FORM1||2", RowAction = RowObject.RowActions.None });

            // Act
            form.DeleteRowObject("FORM1||2");

            // Assert
            Assert.AreEqual(RowObject.RowActions.Delete, form.OtherRows[0].RowAction);
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_WithOtherRowAndNonMultipleIteration_MarksDelete()
        {
            // Arrange
            var form = new FormObject
            {
                MultipleIteration = false,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };
            form.OtherRows.Add(new RowObject { RowId = "FORM1||2", RowAction = RowObject.RowActions.None });

            // Act
            form.DeleteRowObject("FORM1||2");

            // Assert
            Assert.AreEqual(RowObject.RowActions.Delete, form.OtherRows[0].RowAction);
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_WithMissingRow_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject
            {
                MultipleIteration = true,
                CurrentRow = new RowObject { RowId = "FORM1||1" }
            };

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => form.DeleteRowObject("MISSING"));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_WithNullRowObject_ThrowsArgumentNullException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "FORM1||1" } };

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => form.DeleteRowObject((RowObject)null!));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_WithEmptyRowId_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "FORM1||1" } };

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => form.DeleteRowObject(string.Empty));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_WithNullFormObject_ThrowsArgumentNullException()
        {
            // Arrange
            FormObject form = null!;

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => FormObjectHelpers.DeleteRowObject(form, "FORM1||1"));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_WithRowObject_DelegatesToRowIdDelete()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "FORM1||1", RowAction = RowObject.RowActions.None } };

            // Act
            form.DeleteRowObject(new RowObject { RowId = "FORM1||1" });

            // Assert
            Assert.AreEqual(RowObject.RowActions.Delete, form.CurrentRow.RowAction);
        }

        [TestMethod]
        public void IsRowPresent_FormObject_WithCurrentRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };

            // Act
            var result = form.IsRowPresent("1");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRowPresent_FormObject_WithOtherRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.OtherRows.Add(new RowObject { RowId = "2" });

            // Act
            var result = form.IsRowPresent("2");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRowPresent_FormObject_WithOtherRowAndNoCurrentRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = null!, MultipleIteration = true };
            form.OtherRows.Add(new RowObject { RowId = "2" });

            // Act
            var result = form.IsRowPresent("2");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRowPresent_FormObject_WithAbsentRow_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };

            // Act
            var result = form.IsRowPresent("999");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_WithDeletedRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "DELETE" } };

            // Act
            var result = form.IsRowMarkedForDeletion("1");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_WithNormalRow_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "EDIT" } };

            // Act
            var result = form.IsRowMarkedForDeletion("1");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFieldPresent_FormObject_InCurrentRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100" });

            // Act
            var result = form.IsFieldPresent("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldEnabled_FormObject_WithEnabledField_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            var result = form.IsFieldEnabled("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldLocked_FormObject_WithLockedField_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            var result = form.IsFieldLocked("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldRequired_FormObject_WithRequiredField_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });

            // Act
            var result = form.IsFieldRequired("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetFieldValue_FormObject_FromCurrentRow_ReturnsValue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });

            // Act
            var result = form.GetFieldValue("100");

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValue_FormObject_WithRowIdAndFieldNumber_ReturnsValue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });

            // Act
            var result = form.GetFieldValue("1", "100");

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValueFromOtherRows_FormObject_WithRowIdAndFieldNumber_ReturnsValue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "OtherValue" });
            form.OtherRows.Add(otherRow);

            // Act
            var result = form.GetFieldValue("2", "100");

            // Assert
            Assert.AreEqual("OtherValue", result);
        }

        [TestMethod]
        public void GetFieldValues_FormObject_ReturnsAllValues()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value1" });
            
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value2" });
            form.OtherRows.Add(otherRow);

            // Act
            var result = form.GetFieldValues("100");

            // Assert
            Assert.AreEqual(2, result.Count);
            CollectionAssert.Contains(result, "Value1");
            CollectionAssert.Contains(result, "Value2");
        }

        [TestMethod]
        public void SetFieldValue_FormObject_InCurrentRow_UpdatesValue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "OldValue" });

            // Act
            form.SetFieldValue("100", "NewValue");

            // Assert
            Assert.AreEqual("NewValue", form.CurrentRow.Fields[0].FieldValue);
        }

        [TestMethod]
        public void SetFieldValue_FormObject_WithRowId_UpdatesValueInSpecificRow()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value1" });
            
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value2" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetFieldValue("2", "100", "NewValue");

            // Assert
            Assert.AreEqual("Value1", form.CurrentRow.Fields[0].FieldValue);
            Assert.AreEqual("NewValue", otherRow.Fields[0].FieldValue);
        }

        [TestMethod]
        public void SetDisabledField_FormObject_WithMultipleIteration_DisablesFieldInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            var otherRow = new RowObject { RowId = "2", RowAction = "" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("0", otherRow.Fields[0].Enabled);
            Assert.AreEqual("EDIT", form.CurrentRow.RowAction);
            Assert.AreEqual("EDIT", otherRow.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_FormObject_WithMultipleIteration_EnablesMatchingFieldsInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetEnabledFields(new List<string> { "100" });

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("1", otherRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_FormObject_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act/Assert
            Assert.ThrowsException<ArgumentException>(() => form.SetDisabledField(string.Empty));
        }

        [TestMethod]
        public void SetEnabledFields_FormObject_WithNullFieldNumbers_ThrowsArgumentNullException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act/Assert
            Assert.ThrowsException<ArgumentNullException>(() => form.SetEnabledFields(null));
        }

        [TestMethod]
        public void SetDisabledField_FormObject_WithNullCurrentRow_ReturnsOriginalForm()
        {
            // Arrange
            var form = new FormObject { CurrentRow = null! };

            // Act
            var result = form.SetDisabledField("100");

            // Assert
            Assert.AreSame(form, result);
        }

        [TestMethod]
        public void SetEnabledField_FormObject_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act/Assert
            Assert.ThrowsException<ArgumentException>(() => form.SetEnabledField(string.Empty));
        }

        [TestMethod]
        public void SetDisabledFields_FormObject_WithMultipleIterationFalse_DoesNotModifyOtherRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = false };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetDisabledFields(["100"]);

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("1", otherRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetLockedField_FormObject_WithMultipleIteration_LocksFieldInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            var otherRow = new RowObject { RowId = "2", RowAction = "" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetLockedField("100");

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("1", otherRow.Fields[0].Lock);
            Assert.AreEqual("EDIT", form.CurrentRow.RowAction);
            Assert.AreEqual("EDIT", otherRow.RowAction);
        }

        [TestMethod]
        public void SetUnlockedFields_FormObject_WithMultipleIteration_UnlocksMatchingFieldsInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "1" });
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            otherRow.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetUnlockedFields(["101"]);

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("0", form.CurrentRow.Fields[1].Lock);
            Assert.AreEqual("1", otherRow.Fields[0].Lock);
            Assert.AreEqual("0", otherRow.Fields[1].Lock);
        }

        [TestMethod]
        public void SetRequiredField_FormObject_WithMultipleIteration_SetsFieldRequiredInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "0" });
            var otherRow = new RowObject { RowId = "2", RowAction = string.Empty };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "0" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetRequiredField("100");

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Required);
            Assert.AreEqual("1", otherRow.Fields[0].Required);
            Assert.AreEqual(RowObject.RowActions.Edit, form.CurrentRow.RowAction);
            Assert.AreEqual(RowObject.RowActions.Edit, otherRow.RowAction);
        }

        [TestMethod]
        public void SetRequiredFields_FormObject_WithMultipleIteration_SetsMatchingFieldsInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "0" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Required = "0" });

            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "0" });
            otherRow.Fields.Add(new FieldObject { FieldNumber = "101", Required = "0" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetRequiredFields(["101"]);

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Required);
            Assert.AreEqual("1", form.CurrentRow.Fields[1].Required);
            Assert.AreEqual("0", otherRow.Fields[0].Required);
            Assert.AreEqual("1", otherRow.Fields[1].Required);
        }

        [TestMethod]
        public void SetRequiredFields_FormObject_WithNoMatchingFields_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Required = "0" });

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => form.SetRequiredFields(["100"]));
        }

        [TestMethod]
        public void SetRequiredFields_FormObject_WithNullCurrentRow_ReturnsOriginalForm()
        {
            // Arrange
            var form = new FormObject { CurrentRow = null! };

            // Act
            var result = form.SetRequiredFields(["100"]);

            // Assert
            Assert.AreSame(form, result);
        }

        [TestMethod]
        public void SetRequiredFields_FormObject_WithMultipleIterationFalse_DoesNotModifyOtherRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = false };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "0" });

            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "0" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetRequiredFields(["100"]);

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Required);
            Assert.AreEqual("0", otherRow.Fields[0].Required);
        }

        [TestMethod]
        public void SetOptionalFields_FormObject_WithMultipleIteration_SetsMatchingFieldsOptionalInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Required = "1" });
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });
            otherRow.Fields.Add(new FieldObject { FieldNumber = "101", Required = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetOptionalFields(["101"]);

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Required);
            Assert.AreEqual("0", form.CurrentRow.Fields[1].Required);
            Assert.AreEqual("1", otherRow.Fields[0].Required);
            Assert.AreEqual("0", otherRow.Fields[1].Required);
        }

        [TestMethod]
        public void SetOptionalField_FormObject_WithMultipleIteration_SetsOptionalInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });
            var otherRow = new RowObject { RowId = "2", RowAction = string.Empty };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetOptionalField("100");

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Required);
            Assert.AreEqual("0", otherRow.Fields[0].Required);
            Assert.AreEqual(RowObject.RowActions.Edit, form.CurrentRow.RowAction);
            Assert.AreEqual(RowObject.RowActions.Edit, otherRow.RowAction);
        }

        [TestMethod]
        public void SetLockedField_FormObject_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => form.SetLockedField(string.Empty));
        }

        [TestMethod]
        public void SetUnlockedField_FormObject_WithNullCurrentRow_ReturnsOriginalForm()
        {
            // Arrange
            var form = new FormObject { CurrentRow = null! };

            // Act
            var result = form.SetUnlockedField("100");

            // Assert
            Assert.AreSame(form, result);
        }

        [TestMethod]
        public void SetLockedFields_FormObject_WithNullFieldNumbers_ThrowsArgumentNullException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => form.SetLockedFields(null));
        }

        [TestMethod]
        public void SetUnlockedFields_FormObject_WithMultipleIterationFalse_DoesNotModifyOtherRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = false };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetUnlockedFields(["100"]);

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("1", otherRow.Fields[0].Lock);
        }

        [TestMethod]
        public void SetLockedFields_FormObject_WithDuplicateFieldNumbers_LocksFieldInCurrentAndOtherRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            var otherRow = new RowObject { RowId = "2", RowAction = "" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetLockedFields(["100", "100"]);

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("1", otherRow.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, form.CurrentRow.RowAction);
            Assert.AreEqual(RowObject.RowActions.Edit, otherRow.RowAction);
        }
    }

}
