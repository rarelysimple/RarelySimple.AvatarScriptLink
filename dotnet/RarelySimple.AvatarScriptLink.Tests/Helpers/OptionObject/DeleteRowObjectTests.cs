using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class DeleteRowObjectTests
    {
        [TestMethod]
        public void DeleteRowObject_OptionObject_RowObject_IsEmpty()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            Assert.ThrowsException<ArgumentNullException>(() => optionObject.DeleteRowObject(""));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject_RowObject_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject_RowObject_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);

            Assert.ThrowsException<ArgumentException>(() => optionObject.DeleteRowObject(rowObject2));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject_RowId_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject_RowId_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);

            Assert.ThrowsException<ArgumentException>(() => optionObject.DeleteRowObject(rowObject2.RowId));
        }
        
        [TestMethod]
        public void DeleteRowObject_OptionObject2_RowObject_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject2_RowObject_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);

            Assert.ThrowsException<ArgumentException>(() => optionObject.DeleteRowObject(rowObject2));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject2_RowId_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject2_RowId_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);

            Assert.ThrowsException<ArgumentException>(() => optionObject.DeleteRowObject(rowObject2.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_RowObject_IsEmpty()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            Assert.ThrowsException<ArgumentNullException>(() => formObject.DeleteRowObject(""));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_RowObject_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };

            formObject.DeleteRowObject(rowObject);

            Assert.IsTrue(formObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_RowObject_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };

            Assert.ThrowsException<ArgumentException>(() => formObject.DeleteRowObject(rowObject2));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_RowId_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };

            formObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_RowId_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };

            Assert.ThrowsException<ArgumentException>(() => formObject.DeleteRowObject(rowObject2.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject_MI_RowObject_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            optionObject.DeleteRowObject(rowObject1);
            optionObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject_MI_RowObject_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new()
            {
                RowId = "2||4"
            };

            Assert.ThrowsException<ArgumentException>(() => optionObject.DeleteRowObject(rowObject4));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject_MI_RowId_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            optionObject.DeleteRowObject(rowObject1.RowId);
            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject_MI_RowId_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new()
            {
                RowId = "2||4"
            };

            Assert.ThrowsException<ArgumentException>(() => optionObject.DeleteRowObject(rowObject4.RowId));
        }
        [TestMethod]
        public void DeleteRowObject_OptionObject2_MI_RowObject_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            optionObject.DeleteRowObject(rowObject1.RowId);
            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject2_MI_RowObject_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new()
            {
                RowId = "2||4"
            };

            Assert.ThrowsException<ArgumentException>(() => optionObject.DeleteRowObject(rowObject4));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject2_MI_RowId_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject2.OtherRows.Add(rowObject1);
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            optionObject.DeleteRowObject(rowObject1.RowId);
            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_OptionObject2_MI_RowId_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false,
                CurrentRow = rowObject
            };
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new()
            {
                RowId = "2||4"
            };

            Assert.ThrowsException<ArgumentException>(() => optionObject.DeleteRowObject(rowObject4.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_MI_RowObject_IsFound()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject = new()
            {
                FormId = "2",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);

            formObject.DeleteRowObject(rowObject1);
            formObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(formObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_MI_RowObject_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject = new()
            {
                FormId = "2",
                MultipleIteration = true,
                CurrentRow = rowObject
            };

            Assert.ThrowsException<ArgumentException>(() => formObject.DeleteRowObject(rowObject2));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_MI_RowId_IsFound()
        {
            RowObject rowObject1 = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||1"
            };
            FormObject formObject = new()
            {
                FormId = "2",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);

            formObject.DeleteRowObject(rowObject1.RowId);
            formObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        public void DeleteRowObject_FormObject_MI_RowId_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "2||2"
            };
            FormObject formObject = new()
            {
                FormId = "2",
                MultipleIteration = true,
                CurrentRow = rowObject
            };

            Assert.ThrowsException<ArgumentException>(() => formObject.DeleteRowObject(rowObject2.RowId));
        }
    }
}
