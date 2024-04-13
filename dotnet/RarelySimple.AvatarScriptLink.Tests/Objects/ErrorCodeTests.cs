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
            Assert.IsTrue(ErrorCode.None == expected);
        }

        [TestMethod]
        public void ErrorCode_Success_Returns0()
        {
            int expected = 0;
            Assert.IsTrue(ErrorCode.Success == expected);
        }

        [TestMethod]
        public void ErrorCode_Error_Returns1()
        {
            int expected = 1;
            Assert.IsTrue(ErrorCode.Error == expected);
        }

        [TestMethod]
        public void ErrorCode_Warning_Returns2()
        {
            int expected = 2;
            Assert.IsTrue(ErrorCode.Warning == expected);
        }

        [TestMethod]
        public void ErrorCode_OkCancel_Returns2()
        {
            int expected = 2;
            Assert.IsTrue(ErrorCode.OkCancel == expected);
        }

        [TestMethod]
        public void ErrorCode_Alert_Returns3()
        {
            int expected = 3;
            Assert.IsTrue(ErrorCode.Alert == expected);
        }

        [TestMethod]
        public void ErrorCode_Info_Returns3()
        {
            int expected = 3;
            Assert.IsTrue(ErrorCode.Info == expected);
        }

        [TestMethod]
        public void ErrorCode_Confirm_Returns4()
        {
            int expected = 4;
            Assert.IsTrue(ErrorCode.Confirm == expected);
        }

        [TestMethod]
        public void ErrorCode_YesNo_Returns4()
        {
            int expected = 4;
            Assert.IsTrue(ErrorCode.YesNo == expected);
        }

        [TestMethod]
        public void ErrorCode_OpenUrl_Returns5()
        {
            int expected = 5;
            Assert.IsTrue(ErrorCode.OpenUrl == expected);
        }

        [TestMethod]
        public void ErrorCode_OpenForm_Returns6()
        {
            int expected = 6;
            Assert.IsTrue(ErrorCode.OpenForm == expected);
        }
    }
}
