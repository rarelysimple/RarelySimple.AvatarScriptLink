using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class ErrorCodeTests
    {
        [TestMethod]
        public void ErrorCode_None_Returns0()
        {
            int expected = 0;
            Assert.AreEqual(expected, ErrorCode.None);
        }

        [TestMethod]
        public void ErrorCode_Success_Returns0()
        {
            int expected = 0;
            Assert.AreEqual(expected, ErrorCode.Success);
        }

        [TestMethod]
        public void ErrorCode_Error_Returns1()
        {
            int expected = 1;
            Assert.AreEqual(expected, ErrorCode.Error);
        }

        [TestMethod]
        public void ErrorCode_Warning_Returns2()
        {
            int expected = 2;
            Assert.AreEqual(expected, ErrorCode.Warning);
        }

        [TestMethod]
        public void ErrorCode_OkCancel_Returns2()
        {
            int expected = 2;
            Assert.AreEqual(expected, ErrorCode.OkCancel);
        }

        [TestMethod]
        public void ErrorCode_Alert_Returns3()
        {
            int expected = 3;
            Assert.AreEqual(expected, ErrorCode.Alert);
        }

        [TestMethod]
        public void ErrorCode_Info_Returns3()
        {
            int expected = 3;
            Assert.AreEqual(expected, ErrorCode.Informational);
        }

        [TestMethod]
        public void ErrorCode_Confirm_Returns4()
        {
            int expected = 4;
            Assert.AreEqual(expected, ErrorCode.Confirm);
        }

        [TestMethod]
        public void ErrorCode_YesNo_Returns4()
        {
            int expected = 4;
            Assert.AreEqual(expected, ErrorCode.YesNo);
        }

        [TestMethod]
        public void ErrorCode_OpenUrl_Returns5()
        {
            int expected = 5;
            Assert.AreEqual(expected, ErrorCode.OpenUrl);
        }

        [TestMethod]
        public void ErrorCode_OpenForm_Returns6()
        {
            int expected = 6;
            Assert.AreEqual(expected, ErrorCode.OpenForm);
        }
    }
}
