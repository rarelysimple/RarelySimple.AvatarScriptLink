using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class TransformToOptionObject2Tests
    {

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_EntityIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_EpisodeNumberMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_ErrorCodeMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_ErrorMesgMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_FacilityMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_OptionIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_OptionStaffIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_OptionUserIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_SystemCodeMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_FormCountMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject_ModifiedFormCountMatch()
        {
            FormObject addForm = new();
            OptionObject optionObject = new();
            optionObject.Forms.Add(addForm);

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_EntityIdMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_EpisodeNumberMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_ErrorCodeMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_ErrorMesgMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_FacilityMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_OptionIdMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_OptionStaffIdMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_OptionUserIdMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_SystemCodeMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_FormCountMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObject2015_ModifiedFormCountMatch()
        {
            FormObject addForm = new();
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(addForm);

            OptionObject2 transformedOptionObject = optionObject.ToOptionObject2();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_EntityIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_EpisodeNumberMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_ErrorCodeMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_ErrorMesgMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_FacilityMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_OptionIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_OptionStaffIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_OptionUserIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_SystemCodeMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_FormCountMatch()
        {
            OptionObject optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject_ModifiedFormCountMatch()
        {
            FormObject addForm = new();
            OptionObject optionObject = new();
            optionObject.Forms.Add(addForm);

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_EntityIdMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_EpisodeNumberMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_ErrorCodeMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_ErrorMesgMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_FacilityMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_OptionIdMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_OptionStaffIdMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_OptionUserIdMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_SystemCodeMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_FormCountMatch()
        {
            OptionObject2015 optionObject = new();

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2_OptionObjectHelpers_OptionObject2015_ModifiedFormCountMatch()
        {
            FormObject addForm = new();
            OptionObject2015 optionObject = new();
            optionObject.Forms.Add(addForm);

            OptionObject2 transformedOptionObject = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2_Json_EntityIdSetAndMatch()
        {
            string json = "{\"EntityID\":1,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject2 expected = new()
            {
                EntityID = "1"
            };
            OptionObject2 actual = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(json);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreEqual(expected.EntityID, actual.EntityID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToOptionObject2_Json_EntityIdSetAndNoMatch()
        {
            string json = "{\"EntityID\":2,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject2 expected = new()
            {
                EntityID = "1"
            };
            OptionObject2 actual = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(json);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreNotEqual(expected.EntityID, actual.EntityID);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void TransformToOptionObject2_Xml_EntityIdSetAndMatch()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EntityID>1</EntityID>" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2>";
            OptionObject2 expected = new()
            {
                EntityID = "1"
            };
            OptionObject2 actual = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(xml);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreEqual(expected.EntityID, actual.EntityID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void TransformToOptionObject2_Xml_EntityIdSetAndNoMatch()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EntityID>2</EntityID>" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2>";
            OptionObject2 expected = new()
            {
                EntityID = "1"
            };
            OptionObject2 actual = (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(xml);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreNotEqual(expected.EntityID, actual.EntityID);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
