using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class AddFormObjectTests
    {
        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_NullOptionObject()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddFormObject(null, formObject));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_NullFormObject()
        {
            OptionObject optionObject = new();
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddFormObject(optionObject, null));
        }
        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2_NullFormObject()
        {
            OptionObject2 optionObject = new();
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddFormObject(optionObject, null));
        }
        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2015_NullFormObject()
        {
            OptionObject2015 optionObject = new();
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddFormObject(optionObject, null));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_Duplicate()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject1);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.AddFormObject(optionObject, formObject2));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2_Duplicate()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject1);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.AddFormObject(optionObject, formObject2));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2015_Duplicate()
        {
            FormObject formObject1 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject1);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.AddFormObject(optionObject, formObject2));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_Success()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2_Success()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2015_Success()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_ByFormId()
        {
            OptionObject optionObject = new();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2_ByFormId()
        {
            OptionObject2 optionObject = new();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2015_ByFormId()
        {
            OptionObject2015 optionObject = new();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            Assert.IsTrue(optionObject.IsFormPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_MIFirstForm()
        {
            OptionObject optionObject = new();
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.AddFormObject(optionObject, "1", true));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2_MIFirstForm()
        {
            OptionObject2 optionObject = new();
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.AddFormObject(optionObject, "1", true));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2015_MIFirstForm()
        {
            OptionObject2015 optionObject = new();
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.AddFormObject(optionObject, "1", true));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject_MINotFirstForm()
        {
            OptionObject optionObject = new();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, "2", true);
            Assert.IsTrue(optionObject.IsFormPresent("2"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2_MINotFirstForm()
        {
            OptionObject2 optionObject = new();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, "2", true);
            Assert.IsTrue(optionObject.IsFormPresent("2"));
        }

        [TestMethod]
        [TestCategory("AddFormObject")]
        public void AddFormObject_ToOptionObject2015_MINotFirstForm()
        {
            OptionObject2015 optionObject = new();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, "1", false);
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, "2", true);
            Assert.IsTrue(optionObject.IsFormPresent("2"));
        }
    }
}
