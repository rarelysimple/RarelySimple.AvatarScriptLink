using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class GetMultipleIterationStatusTests
    {
        [TestMethod]
        public void GetMultipleIterationStatusOptionObjectReturnsBool()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected.GetType(), optionObject.GetMultipleIterationStatus("1").GetType());
        }

        [TestMethod]
        public void GetMultipleIterationStatusOptionObjectReturnsFalse()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusOptionObjectReturnsTrue()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusOptionObjectMissingFormReturnsError()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusOptionObjectNoFormsReturnsError()
        {
            OptionObject optionObject = new();
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetMultipleIterationStatusOptionObjectNullReturnsError()
        {
            OptionObject optionObject = null;
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusHelperOptionObjectReturnsBool()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1").GetType());
        }

        [TestMethod]
        public void GetMultipleIterationStatusHelperOptionObjectReturnsFalse()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusHelperOptionObjectReturnsTrue()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusHelperOptionObjectMissingFormReturnsError()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusHelperOptionObjectNoFormsReturnsError()
        {
            OptionObject optionObject = new();
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetMultipleIterationStatusHelperOptionObjectNullReturnsError()
        {
            OptionObject optionObject = null;
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusOptionObject2ReturnsBool()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected.GetType(), optionObject.GetMultipleIterationStatus("1").GetType());
        }

        [TestMethod]
        public void GetMultipleIterationStatusOptionObject2ReturnsFalse()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusOptionObject2ReturnsTrue()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusOptionObject2MissingFormReturnsError()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusOptionObject2NoFormsReturnsError()
        {
            OptionObject2 optionObject = new();
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetMultipleIterationStatusOptionObject2NullReturnsError()
        {
            OptionObject2 optionObject = null;
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusHelperOptionObject2ReturnsBool()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1").GetType());
        }

        [TestMethod]
        public void GetMultipleIterationStatusHelperOptionObject2ReturnsFalse()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusHelperOptionObject2ReturnsTrue()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusHelperOptionObject2MissingFormReturnsError()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusHelperOptionObject2NoFormsReturnsError()
        {
            OptionObject2 optionObject = new();
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetMultipleIterationStatusHelperOptionObject2NullReturnsError()
        {
            OptionObject2 optionObject = null;
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusOptionObject2015ReturnsBool()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected.GetType(), optionObject.GetMultipleIterationStatus("1").GetType());
        }

        [TestMethod]
        public void GetMultipleIterationStatusOptionObject2015ReturnsFalse()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusOptionObject2015ReturnsTrue()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusOptionObject2015MissingFormReturnsError()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusOptionObject2015NoFormsReturnsError()
        {
            OptionObject2015 optionObject = new();
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetMultipleIterationStatusOptionObject2015NullReturnsError()
        {
            OptionObject2015 optionObject = null;
            bool expected = true;
            Assert.AreEqual(expected, optionObject.GetMultipleIterationStatus("1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusHelperOptionObject2015ReturnsBool()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1").GetType());
        }

        [TestMethod]
        public void GetMultipleIterationStatusHelperOptionObject2015ReturnsFalse()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = false;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        public void GetMultipleIterationStatusHelperOptionObject2015ReturnsTrue()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusHelperOptionObject2015MissingFormReturnsError()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(formObject);
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMultipleIterationStatusHelperOptionObject2015NoFormsReturnsError()
        {
            OptionObject2015 optionObject = new();
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetMultipleIterationStatusHelperOptionObject2015NullReturnsError()
        {
            OptionObject2015 optionObject = null;
            bool expected = true;
            Assert.AreEqual(expected, OptionObjectHelpers.GetMultipleIterationStatus(optionObject, "1"));
        }
    }
}
