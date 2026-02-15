namespace RarelySimple.AvatarScriptLink.Objects.Converters.Tests
{
    [TestClass]
    public class FieldObjectConvertersTests
    {
        [TestMethod]
        public void ToFieldObject_CopiesValues()
        {
            // Arrange
            var source = new FieldObject
            {
                FieldNumber = "100",
                FieldValue = "value",
                Enabled = "1",
                Lock = "0",
                Required = "1"
            };

            // Act
            FieldObject? result = source.ToFieldObject();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotSame(source, result);
            Assert.AreEqual(source.FieldNumber, result.FieldNumber);
            Assert.AreEqual(source.FieldValue, result.FieldValue);
            Assert.AreEqual(source.Enabled, result.Enabled);
            Assert.AreEqual(source.Lock, result.Lock);
            Assert.AreEqual(source.Required, result.Required);
        }
    }

    [TestClass]
    public class RowObjectConvertersTests
    {
        [TestMethod]
        public void ToRowObject_CopiesFields_WhenIncluded()
        {
            // Arrange
            var source = new RowObject { RowId = "1", ParentRowId = "P1", RowAction = RowObject.RowActions.Edit };
            source.Fields.Add(new FieldObject { FieldNumber = "100" });

            // Act
            RowObject? result = source.ToRowObject();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(source.RowId, result.RowId);
            Assert.AreEqual(source.ParentRowId, result.ParentRowId);
            Assert.AreEqual(source.RowAction, result.RowAction);
            Assert.AreEqual(1, result.Fields.Count);
            Assert.AreNotSame(source.Fields[0], result.Fields[0]);
        }

        [TestMethod]
        public void ToRowObject_ExcludesFields_WhenNotIncluded()
        {
            // Arrange
            var source = new RowObject { RowId = "1" };
            source.Fields.Add(new FieldObject { FieldNumber = "200" });

            // Act
            RowObject? result = source.ToRowObject(includeFields: false);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Fields.Count);
        }
    }

    [TestClass]
    public class FormObjectConvertersTests
    {
        [TestMethod]
        public void ToFormObject_CopiesRows_WhenIncluded()
        {
            // Arrange
            var source = new FormObject { FormId = "FORM1", MultipleIteration = true };
            source.CurrentRow = new RowObject { RowId = "1" };
            source.OtherRows.Add(new RowObject { RowId = "2" });

            // Act
            FormObject? result = source.ToFormObject();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(source.FormId, result.FormId);
            Assert.IsTrue(result.MultipleIteration);
            Assert.IsNotNull(result.CurrentRow);
            Assert.AreEqual(1, result.OtherRows.Count);
        }

        [TestMethod]
        public void ToFormObject_ExcludesRows_WhenNotIncluded()
        {
            // Arrange
            var source = new FormObject { FormId = "FORM2", MultipleIteration = true };
            source.CurrentRow = new RowObject { RowId = "1" };
            source.OtherRows.Add(new RowObject { RowId = "2" });

            // Act
            FormObject? result = source.ToFormObject(includeRows: false);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNull(result.CurrentRow);
            Assert.AreEqual(0, result.OtherRows.Count);
        }
    }

    [TestClass]
    public class OptionObjectConvertersTests
    {
        [TestMethod]
        public void ToOptionObject_CopiesCommonFieldsAndForms()
        {
            // Arrange
            var source = new OptionObject2
            {
                EntityID = "PATID1",
                ErrorCode = 1,
                ErrorMesg = "Error",
                Facility = "1",
                SystemCode = "LIVE",
                OptionUserId = "USER1"
            };
            source.Forms.Add(new FormObject { FormId = "FORM1" });

            // Act
            OptionObject? result = source.ToOptionObject();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(source.EntityID, result.EntityID);
            Assert.AreEqual(source.ErrorCode, result.ErrorCode);
            Assert.AreEqual(source.ErrorMesg, result.ErrorMesg);
            Assert.AreEqual(1, result.Forms.Count);
        }

        [TestMethod]
        public void ToOptionObject_ExcludesForms_WhenNotIncluded()
        {
            // Arrange
            var source = new OptionObject2 { EntityID = "PATID2" };
            source.Forms.Add(new FormObject { FormId = "FORM2" });

            // Act
            OptionObject? result = source.ToOptionObject(includeForms: false);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Forms.Count);
        }

        [TestMethod]
        public void ToOptionObject_CopiesForms_AsDeepCopy()
        {
            // Arrange
            var source = new OptionObject2 { EntityID = "PATID2" };
            var form = new FormObject { FormId = "FORM2" };
            source.Forms.Add(form);

            // Act
            OptionObject? result = source.ToOptionObject();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Forms.Count);
            Assert.AreNotSame(form, result.Forms[0]);
            Assert.AreEqual(form.FormId, result.Forms[0].FormId);
        }

        [TestMethod]
        public void ToOptionObject2_CopiesNamespaceFields_FromOptionObject2015()
        {
            // Arrange
            var source = new OptionObject2015
            {
                EntityID = "PATID3",
                NamespaceName = "NS",
                ParentNamespace = "PARENT",
                ServerName = "SERVER"
            };

            // Act
            OptionObject2? result = source.ToOptionObject2();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(source.NamespaceName, result.NamespaceName);
            Assert.AreEqual(source.ParentNamespace, result.ParentNamespace);
            Assert.AreEqual(source.ServerName, result.ServerName);
        }

        [TestMethod]
        public void ToOptionObject2_CopiesCommonFields_FromOptionObject()
        {
            // Arrange
            var source = new OptionObject
            {
                EntityID = "PATID6",
                ErrorCode = 2,
                ErrorMesg = "Error",
                Facility = "2",
                SystemCode = "UAT",
                OptionUserId = "USER6"
            };

            // Act
            OptionObject2? result = source.ToOptionObject2();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(source.EntityID, result.EntityID);
            Assert.AreEqual(source.ErrorCode, result.ErrorCode);
            Assert.AreEqual(source.ErrorMesg, result.ErrorMesg);
            Assert.AreEqual(source.Facility, result.Facility);
            Assert.AreEqual(source.SystemCode, result.SystemCode);
            Assert.AreEqual(source.OptionUserId, result.OptionUserId);
        }

        [TestMethod]
        public void ToOptionObject2015_AppliesSessionDetails_WhenProvided()
        {
            // Arrange
            var source = new OptionObject2 { EntityID = "PATID4", OptionUserId = "USER2" };

            // Act
            OptionObject2015? result = source.ToOptionObject2015(sessionToken: "TOKEN", optionUserId: "USERX");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("TOKEN", result.SessionToken);
            Assert.AreEqual("USERX", result.OptionUserId);
        }

        [TestMethod]
        public void ToOptionObject2015_DoesNotOverrideOptionUserId_WhenNull()
        {
            // Arrange
            var source = new OptionObject2 { EntityID = "PATID7", OptionUserId = "USER7" };

            // Act
            OptionObject2015? result = source.ToOptionObject2015(sessionToken: "TOKEN");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("TOKEN", result.SessionToken);
            Assert.AreEqual("USER7", result.OptionUserId);
        }

        [TestMethod]
        public void ToOptionObject2015_UsesFallbackOptionUserId_WhenNotProvided()
        {
            // Arrange
            var source = new OptionObject { EntityID = "PATID5", OptionUserId = "USER3" };

            // Act
            OptionObject2015? result = source.ToOptionObject2015();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("USER3", result.OptionUserId);
        }

        [TestMethod]
        public void ToOptionObject_ReturnsNull_WhenSourceIsNull()
        {
            // Arrange
            OptionObject2? source = null;

            // Act
            OptionObject? result = source.ToOptionObject();

            // Assert
            Assert.IsNull(result);
        }
    }
}
