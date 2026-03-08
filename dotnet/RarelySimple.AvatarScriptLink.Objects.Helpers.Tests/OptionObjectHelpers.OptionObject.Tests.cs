namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{
    /// <summary>
    /// Tests for OptionObject helper extension methods.
    /// </summary>
    [TestClass]
    public class OptionObjectHelpersOptionObjectTests
    {
        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        public void SetField_OptionObject_WithNullFieldNumber_ThrowsArgumentNullException(string operation)
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });
            optionObject.Forms.Add(form);

            Action act = operation switch
            {
                "Disabled" => () => optionObject.SetDisabledField(null!),
                "Enabled" => () => optionObject.SetEnabledField(null!),
                "Locked" => () => optionObject.SetLockedField(null!),
                "Unlocked" => () => optionObject.SetUnlockedField(null!),
                _ => throw new ArgumentOutOfRangeException(nameof(operation))
            };

            Assert.ThrowsException<ArgumentNullException>(act);
        }

        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        public void SetField_OptionObject_WithEmptyFieldNumber_ThrowsArgumentException(string operation)
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });
            optionObject.Forms.Add(form);

            Action act = operation switch
            {
                "Disabled" => () => optionObject.SetDisabledField(string.Empty),
                "Enabled" => () => optionObject.SetEnabledField(string.Empty),
                "Locked" => () => optionObject.SetLockedField(string.Empty),
                "Unlocked" => () => optionObject.SetUnlockedField(string.Empty),
                _ => throw new ArgumentOutOfRangeException(nameof(operation))
            };

            Assert.ThrowsException<ArgumentException>(act);
        }

        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        public void SetFields_OptionObject_WithMixedFormMatches_OnlyAppliesToMatchingForms(string operation)
        {
            var optionObject = new OptionObject();
            var matchingForm = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty } };
            var nonMatchingForm = new FormObject { FormId = "2", CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty } };

            switch (operation)
            {
                case "Disabled":
                    matchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
                    nonMatchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Enabled = "1" });
                    optionObject.Forms.Add(matchingForm);
                    optionObject.Forms.Add(nonMatchingForm);

                    optionObject.SetDisabledFields(new List<string> { "100" });

                    Assert.AreEqual("0", matchingForm.CurrentRow.Fields[0].Enabled);
                    Assert.AreEqual("1", nonMatchingForm.CurrentRow.Fields[0].Enabled);
                    break;
                case "Enabled":
                    matchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
                    nonMatchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Enabled = "0" });
                    optionObject.Forms.Add(matchingForm);
                    optionObject.Forms.Add(nonMatchingForm);

                    optionObject.SetEnabledFields(new List<string> { "100" });

                    Assert.AreEqual("1", matchingForm.CurrentRow.Fields[0].Enabled);
                    Assert.AreEqual("0", nonMatchingForm.CurrentRow.Fields[0].Enabled);
                    break;
                case "Locked":
                    matchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
                    nonMatchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Lock = "0" });
                    optionObject.Forms.Add(matchingForm);
                    optionObject.Forms.Add(nonMatchingForm);

                    optionObject.SetLockedFields(new List<string> { "100" });

                    Assert.AreEqual("1", matchingForm.CurrentRow.Fields[0].Lock);
                    Assert.AreEqual("0", nonMatchingForm.CurrentRow.Fields[0].Lock);
                    break;
                case "Unlocked":
                    matchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
                    nonMatchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Lock = "1" });
                    optionObject.Forms.Add(matchingForm);
                    optionObject.Forms.Add(nonMatchingForm);

                    optionObject.SetUnlockedFields(new List<string> { "100" });

                    Assert.AreEqual("0", matchingForm.CurrentRow.Fields[0].Lock);
                    Assert.AreEqual("1", nonMatchingForm.CurrentRow.Fields[0].Lock);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation));
            }

            Assert.AreEqual(RowObject.RowActions.Edit, matchingForm.CurrentRow.RowAction);
            Assert.AreEqual(string.Empty, nonMatchingForm.CurrentRow.RowAction);
        }

        [TestMethod]
        public void GetCurrentRowId_OptionObject_ReturnsCurrentRowId()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "100" } };
            optionObject.Forms.Add(form);

            var result = optionObject.GetCurrentRowId("1");

            Assert.AreEqual("100", result);
        }

        [TestMethod]
        public void GetCurrentRowId_OptionObject_WithNonExistentForm_ReturnsNull()
        {
            var optionObject = new OptionObject();

            var result = optionObject.GetCurrentRowId("999");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetParentRowId_OptionObject_ReturnsParentRowId()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { ParentRowId = "200" } };
            optionObject.Forms.Add(form);

            var result = optionObject.GetParentRowId("1");

            Assert.AreEqual("200", result);
        }

        [TestMethod]
        public void GetFieldValue_OptionObject_FromAnyForm_ReturnsValue()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });
            optionObject.Forms.Add(form);

            var result = optionObject.GetFieldValue("100");

            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValue_OptionObject_WithFormIdRowIdFieldNumber_ReturnsValue()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });
            optionObject.Forms.Add(form);

            var result = optionObject.GetFieldValue("1", "1", "100");

            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValues_OptionObject_ReturnsAllValues()
        {
            var optionObject = new OptionObject();
            var form1 = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form1.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value1" });
            optionObject.Forms.Add(form1);

            var form2 = new FormObject { FormId = "2", CurrentRow = new RowObject { RowId = "2" } };
            form2.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value2" });
            optionObject.Forms.Add(form2);

            var result = optionObject.GetFieldValues("100");

            Assert.AreEqual(2, result.Count);
            CollectionAssert.Contains(result, "Value1");
            CollectionAssert.Contains(result, "Value2");
        }

        [TestMethod]
        public void GetMultipleIterationStatus_OptionObject_ReturnsStatus()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject(), MultipleIteration = true };
            optionObject.Forms.Add(form);

            var result = optionObject.GetMultipleIterationStatus("1");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldPresent_OptionObject_InAnyForm_ReturnsTrue()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100" });
            optionObject.Forms.Add(form);

            var result = optionObject.IsFieldPresent("100");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldEnabled_OptionObject_InAnyForm_ReturnsTrue()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            var result = optionObject.IsFieldEnabled("100");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject_InAnyForm_ReturnsTrue()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            optionObject.Forms.Add(form);

            var result = optionObject.IsFieldLocked("100");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject_InAnyForm_ReturnsTrue()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });
            optionObject.Forms.Add(form);

            var result = optionObject.IsFieldRequired("100");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetErrorCode_OptionObject_ReturnsErrorCode()
        {
            var optionObject = new OptionObject { ErrorCode = 1.0 };

            var result = optionObject.GetErrorCode();

            Assert.AreEqual(1.0, result);
        }

        [TestMethod]
        public void GetErrorMessage_OptionObject_ReturnsErrorMessage()
        {
            var optionObject = new OptionObject { ErrorMesg = "Test Error" };

            var result = optionObject.GetErrorMessage();

            Assert.AreEqual("Test Error", result);
        }

        [TestMethod]
        public void GetEntityId_OptionObject_ReturnsEntityId()
        {
            var optionObject = new OptionObject { EntityID = "12345" };

            var result = optionObject.GetEntityId();

            Assert.AreEqual("12345", result);
        }

        [TestMethod]
        public void GetFormCount_OptionObject_ReturnsFormCount()
        {
            var optionObject = new OptionObject();
            optionObject.Forms.Add(new FormObject { FormId = "1" });
            optionObject.Forms.Add(new FormObject { FormId = "2" });

            var result = optionObject.GetFormCount();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void HasError_OptionObject_WithNonZeroErrorCode_ReturnsTrue()
        {
            var optionObject = new OptionObject { ErrorCode = 1.0 };

            var result = optionObject.HasError();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasError_OptionObject_WithZeroErrorCode_ReturnsFalse()
        {
            var optionObject = new OptionObject { ErrorCode = 0.0 };

            var result = optionObject.HasError();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject_DisablesTargetField()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            optionObject.SetDisabledField("100");

            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("EDIT", optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject_EnablesMatchingFields()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetEnabledFields(new List<string> { "101" });

            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject_WithFieldObjects_DisablesMatchingFields()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });
            optionObject.Forms.Add(form);

            var fieldsToDisable = new List<FieldObject> { new FieldObject { FieldNumber = "101" } };

            optionObject.SetDisabledFields(fieldsToDisable);

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetDisabledField(string.Empty));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject_WithNoMatchingField_ThrowsArgumentException()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Enabled = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetEnabledField("100"));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject_WithNullFieldObjects_ThrowsArgumentNullException()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentNullException>(() => optionObject.SetDisabledFields((List<FieldObject>?)null));
        }

        [TestMethod]
        public void SetDisabledField_OptionObject_WithNullOptionObject_ReturnsNull()
        {
            var result = OptionObjectHelpers.SetDisabledField(null!, "100");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetEnabledField_OptionObject_WithNullForms_ReturnsOriginalObject()
        {
            var optionObject = new OptionObject { Forms = null! };

            var result = optionObject.SetEnabledField("100");

            Assert.AreSame(optionObject, result);
        }

        [TestMethod]
        public void SetLockedField_OptionObject_LocksTargetField()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetLockedField("100");

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Lock);
            Assert.AreEqual("EDIT", optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject_WithFieldObjects_EnablesMatchingFields()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });
            optionObject.Forms.Add(form);
            var fieldsToEnable = new List<FieldObject> { new FieldObject { FieldNumber = "100" } };

            optionObject.SetEnabledFields(fieldsToEnable);

            Assert.AreEqual("1", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("0", form.CurrentRow.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject_WithFieldNumbers_UnlocksMatchingFields()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "1" });
            optionObject.Forms.Add(form);

            optionObject.SetUnlockedFields(new List<string> { "101" });

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Lock);
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[1].Lock);
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject_WithFieldObjects_UnlocksMatchingFields()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "1" });
            optionObject.Forms.Add(form);
            var fieldsToUnlock = new List<FieldObject> { new FieldObject { FieldNumber = "100" } };

            optionObject.SetUnlockedFields(fieldsToUnlock);

            Assert.AreEqual("0", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("1", form.CurrentRow.Fields[1].Lock);
        }

        [TestMethod]
        public void SetLockedFields_OptionObject_WithNullFieldObjects_ThrowsArgumentNullException()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentNullException>(() => optionObject.SetLockedFields((List<FieldObject>?)null));
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject_WithNullForms_ReturnsOriginalObject()
        {
            var optionObject = new OptionObject { Forms = null! };

            var result = optionObject.SetUnlockedField("100");

            Assert.AreSame(optionObject, result);
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject_WithNoMatchingField_ThrowsArgumentException()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Lock = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetUnlockedField("100"));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject_WithDuplicateFieldNumbers_LocksTargetField()
        {
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetLockedFields(new List<string> { "100", "100" });

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, optionObject.Forms[0].CurrentRow.RowAction);
        }
    }
}
