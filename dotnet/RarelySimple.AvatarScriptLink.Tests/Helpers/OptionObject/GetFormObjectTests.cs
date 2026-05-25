using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class GetFormObjectTests
    {
        [TestMethod]
        [TestCategory("GetFormObject")]
        public void GetFormObject_FromOptionObject_Success()
        {
            var formObject = new FormObject("1");
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);

            var actual = OptionObjectHelpers.GetFormObject(optionObject, "1");

            Assert.AreSame(formObject, actual);
        }

        [TestMethod]
        [TestCategory("GetFormObject")]
        public void GetFormObject_FromOptionObject2_Success()
        {
            var formObject = new FormObject("1");
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);

            var actual = OptionObjectHelpers.GetFormObject(optionObject, "1");

            Assert.AreSame(formObject, actual);
        }

        [TestMethod]
        [TestCategory("GetFormObject")]
        public void GetFormObject_FromOptionObject2015_Success()
        {
            var formObject = new FormObject("1");
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);

            var actual = OptionObjectHelpers.GetFormObject(optionObject, "1");

            Assert.AreSame(formObject, actual);
        }

        [TestMethod]
        [TestCategory("GetFormObject")]
        public void GetFormObject_FromOptionObject_NullOptionObject_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetFormObject(null, "1"));
        }

        [TestMethod]
        [TestCategory("GetFormObject")]
        public void GetFormObject_FromOptionObject_NullFormId_ThrowsArgumentNullException()
        {
            OptionObject optionObject = new();
            optionObject.AddFormObject(new FormObject("1"));

            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetFormObject(optionObject, null));
        }

        [TestMethod]
        [TestCategory("GetFormObject")]
        public void GetFormObject_FromOptionObject_EmptyFormId_ThrowsArgumentNullException()
        {
            OptionObject optionObject = new();
            optionObject.AddFormObject(new FormObject("1"));

            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetFormObject(optionObject, string.Empty));
        }

        [TestMethod]
        [TestCategory("GetFormObject")]
        public void GetFormObject_FromOptionObject_NoMatchingForm_ThrowsArgumentException()
        {
            OptionObject optionObject = new();
            optionObject.AddFormObject(new FormObject("1"));

            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetFormObject(optionObject, "2"));
        }

        [TestMethod]
        [TestCategory("GetFormObject")]
        public void GetFormObject_FromOptionObject_NoForms_ThrowsArgumentException()
        {
            OptionObject optionObject = new();

            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetFormObject(optionObject, "1"));
        }
    }
}
