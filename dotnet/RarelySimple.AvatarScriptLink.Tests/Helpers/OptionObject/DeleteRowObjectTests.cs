using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class DeleteRowObjectTests
    {
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject);

            Assert.IsTrue(formObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
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
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
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
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
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
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_OptionObject_MI_RowObject_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
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
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new()
            {
                RowId = "2||4"
            };

            optionObject.DeleteRowObject(rowObject4);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject4.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject4.RowId));
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
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
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
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
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
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_OptionObject_MI_RowId_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
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
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new()
            {
                RowId = "2||4"
            };

            optionObject.DeleteRowObject(rowObject4.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject4.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject4.RowId));
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
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
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
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
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
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_OptionObject2_MI_RowObject_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
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
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new()
            {
                RowId = "2||4"
            };

            optionObject.DeleteRowObject(rowObject4);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject4.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject4.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_OptionObject2_MI_RowId_IsFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
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
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject1);

            optionObject.DeleteRowObject(rowObject1.RowId);
            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_OptionObject2_MI_RowId_IsNotFound()
        {
            RowObject rowObject = new()
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
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
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new()
            {
                RowId = "2||4"
            };

            optionObject.DeleteRowObject(rowObject4.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject4.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject4.RowId));
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
                MultipleIteration = true
            };
            formObject.CurrentRow = rowObject1;
            formObject.OtherRows.Add(rowObject2);

            formObject.DeleteRowObject(rowObject1);
            formObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(formObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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
                MultipleIteration = true
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
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
                MultipleIteration = true
            };
            formObject.CurrentRow = rowObject1;
            formObject.OtherRows.Add(rowObject2);

            formObject.DeleteRowObject(rowObject1.RowId);
            formObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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
                MultipleIteration = true
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteRowObject_OptionObject_Null()
        {
            OptionObject optionObject = null;
            optionObject.DeleteRowObject("1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteRowObject_OptionObject2_Null()
        {
            OptionObject2 optionObject = null;
            optionObject.DeleteRowObject("1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteRowObject_OptionObject2015_Null()
        {
            OptionObject2015 optionObject = null;
            optionObject.DeleteRowObject("1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteRowObject_FormObject_Null()
        {
            FormObject formObject = null;
            formObject.DeleteRowObject("1||1");
            Assert.IsFalse(formObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_OptionObject_Null_RowId_Error()
        {
            OptionObject optionObject = null;

            OptionObjectHelpers.DeleteRowObject(optionObject, "1||1");

            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_OptionObject_Null_RowObject_Error()
        {
            RowObject rowObject = new("1||1");
            OptionObject optionObject = null;

            OptionObjectHelpers.DeleteRowObject(optionObject, rowObject);

            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_OptionObject_RowObject_Null_Error()
        {
            RowObject rowObject = null;
            OptionObject optionObject = new();

            OptionObjectHelpers.DeleteRowObject(optionObject, rowObject);

            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_OptionObject2_Null_RowId_Error()
        {
            OptionObject2 optionObject = null;
            OptionObjectHelpers.DeleteRowObject(optionObject, "1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_OptionObject2_Null_RowObject_Error()
        {
            RowObject rowObject = new("1||1");
            OptionObject2 optionObject = null;

            OptionObjectHelpers.DeleteRowObject(optionObject, rowObject);

            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_OptionObject2_RowObject_Null_Error()
        {
            RowObject rowObject = null;
            OptionObject2 optionObject = new();

            OptionObjectHelpers.DeleteRowObject(optionObject, rowObject);

            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_OptionObject2015_Null_RowId_Error()
        {
            OptionObject2015 optionObject = null;
            OptionObjectHelpers.DeleteRowObject(optionObject, "1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_OptionObject2015_Null_RowObject_Error()
        {
            RowObject rowObject = new("1||1");
            OptionObject2015 optionObject = null;

            OptionObjectHelpers.DeleteRowObject(optionObject, rowObject);

            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_OptionObject2015_RowObject_Null_Error()
        {
            RowObject rowObject = null;
            OptionObject2015 optionObject = new();

            OptionObjectHelpers.DeleteRowObject(optionObject, rowObject);

            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_FormObject_Null_RowId_Error()
        {
            FormObject formObject = null;
            OptionObjectHelpers.DeleteRowObject(formObject, "1||1");
            Assert.IsFalse(formObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_FormObject_Null_RowObject_Error()
        {
            RowObject rowObject = new("1||1");
            FormObject formObject = null;

            OptionObjectHelpers.DeleteRowObject(formObject, rowObject);

            Assert.IsFalse(formObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_OptionObjectHelpers_FormObject_RowObject_Null_Error()
        {
            RowObject rowObject = null;
            FormObject formObject = new();

            OptionObjectHelpers.DeleteRowObject(formObject, rowObject);

            Assert.IsFalse(formObject.IsFieldPresent("1||1"));
        }
    }
}
