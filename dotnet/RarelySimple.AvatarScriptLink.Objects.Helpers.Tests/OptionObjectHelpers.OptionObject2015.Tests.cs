namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{
    /// <summary>
    /// Tests for OptionObject2015 helper extension methods.
    /// </summary>
    [TestClass]
    public class OptionObjectHelpersOptionObject2015Tests
    {
        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        public void SetField_OptionObject2015_WithNullFieldNumber_ThrowsArgumentNullException(string operation)
        {
            var optionObject = new OptionObject2015();
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
        public void SetField_OptionObject2015_WithEmptyFieldNumber_ThrowsArgumentException(string operation)
        {
            var optionObject = new OptionObject2015();
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
        public void SetFields_OptionObject2015_WithMixedFormMatches_OnlyAppliesToMatchingForms(string operation)
        {
            var optionObject = new OptionObject2015();
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
        public void GetEntityId_OptionObject2015_ReturnsEntityId()
        {
            var optionObject = new OptionObject2015 { EntityID = "E-2015" };

            var result = optionObject.GetEntityId();

            Assert.AreEqual("E-2015", result);
        }

        [TestMethod]
        public void GetErrorCode_OptionObject2015_ReturnsErrorCode()
        {
            var optionObject = new OptionObject2015 { ErrorCode = 3.5 };

            var result = optionObject.GetErrorCode();

            Assert.AreEqual(3.5, result);
        }

        [TestMethod]
        public void GetErrorMessage_OptionObject2015_ReturnsErrorMessage()
        {
            var optionObject = new OptionObject2015 { ErrorMesg = "Error 2015" };

            var result = optionObject.GetErrorMessage();

            Assert.AreEqual("Error 2015", result);
        }

        [TestMethod]
        public void GetFormCount_OptionObject2015_ReturnsFormCount()
        {
            var optionObject = new OptionObject2015();
            optionObject.Forms.Add(new FormObject { FormId = "1" });
            optionObject.Forms.Add(new FormObject { FormId = "2" });

            var result = optionObject.GetFormCount();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetSessionToken_OptionObject2015_ReturnsSessionToken()
        {
            var optionObject = new OptionObject2015 { SessionToken = "token-123" };

            var result = optionObject.GetSessionToken();

            Assert.AreEqual("token-123", result);
        }

        [TestMethod]
        public void GetOptionUserId_OptionObject2015_ReturnsOptionUserId()
        {
            var optionObject = new OptionObject2015 { OptionUserId = "user-01" };

            var result = optionObject.GetOptionUserId();

            Assert.AreEqual("user-01", result);
        }

        [TestMethod]
        public void HasError_OptionObject2015_WithNonZeroErrorCode_ReturnsTrue()
        {
            var optionObject = new OptionObject2015 { ErrorCode = 1 };

            var result = optionObject.HasError();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2015_EnablesTargetField()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetEnabledField("100");

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_WithFieldObjects_DisablesMatchingFields()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            var fieldsToDisable = new List<FieldObject> { new FieldObject { FieldNumber = "100" } };

            optionObject.SetDisabledFields(fieldsToDisable);

            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_WithFieldNumbers_EnablesMatchingFields()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetEnabledFields(new List<string> { "100" });

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2015_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetDisabledField(string.Empty));
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2015_WithNoMatchingField_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Enabled = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetDisabledField("100"));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_WithNullFieldObjects_ThrowsArgumentNullException()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentNullException>(() => optionObject.SetEnabledFields((List<FieldObject>?)null));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_WithEmptyFieldObjects_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetDisabledFields(new List<FieldObject>()));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_WithEmptyFieldObjects_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetEnabledFields(new List<FieldObject>()));
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2015_WithNullForms_ReturnsOriginalObject()
        {
            var optionObject = new OptionObject2015 { Forms = null! };

            var result = optionObject.SetDisabledField("100");

            Assert.AreSame(optionObject, result);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_WithNullOptionObject_ReturnsNull()
        {
            var result = OptionObject2015Helpers.SetEnabledFields(null!, new List<string> { "100" });

            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetLockedField_OptionObject2015_LocksTargetField()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetLockedField("100");

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Lock);
            Assert.AreEqual("EDIT", optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject2015_WithFieldObjects_UnlocksMatchingFields()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "1" });
            optionObject.Forms.Add(form);
            var fieldsToUnlock = new List<FieldObject> { new FieldObject { FieldNumber = "100" } };

            optionObject.SetUnlockedFields(fieldsToUnlock);

            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Lock);
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[1].Lock);
        }

        [TestMethod]
        public void SetLockedField_OptionObject2015_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetLockedField(string.Empty));
        }

        [TestMethod]
        public void SetUnlockedFields_OptionObject2015_WithNullOptionObject_ReturnsNull()
        {
            var result = OptionObject2015Helpers.SetUnlockedFields(null!, new List<string> { "100" });

            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetLockedField_OptionObject2015_WithNullForms_ReturnsOriginalObject()
        {
            var optionObject = new OptionObject2015 { Forms = null! };

            var result = optionObject.SetLockedField("100");

            Assert.AreSame(optionObject, result);
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2015_WithDuplicateFieldNumbers_LocksTargetField()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetLockedFields(new List<string> { "100", "100" });

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetLockedFields_OptionObject2015_WithFieldObjects_LocksMatchingFields()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "0" });
            optionObject.Forms.Add(form);
            var fieldsToLock = new List<FieldObject> { new FieldObject { FieldNumber = "100" } };

            optionObject.SetLockedFields(fieldsToLock);

            Assert.AreEqual("1", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("0", form.CurrentRow.Fields[1].Lock);
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject2015_WithNoMatchingField_ThrowsArgumentException()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "200", Lock = "1" });
            optionObject.Forms.Add(form);

            Assert.ThrowsException<ArgumentException>(() => optionObject.SetUnlockedField("100"));
        }
    }
}
