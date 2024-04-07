using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class GetParentRowIdTests
    {
        [TestMethod]
        public void GetParentRowIdOptionObjectReturnsString()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected.GetType(), optionObject.GetParentRowId("1").GetType());
        }


        [TestMethod]
        public void GetParentRowIdHelperOptionObjectReturnsString()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.GetParentRowId(optionObject, "1").GetType());
        }


        [TestMethod]
        public void GetParentRowIdOptionObjectReturnsExpected()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected, optionObject.GetParentRowId("1"));
        }


        [TestMethod]
        public void GetParentRowIdHelperOptionObjectReturnsExpected()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetParentRowIdHelperOptionObjectReturnsNotFound()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "2||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetParentRowIdHelperOptionObjectNoCurrentRowReturnsError()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetParentRowIdHelperOptionObjectNoFormsReturnsError()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        public void GetParentRowIdOptionObject2ReturnsString()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected.GetType(), optionObject.GetParentRowId("1").GetType());
        }


        [TestMethod]
        public void GetParentRowIdHelperOptionObject2ReturnsString()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.GetParentRowId(optionObject, "1").GetType());
        }

        [TestMethod]
        public void GetParentRowIdOptionObject2ReturnsExpected()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected, optionObject.GetParentRowId("1"));
        }


        [TestMethod]
        public void GetParentRowIdHelperOptionObject2ReturnsExpected()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetParentRowIdHelperOptionObject2ReturnsNotFound()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "2||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetParentRowIdHelperOptionObject2NoCurrentRowReturnsError()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetParentRowIdHelperOptionObject2NoFormsReturnsError()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }


        [TestMethod]
        public void GetParentRowIdOptionObject2015ReturnsString()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected.GetType(), optionObject.GetParentRowId("1").GetType());
        }


        [TestMethod]
        public void GetParentRowIdHelperOptionObject2015ReturnsString()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.GetParentRowId(optionObject, "1").GetType());
        }

        [TestMethod]
        public void GetParentRowIdOptionObject2015ReturnsExpected()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected, optionObject.GetParentRowId("1"));
        }


        [TestMethod]
        public void GetParentRowIdHelperOptionObject2015ReturnsExpected()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetParentRowIdHelperOptionObject2015ReturnsNotFound()
        {
            RowObject rowObject1 = new()
            {
                RowId = "1||1",
                ParentRowId = "1||1"
            };
            RowObject rowObject2 = new()
            {
                RowId = "1||2",
                ParentRowId = "1||1"
            };
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true,
                CurrentRow = rowObject1
            };
            formObject.OtherRows.Add(rowObject2);
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "2||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetParentRowIdHelperOptionObject2015NoCurrentRowReturnsError()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add(formObject);
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetParentRowIdHelperOptionObject2015NoFormsReturnsError()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetParentRowIdHelperNullReturnsExpected()
        {
            OptionObject optionObject = null;
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetParentRowIdHelperNull2ReturnsExpected()
        {
            OptionObject2 optionObject = null;
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetParentRowIdHelperNull2015ReturnsExpected()
        {
            OptionObject2015 optionObject = null;
            string expected = "1||1";
            Assert.AreEqual(expected, OptionObjectHelpers.GetParentRowId(optionObject, "1"));
        }
    }
}
