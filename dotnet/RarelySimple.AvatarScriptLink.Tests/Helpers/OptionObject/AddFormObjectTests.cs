using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class AddFormObjectTests
    {
        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddFormObject_ToOptionObject_NullOptionObject()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = null;
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }
        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddFormObject_ToOptionObject2_NullOptionObject()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = null;
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }
        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddFormObject_ToOptionObject2015_NullOptionObject()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = null;
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddFormObject_ToOptionObject_NullFormObject()
        {
            OptionObject optionObject = new OptionObject();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, null);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }
        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddFormObject_ToOptionObject2_NullFormObject()
        {
            OptionObject2 optionObject = new OptionObject2();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, null);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }
        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddFormObject_ToOptionObject2015_NullFormObject()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, null);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFormObject_ToOptionObject_Duplicate()
        {
            FormObject formObject1 = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new OptionObject();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject1);
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject2);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFormObject_ToOptionObject2_Duplicate()
        {
            FormObject formObject1 = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject1);
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject2);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFormObject_ToOptionObject2015_Duplicate()
        {
            FormObject formObject1 = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject1);
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject2);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_Success()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new OptionObject();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2_Success()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2015_Success()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_ByFormId()
        {
            OptionObject optionObject = new OptionObject();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2_ByFormId()
        {
            OptionObject2 optionObject = new OptionObject2();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2015_ByFormId()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFormObject_ToOptionObject_MIFirstForm()
        {
            OptionObject optionObject = new OptionObject();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, "1", true);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFormObject_ToOptionObject2_MIFirstForm()
        {
            OptionObject2 optionObject = new OptionObject2();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, "1", true);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFormObject_ToOptionObject2015_MIFirstForm()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, "1", true);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_MINotFirstForm()
        {
            OptionObject optionObject = new OptionObject();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, "2", true);
            Assert.IsTrue(optionObject.IsFormPresent("2"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2_MINotFirstForm()
        {
            OptionObject2 optionObject = new OptionObject2();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, "2", true);
            Assert.IsTrue(optionObject.IsFormPresent("2"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2015_MINotFirstForm()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, "2", true);
            Assert.IsTrue(optionObject.IsFormPresent("2"));
        }
    }
}
