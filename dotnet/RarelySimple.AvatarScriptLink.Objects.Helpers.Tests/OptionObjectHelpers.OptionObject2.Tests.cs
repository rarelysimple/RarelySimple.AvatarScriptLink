namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{
    /// <summary>
    /// Tests for OptionObject2 helper extension methods.
    /// </summary>
    [TestClass]
    public class OptionObjectHelpersOptionObject2Tests
    {
        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        [DataRow("Required")]
        [DataRow("Optional")]
        public void SetField_OptionObject2_WithNullFieldNumber_ThrowsArgumentNullException(string operation)
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });
            optionObject.Forms.Add(form);

            Action act = operation switch
            {
                "Disabled" => () => optionObject.SetDisabledField(null!),
                "Enabled" => () => optionObject.SetEnabledField(null!),
                "Locked" => () => optionObject.SetLockedField(null!),
                "Unlocked" => () => optionObject.SetUnlockedField(null!),
                "Required" => () => optionObject.SetRequiredField(null!),
                "Optional" => () => optionObject.SetOptionalField(null!),
                _ => throw new ArgumentOutOfRangeException(nameof(operation))
            };

            Assert.ThrowsException<ArgumentNullException>(act);
        }

        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        [DataRow("Required")]
        [DataRow("Optional")]
        public void SetField_OptionObject2_WithEmptyFieldNumber_ThrowsArgumentException(string operation)
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });
            optionObject.Forms.Add(form);

            Action act = operation switch
            {
                "Disabled" => () => optionObject.SetDisabledField(string.Empty),
                "Enabled" => () => optionObject.SetEnabledField(string.Empty),
                "Locked" => () => optionObject.SetLockedField(string.Empty),
                "Unlocked" => () => optionObject.SetUnlockedField(string.Empty),
                "Required" => () => optionObject.SetRequiredField(string.Empty),
                "Optional" => () => optionObject.SetOptionalField(string.Empty),
                _ => throw new ArgumentOutOfRangeException(nameof(operation))
            };

            Assert.ThrowsException<ArgumentException>(act);
        }

        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        [DataRow("Required")]
        [DataRow("Optional")]
        public void SetFields_OptionObject2_WithMixedFormMatches_OnlyAppliesToMatchingForms(string operation)
        {
            var optionObject = new OptionObject2();
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
                case "Required":
                    matchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "0" });
                    nonMatchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Required = "0" });
                    optionObject.Forms.Add(matchingForm);
                    optionObject.Forms.Add(nonMatchingForm);

                    optionObject.SetRequiredFields(new List<string> { "100" });

                    Assert.AreEqual("1", matchingForm.CurrentRow.Fields[0].Required);
                    Assert.AreEqual("0", nonMatchingForm.CurrentRow.Fields[0].Required);
                    break;
                case "Optional":
                    matchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });
                    nonMatchingForm.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Required = "1" });
                    optionObject.Forms.Add(matchingForm);
                    optionObject.Forms.Add(nonMatchingForm);

                    optionObject.SetOptionalFields(new List<string> { "100" });

                    Assert.AreEqual("0", matchingForm.CurrentRow.Fields[0].Required);
                    Assert.AreEqual("1", nonMatchingForm.CurrentRow.Fields[0].Required);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation));
            }

            Assert.AreEqual(RowObject.RowActions.Edit, matchingForm.CurrentRow.RowAction);
            Assert.AreEqual(string.Empty, nonMatchingForm.CurrentRow.RowAction);
        }

        [TestMethod]
        public void GetEntityId_OptionObject2_ReturnsEntityId()
        {
            var optionObject = new OptionObject2 { EntityID = "E-2" };

            var result = optionObject.GetEntityId();

            Assert.AreEqual("E-2", result);
        }

        [TestMethod]
        public void GetErrorCode_OptionObject2_ReturnsErrorCode()
        {
            var optionObject = new OptionObject2 { ErrorCode = 2.5 };

            var result = optionObject.GetErrorCode();

            Assert.AreEqual(2.5, result);
        }

        [TestMethod]
        public void GetErrorMessage_OptionObject2_ReturnsErrorMessage()
        {
            var optionObject = new OptionObject2 { ErrorMesg = "Error 2" };

            var result = optionObject.GetErrorMessage();

            Assert.AreEqual("Error 2", result);
        }

        [TestMethod]
        public void GetFormCount_OptionObject2_ReturnsFormCount()
        {
            var optionObject = new OptionObject2();
            optionObject.Forms.Add(new FormObject { FormId = "1" });
            optionObject.Forms.Add(new FormObject { FormId = "2" });

            var result = optionObject.GetFormCount();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void HasError_OptionObject2_WithZeroErrorCode_ReturnsFalse()
        {
            var optionObject = new OptionObject2 { ErrorCode = 0 };

            var result = optionObject.HasError();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2_DisablesTargetField()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            optionObject.SetDisabledField("100");

            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2_WithFieldObjects_EnablesMatchingFields()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            var fieldsToEnable = new List<FieldObject> { new FieldObject { FieldNumber = "100" } };

            optionObject.SetEnabledFields(fieldsToEnable);

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_WithFieldNumbers_DisablesMatchingFields()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });
            optionObject.Forms.Add(form);

            optionObject.SetDisabledFields(new List<string> { "101" });

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_WithEmptyFieldObjects_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetDisabledFields(new List<FieldObject>()));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetEnabledField(string.Empty));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2_WithNoMatchingField_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Enabled = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetEnabledField("100"));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2_WithNullOptionObject_ReturnsNull()
        {
            var result = OptionObject2Helpers.SetEnabledField(null!, "100");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2_WithEmptyFieldNumbers_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetEnabledFields(new List<string>()));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2_WithNullFieldObjects_ThrowsArgumentNullException()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentNullException>(() => optionObject.SetEnabledFields((List<FieldObject>?)null));
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2_WithNullForms_ReturnsOriginalObject()
        {
            var optionObject = new OptionObject2 { Forms = null! };

            var result = optionObject.SetDisabledField("100");

            Assert.AreSame(optionObject, result);
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject2_UnlocksTargetField()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            optionObject.Forms.Add(form);

            optionObject.SetUnlockedField("100");

            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Lock);
            Assert.AreEqual("EDIT", optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2_WithFieldObjects_LocksMatchingFields()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "0" });
            optionObject.Forms.Add(form);
            var fieldsToLock = new List<FieldObject> { new FieldObject { FieldNumber = "100" } };

            optionObject.SetLockedFields(fieldsToLock);

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Lock);
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[1].Lock);
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject2_WithNullOptionObject_ReturnsNull()
        {
            var result = OptionObject2Helpers.SetUnlockedField(null!, "100");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject2_WithEmptyFieldObjects_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetUnlockedFields(new List<FieldObject>()));
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2_WithDuplicateFieldNumbers_LocksTargetField()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetLockedFields(new List<string> { "100", "100" });

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetLockedField_OptionObject2_WithNoMatchingField_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Lock = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetLockedField("100"));
        }

        [TestMethod]
        public void SetRequiredField_OptionObject2_WithNoMatchingField_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Required = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetRequiredField("100"));
        }

        [TestMethod]
        public void SetOptionalField_OptionObject2_WithNoMatchingField_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Required = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetOptionalField("100"));
        }
    }
}
