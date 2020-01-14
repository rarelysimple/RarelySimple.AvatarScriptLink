using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using System;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class TransformToOptionObjectTests
    {
        [TestMethod]
        public void TransformToOptionObject_OptionObject2_EntityIdMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_EpisodeNumberMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_ErrorCodeMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_ErrorMesgMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_FacilityMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_OptionIdMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_OptionStaffIdMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_OptionUserIdMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_SystemCodeMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_FormCountMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2_ModifiedFormCountMatch()
        {
            FormObject addForm = new FormObject();
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(addForm);

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_EntityIdMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_EpisodeNumberMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_ErrorCodeMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_ErrorMesgMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_FacilityMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_OptionIdMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_OptionStaffIdMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_OptionUserIdMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_SystemCodeMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_FormCountMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObject2015_ModifiedFormCountMatch()
        {
            FormObject addForm = new FormObject();
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.Forms.Add(addForm);

            OptionObject transformedOptionObject = optionObject.ToOptionObject();

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_EntityIdMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_EpisodeNumberMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_ErrorCodeMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_ErrorMesgMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_FacilityMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_OptionIdMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_OptionStaffIdMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_OptionUserIdMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_SystemCodeMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_FormCountMatch()
        {
            OptionObject2 optionObject = new OptionObject2();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2_ModifiedFormCountMatch()
        {
            FormObject addForm = new FormObject();
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(addForm);

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_EntityIdMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_EpisodeNumberMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_ErrorCodeMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_ErrorMesgMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_FacilityMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_OptionIdMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_OptionStaffIdMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_OptionUserIdMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_SystemCodeMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_FormCountMatch()
        {
            OptionObject2015 optionObject = new OptionObject2015();

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject_OptionObjectHelpers_OptionObject2015_ModifiedFormCountMatch()
        {
            FormObject addForm = new FormObject();
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(addForm);

            OptionObject transformedOptionObject = (OptionObject)OptionObjectHelpers.TransformToOptionObject(optionObject);

            Assert.AreEqual(optionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        public void TransformToOptionObject_Json_EntityIdSetAndMatch()
        {
            string json = "{\"EntityID\":1,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject expected = new OptionObject
            {
                EntityID = "1"
            };
            OptionObject actual = (OptionObject)OptionObjectHelpers.TransformToOptionObject(json);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreEqual(expected.EntityID, actual.EntityID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToOptionObject_Json_EntityIdSetAndNoMatch()
        {
            string json = "{\"EntityID\":2,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject expected = new OptionObject
            {
                EntityID = "1"
            };
            OptionObject actual = (OptionObject)OptionObjectHelpers.TransformToOptionObject(json);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreNotEqual(expected.EntityID, actual.EntityID);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToOptionObject_Xml_EntityIdSetAndMatch()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EntityID>1</EntityID>" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject>";
            OptionObject expected = new OptionObject
            {
                EntityID = "1"
            };
            OptionObject actual = (OptionObject)OptionObjectHelpers.TransformToOptionObject(xml);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreEqual(expected.EntityID, actual.EntityID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToOptionObject_Xml_EntityIdSetAndNoMatch()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EntityID>2</EntityID>" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject>";
            OptionObject expected = new OptionObject
            {
                EntityID = "1"
            };
            OptionObject actual = (OptionObject)OptionObjectHelpers.TransformToOptionObject(xml);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreNotEqual(expected.EntityID, actual.EntityID);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
