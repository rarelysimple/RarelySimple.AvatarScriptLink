using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsFormPresentTests
    {
        [TestMethod]
        public void IsFormPresent_OptionObject_FirstForm_IsPresent()
        {
            string formNumber = "1";
            FormObject formObject = new(formNumber);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFormPresent(formNumber));
        }

        [TestMethod]
        public void IsFormPresent_OptionObject_SecondForm_IsPresent()
        {
            string formNumber = "2";
            FormObject formObject1 = new("1");
            FormObject formObject2 = new(formNumber);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFormPresent(formNumber));
        }

        [TestMethod]
        public void IsFormPresent_OptionObject_IsNotPresent()
        {
            string formNumber = "1";
            FormObject formObject = new(formNumber);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFormPresent("2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFormPresent_OptionObject_NullFormId()
        {
            string formNumber = "1";
            FormObject formObject = new(formNumber);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFormPresent(null));
        }

        [TestMethod]
        public void IsFormPresent_OptionObject_NoForms()
        {
            string formNumber = "1";
            OptionObject optionObject = new();
            Assert.IsFalse(optionObject.IsFormPresent(formNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFormPresent_OptionObject_Helper_Null()
        {
            string formNumber = "1";
            Assert.IsFalse(OptionObjectHelpers.IsFormPresent(null, formNumber));
        }

        [TestMethod]
        public void IsFormPresent_OptionObject2_FirstForm_IsPresent()
        {
            string formNumber = "1";
            FormObject formObject = new(formNumber);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFormPresent(formNumber));
        }

        [TestMethod]
        public void IsFormPresent_OptionObject2_SecondForm_IsPresent()
        {
            string formNumber = "2";
            FormObject formObject1 = new("1");
            FormObject formObject2 = new(formNumber);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFormPresent(formNumber));
        }

        [TestMethod]
        public void IsFormPresent_OptionObject2_IsNotPresent()
        {
            string formNumber = "1";
            FormObject formObject = new(formNumber);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFormPresent("2"));
        }

        [TestMethod]
        public void IsFormPresent_OptionObject2015_FirstForm_IsPresent()
        {
            string formNumber = "1";
            FormObject formObject = new(formNumber);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFormPresent(formNumber));
        }

        [TestMethod]
        public void IsFormPresent_OptionObject2015_SecondForm_IsPresent()
        {
            string formNumber = "2";
            FormObject formObject1 = new("1");
            FormObject formObject2 = new(formNumber);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFormPresent(formNumber));
        }

        [TestMethod]
        public void IsFormPresent_OptionObject2015_IsNotPresent()
        {
            string formNumber = "1";
            FormObject formObject = new(formNumber);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFormPresent("2"));
        }
    }
}
