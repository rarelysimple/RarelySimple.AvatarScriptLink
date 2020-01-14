using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class GetReturnOptionObjectTests
    {
        private OptionObject optionObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.optionObject = new OptionObject();

            optionObject.EntityID = "123456";
            optionObject.EpisodeNumber = 1;
            optionObject.Facility = "1";
            optionObject.OptionId = "USER00";
            optionObject.OptionStaffId = "1234";
            optionObject.OptionUserId = "username";
            optionObject.SystemCode = "UAT";
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_EntityID_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject);
            Assert.AreEqual(optionObject.EntityID, returnOptionObject.EntityID);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_EpisodeNumber_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject);
            Assert.AreEqual(optionObject.EpisodeNumber, returnOptionObject.EpisodeNumber);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_Facility_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject);
            Assert.AreEqual(optionObject.Facility, returnOptionObject.Facility);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_OptionId_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject);
            Assert.AreEqual(optionObject.OptionId, returnOptionObject.OptionId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_OptionStaffId_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject);
            Assert.AreEqual(optionObject.OptionStaffId, returnOptionObject.OptionStaffId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_OptionUserId_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject);
            Assert.AreEqual(optionObject.OptionUserId, returnOptionObject.OptionUserId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_SystemCode_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject);
            Assert.AreEqual(optionObject.SystemCode, returnOptionObject.SystemCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorMessage_AreEqual()
        {
            string expected = "Hello World!";
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, 1, expected);
            Assert.AreEqual(expected, returnOptionObject.ErrorMesg);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_Default_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject);
            Assert.AreEqual(0, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_0_AreEqual()
        {
            int expected = 0;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_1_AreEqual()
        {
            int expected = 1;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_2_AreEqual()
        {
            int expected = 2;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_3_AreEqual()
        {
            int expected = 3;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_4_AreEqual()
        {
            int expected = 4;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_5_AreEqual()
        {
            int expected = 5;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "http://www.rcskids.org");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetReturnOptionObject_ErrorCode_5_InvalidURL()
        {
            int expected = 5;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_6_AreEqual()
        {
            int expected = 6;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "[PM]GUISYS560");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetReturnOptionObject_ErrorCode_6_InvalidOpenFormString()
        {
            int expected = 6;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetReturnOptionObject_ErrorCode_7_Error()
        {
            int expected = 7;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "test");
            Assert.AreNotEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetReturnOptionObject_ErrorCode_Negative1_Error()
        {
            int expected = -1;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)optionObject, expected, "test");
            Assert.AreNotEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetReturnOptionObject_OptionObject_Null()
        {
            OptionObject nullOptionObject = null;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)nullOptionObject);
            Assert.AreNotEqual("3", returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetReturnOptionObject_OptionObject2_Null()
        {
            OptionObject2 nullOptionObject = null;
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.GetReturnOptionObject((IOptionObject2)nullOptionObject);
            Assert.AreNotEqual("3", returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetReturnOptionObject_OptionObject2015_Null()
        {
            OptionObject2015 nullOptionObject = null;
            OptionObject2015 returnOptionObject = (OptionObject2015)OptionObjectHelpers.GetReturnOptionObject(nullOptionObject);
            Assert.AreNotEqual("3", returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ReturnsEditedRow()
        {
            OptionObject2015 expected = new OptionObject2015("CWSPN22003", "unittestuser", "", "1", "", 0, "UAT", "AVCWS", "AVCWS", "SERVER", "TOKEN");

            FieldObject fieldObject1 = new FieldObject("51003", "");
            FieldObject fieldObject2 = new FieldObject("7051.4", "");
            FieldObject fieldObject3 = new FieldObject("7051.2", "");
            FieldObject fieldObject4 = new FieldObject("7051.3", "");
            RowObject rowObject = new RowObject("22003||1");
            rowObject.AddFieldObject(fieldObject1);
            rowObject.AddFieldObject(fieldObject2);
            rowObject.AddFieldObject(fieldObject3);
            rowObject.AddFieldObject(fieldObject4);
            FormObject indForm = new FormObject("22003", rowObject, false);
            expected.AddFormObject(indForm);

            expected.SetFieldValue("51003", "Modified");
            OptionObject2015 actual = (OptionObject2015)expected.ToReturnOptionObject();

            Assert.IsTrue(actual.IsFieldPresent("51003"));
        }
    }
}
