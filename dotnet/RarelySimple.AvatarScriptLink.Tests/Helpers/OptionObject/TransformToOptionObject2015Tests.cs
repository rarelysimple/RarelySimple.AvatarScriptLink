using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class TransformToOptionObject2015Tests
    {
        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_EntityIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_EpisodeNumberMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_ErrorCodeMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_ErrorMesgMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_FacilityMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_OptionIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_OptionStaffIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_OptionUserIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_SystemCodeMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_FormCountMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject_ModifiedFormCountMatch()
        {
            FormObject addForm = new();
            OptionObject optionObject = new();
            optionObject.Forms.Add(addForm);

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_EntityIdMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_EpisodeNumberMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_ErrorCodeMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_ErrorMesgMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_FacilityMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_OptionIdMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_OptionStaffIdMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_OptionUserIdMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_SystemCodeMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_FormCountMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObject2_ModifiedFormCountMatch()
        {
            FormObject addForm = new();
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(addForm);

            OptionObject2015 transformedOptionObject = optionObject.ToOptionObject2015();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_EntityIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_EpisodeNumberMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_ErrorCodeMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_ErrorMesgMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_FacilityMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_OptionIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_OptionStaffIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_OptionUserIdMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_SystemCodeMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_FormCountMatch()
        {
            OptionObject optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject_ModifiedFormCountMatch()
        {
            FormObject addForm = new();
            OptionObject optionObject = new();
            optionObject.Forms.Add(addForm);

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_EntityIdMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_EpisodeNumberMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_ErrorCodeMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_ErrorMesgMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_FacilityMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_OptionIdMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_OptionStaffIdMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_OptionUserIdMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_SystemCodeMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_FormCountMatch()
        {
            OptionObject2 optionObject = new();

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2015_OptionObjectHelpers_OptionObject2_ModifiedFormCountMatch()
        {
            FormObject addForm = new();
            OptionObject2 optionObject = new();
            optionObject.Forms.Add(addForm);

            OptionObject2015 transformedOptionObject = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject2015_Json_EntityIdSetAndMatch()
        {
            string json = "{\"EntityID\":1,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject2015 expected = new()
            {
                EntityID = "1"
            };

            OptionObject2015 actual = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(json);
            
            Assert.IsNotNull(actual.EntityID);
            Assert.AreEqual(expected.EntityID, actual.EntityID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToOptionObject2015_Json_EntityIdSetAndNoMatch()
        {
            string json = "{\"EntityID\":2,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject2015 expected = new()
            {
                EntityID = "1"
            };

            OptionObject2015 actual = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(json);
            
            Assert.IsNotNull(actual.EntityID);
            Assert.AreNotEqual(expected.EntityID, actual.EntityID);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToOptionObject2015_Xml_EntityIdSetAndMatch()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2015 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EntityID>1</EntityID>" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2015>";
            OptionObject2015 expected = new()
            {
                EntityID = "1"
            };

            OptionObject2015 actual = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(xml);
            
            Assert.IsNotNull(actual.EntityID);
            Assert.AreEqual(expected.EntityID, actual.EntityID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToOptionObject2015_Xml_EntityIdSetAndNoMatch()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2015 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EntityID>2</EntityID>" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2015>";
            OptionObject2015 expected = new()
            {
                EntityID = "1"
            };

            OptionObject2015 actual = (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(xml);
            
            Assert.IsNotNull(actual.EntityID);
            Assert.AreNotEqual(expected.EntityID, actual.EntityID);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
