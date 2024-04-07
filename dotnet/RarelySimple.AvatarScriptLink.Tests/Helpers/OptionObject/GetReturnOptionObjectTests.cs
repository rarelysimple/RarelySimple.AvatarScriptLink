using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class GetReturnOptionObjectTests
    {
        private OptionObject optionObject;

        [TestInitialize]
        public void TestInitialize()
        {
            optionObject = new OptionObject
            {
                EntityID = "123456",
                EpisodeNumber = 1,
                Facility = "1",
                OptionId = "USER00",
                OptionStaffId = "1234",
                OptionUserId = "username",
                SystemCode = "UAT"
            };
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
        public void GetReturnOptionObject_ErrorMessage_PresetPreserved()
        {
            string expected = "Hello World!";
            OptionObject presetOptionObject = OptionObject.Initialize();
            presetOptionObject.ErrorMesg = expected;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject(presetOptionObject);
            Assert.AreEqual(expected, returnOptionObject.ErrorMesg);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_PresetPreserved()
        {
            double expected = 3;
            OptionObject presetOptionObject = OptionObject.Initialize();
            presetOptionObject.ErrorCode = expected;
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.GetReturnOptionObject(presetOptionObject);
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
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
            //Assert.AreNotEqual("3", returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetReturnOptionObject_OptionObject2_Null()
        {
            OptionObject2 nullOptionObject = null;
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.GetReturnOptionObject((IOptionObject2)nullOptionObject);
            //Assert.AreNotEqual("3", returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetReturnOptionObject_OptionObject2015_Null()
        {
            OptionObject2015 nullOptionObject = null;
            OptionObject2015 returnOptionObject = (OptionObject2015)OptionObjectHelpers.GetReturnOptionObject(nullOptionObject);
            //Assert.AreNotEqual("3", returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ReturnsEditedRow()
        {
            OptionObject2015 expected = new("CWSPN22003", "unittestuser", "", "1", "", 0, "UAT", "AVCWS", "AVCWS", "SERVER", "TOKEN");

            FieldObject fieldObject1 = new("51003", "");
            FieldObject fieldObject2 = new("7051.4", "");
            FieldObject fieldObject3 = new("7051.2", "");
            FieldObject fieldObject4 = new("7051.3", "");
            RowObject rowObject = new("22003||1");
            rowObject.AddFieldObject(fieldObject1);
            rowObject.AddFieldObject(fieldObject2);
            rowObject.AddFieldObject(fieldObject3);
            rowObject.AddFieldObject(fieldObject4);
            FormObject indForm = new("22003", rowObject, false);
            expected.AddFormObject(indForm);

            expected.SetFieldValue("51003", "Modified");
            OptionObject2015 actual = (OptionObject2015)expected.ToReturnOptionObject();

            Assert.IsTrue(actual.IsFieldPresent("51003"));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_NoCurrentRowReturnsWithoutException()
        {
            OptionObject2015 expected = new("USER37", "unittestuser", "", "1", "", 0, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");

            FieldObject fieldObject01 = new("214.74", "2");
            FieldObject fieldObject02 = new("214.98", "12/07/2020");
            RowObject rowObject01 = new("33||1");
            rowObject01.AddFieldObject(fieldObject01);
            rowObject01.AddFieldObject(fieldObject02);
            FormObject form33 = new("33", rowObject01, false);
            expected.AddFormObject(form33);

            FieldObject fieldObject03 = new("214.75", "");
            FieldObject fieldObject04 = new("214.76", "");
            FieldObject fieldObject05 = new("214.77", "");
            FieldObject fieldObject06 = new("214.78", "");
            FieldObject fieldObject07 = new("214.79", "");
            FieldObject fieldObject08 = new("214.8", "");
            FieldObject fieldObject09 = new("214.81", "");
            FieldObject fieldObject10 = new("214.82", "");
            FieldObject fieldObject11 = new("214.83", "");
            FieldObject fieldObject12 = new("214.85", "");
            FieldObject fieldObject13 = new("214.86", "30");
            FieldObject fieldObject14 = new("214.91", "");
            FieldObject fieldObject15 = new("214.93", "");
            FieldObject fieldObject16 = new("214.94", "");
            FieldObject fieldObject17 = new("214.96", "12/3/2020");
            FieldObject fieldObject18 = new("214.97", "12/4/2020");
            RowObject rowObject02 = new("34||1", "33||1");
            rowObject02.AddFieldObject(fieldObject03);
            rowObject02.AddFieldObject(fieldObject04);
            rowObject02.AddFieldObject(fieldObject05);
            rowObject02.AddFieldObject(fieldObject06);
            rowObject02.AddFieldObject(fieldObject07);
            rowObject02.AddFieldObject(fieldObject08);
            rowObject02.AddFieldObject(fieldObject09);
            rowObject02.AddFieldObject(fieldObject10);
            rowObject02.AddFieldObject(fieldObject11);
            rowObject02.AddFieldObject(fieldObject12);
            rowObject02.AddFieldObject(fieldObject13);
            rowObject02.AddFieldObject(fieldObject14);
            rowObject02.AddFieldObject(fieldObject15);
            rowObject02.AddFieldObject(fieldObject16);
            rowObject02.AddFieldObject(fieldObject17);
            rowObject02.AddFieldObject(fieldObject18);

            FieldObject fieldObject19 = new("214.75", "");
            FieldObject fieldObject20 = new("214.76", "");
            FieldObject fieldObject21 = new("214.77", "");
            FieldObject fieldObject22 = new("214.78", "");
            FieldObject fieldObject23 = new("214.79", "");
            FieldObject fieldObject24 = new("214.8", "");
            FieldObject fieldObject25 = new("214.81", "");
            FieldObject fieldObject26 = new("214.82", "");
            FieldObject fieldObject27 = new("214.83", "");
            FieldObject fieldObject28 = new("214.85", "");
            FieldObject fieldObject29 = new("214.86", "110");
            FieldObject fieldObject30 = new("214.91", "");
            FieldObject fieldObject31 = new("214.93", "");
            FieldObject fieldObject32 = new("214.94", "");
            FieldObject fieldObject33 = new("214.96", "12/4/2020");
            FieldObject fieldObject34 = new("214.97", "");
            RowObject rowObject03 = new("34||2", "33||1");
            rowObject03.AddFieldObject(fieldObject19);
            rowObject03.AddFieldObject(fieldObject20);
            rowObject03.AddFieldObject(fieldObject21);
            rowObject03.AddFieldObject(fieldObject22);
            rowObject03.AddFieldObject(fieldObject23);
            rowObject03.AddFieldObject(fieldObject24);
            rowObject03.AddFieldObject(fieldObject25);
            rowObject03.AddFieldObject(fieldObject26);
            rowObject03.AddFieldObject(fieldObject27);
            rowObject03.AddFieldObject(fieldObject28);
            rowObject03.AddFieldObject(fieldObject29);
            rowObject03.AddFieldObject(fieldObject30);
            rowObject03.AddFieldObject(fieldObject31);
            rowObject03.AddFieldObject(fieldObject32);
            rowObject03.AddFieldObject(fieldObject33);
            rowObject03.AddFieldObject(fieldObject34);


            FormObject form34 = new("34");
            form34.MultipleIteration = true;
            form34.OtherRows.Add(rowObject02);
            form34.OtherRows.Add(rowObject03);
            expected.AddFormObject(form34);

            OptionObject2015 actual = (OptionObject2015)expected.ToReturnOptionObject();

            Assert.AreEqual(expected.OptionId, actual.OptionId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_NoCurrentRowModifiedReturnsWithoutException()
        {
            OptionObject2015 expected = new("USER37", "unittestuser", "", "1", "", 0, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");

            FieldObject fieldObject01 = new("214.74", "2");
            FieldObject fieldObject02 = new("214.98", "12/07/2020");
            RowObject rowObject01 = new("33||1");
            rowObject01.AddFieldObject(fieldObject01);
            rowObject01.AddFieldObject(fieldObject02);
            FormObject form33 = new("33", rowObject01, false);
            expected.AddFormObject(form33);

            FieldObject fieldObject03 = new("214.75", "");
            FieldObject fieldObject04 = new("214.76", "");
            FieldObject fieldObject05 = new("214.77", "");
            FieldObject fieldObject06 = new("214.78", "");
            FieldObject fieldObject07 = new("214.79", "");
            FieldObject fieldObject08 = new("214.8", "");
            FieldObject fieldObject09 = new("214.81", "");
            FieldObject fieldObject10 = new("214.82", "");
            FieldObject fieldObject11 = new("214.83", "");
            FieldObject fieldObject12 = new("214.85", "");
            FieldObject fieldObject13 = new("214.86", "30");
            FieldObject fieldObject14 = new("214.91", "");
            FieldObject fieldObject15 = new("214.93", "");
            FieldObject fieldObject16 = new("214.94", "");
            FieldObject fieldObject17 = new("214.96", "12/3/2020");
            FieldObject fieldObject18 = new("214.97", "12/4/2020");
            RowObject rowObject02 = new("34||1", "33||1");
            rowObject02.AddFieldObject(fieldObject03);
            rowObject02.AddFieldObject(fieldObject04);
            rowObject02.AddFieldObject(fieldObject05);
            rowObject02.AddFieldObject(fieldObject06);
            rowObject02.AddFieldObject(fieldObject07);
            rowObject02.AddFieldObject(fieldObject08);
            rowObject02.AddFieldObject(fieldObject09);
            rowObject02.AddFieldObject(fieldObject10);
            rowObject02.AddFieldObject(fieldObject11);
            rowObject02.AddFieldObject(fieldObject12);
            rowObject02.AddFieldObject(fieldObject13);
            rowObject02.AddFieldObject(fieldObject14);
            rowObject02.AddFieldObject(fieldObject15);
            rowObject02.AddFieldObject(fieldObject16);
            rowObject02.AddFieldObject(fieldObject17);
            rowObject02.AddFieldObject(fieldObject18);

            FieldObject fieldObject19 = new("214.75", "");
            FieldObject fieldObject20 = new("214.76", "");
            FieldObject fieldObject21 = new("214.77", "");
            FieldObject fieldObject22 = new("214.78", "");
            FieldObject fieldObject23 = new("214.79", "");
            FieldObject fieldObject24 = new("214.8", "");
            FieldObject fieldObject25 = new("214.81", "");
            FieldObject fieldObject26 = new("214.82", "");
            FieldObject fieldObject27 = new("214.83", "");
            FieldObject fieldObject28 = new("214.85", "");
            FieldObject fieldObject29 = new("214.86", "110");
            FieldObject fieldObject30 = new("214.91", "");
            FieldObject fieldObject31 = new("214.93", "");
            FieldObject fieldObject32 = new("214.94", "");
            FieldObject fieldObject33 = new("214.96", "12/4/2020");
            FieldObject fieldObject34 = new("214.97", "");
            RowObject rowObject03 = new("34||2", "33||1");
            rowObject03.AddFieldObject(fieldObject19);
            rowObject03.AddFieldObject(fieldObject20);
            rowObject03.AddFieldObject(fieldObject21);
            rowObject03.AddFieldObject(fieldObject22);
            rowObject03.AddFieldObject(fieldObject23);
            rowObject03.AddFieldObject(fieldObject24);
            rowObject03.AddFieldObject(fieldObject25);
            rowObject03.AddFieldObject(fieldObject26);
            rowObject03.AddFieldObject(fieldObject27);
            rowObject03.AddFieldObject(fieldObject28);
            rowObject03.AddFieldObject(fieldObject29);
            rowObject03.AddFieldObject(fieldObject30);
            rowObject03.AddFieldObject(fieldObject31);
            rowObject03.AddFieldObject(fieldObject32);
            rowObject03.AddFieldObject(fieldObject33);
            rowObject03.AddFieldObject(fieldObject34);

            rowObject03.SetFieldValue("214.96", "12/5/2020");

            FormObject form34 = new("34")
            {
                MultipleIteration = true
            };
            form34.OtherRows.Add(rowObject02);
            form34.OtherRows.Add(rowObject03);
            expected.AddFormObject(form34);

            OptionObject2015 actual = (OptionObject2015)expected.ToReturnOptionObject();

            Assert.AreEqual(expected.OptionId, actual.OptionId);
        }
    }
}
