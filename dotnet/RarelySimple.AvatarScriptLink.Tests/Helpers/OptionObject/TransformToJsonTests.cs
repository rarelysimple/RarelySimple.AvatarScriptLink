using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class TransformToJsonTests
    {
        [TestMethod]
        public void OptionObjectTransformToJsonIsString()
        {
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"SystemCode\":null}";
            Assert.AreEqual(expected, new OptionObject().ToJson());
            Assert.AreEqual(expected.GetType(), new OptionObject().ToJson().GetType());
        }

        [TestMethod]
        public void OptionObjectHelperTransformToJsonIsString()
        {
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"SystemCode\":null}";
            Assert.AreEqual(expected, OptionObjectHelpers.TransformToJson(new OptionObject()));
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.TransformToJson(new OptionObject()).GetType());
        }

        [TestMethod]
        public void OptionObject2TransformToJsonIsString()
        {
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null}";
            Assert.AreEqual(expected, new OptionObject2().ToJson());
            Assert.AreEqual(expected.GetType(), new OptionObject2().ToJson().GetType());
        }

        [TestMethod]
        public void OptionObject2HelperTransformToJsonIsString()
        {
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null}";
            Assert.AreEqual(expected, OptionObjectHelpers.TransformToJson(new OptionObject2()));
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.TransformToJson(new OptionObject2()).GetType());
        }

        [TestMethod]
        public void OptionObject2015TransformToJsonIsString()
        {
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            Assert.AreEqual(expected, new OptionObject2015().ToJson());
            Assert.AreEqual(expected.GetType(), new OptionObject2015().ToJson().GetType());
        }

        [TestMethod]
        public void OptionObject2015HelperTransformToJsonIsString()
        {
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            Assert.AreEqual(expected, OptionObjectHelpers.TransformToJson(new OptionObject2015()));
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.TransformToJson(new OptionObject2015()).GetType());
        }

        [TestMethod]
        public void FormObjectTransformToJsonIsString()
        {
            string expected = "{\"CurrentRow\":null,\"FormId\":null,\"MultipleIteration\":false,\"OtherRows\":[]}";
            Assert.AreEqual(expected, new FormObject().ToJson());
            Assert.AreEqual(expected.GetType(), new FormObject().ToJson().GetType());
        }

        [TestMethod]
        public void FormObjectHelperTransformToJsonIsString()
        {
            string expected = "{\"CurrentRow\":null,\"FormId\":null,\"MultipleIteration\":false,\"OtherRows\":[]}";
            Assert.AreEqual(expected, OptionObjectHelpers.TransformToJson(new FormObject()));
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.TransformToJson(new FormObject()).GetType());
        }

        [TestMethod]
        public void RowObjectTransformToJsonIsString()
        {
            string expected = "{\"Fields\":[],\"ParentRowId\":null,\"RowAction\":null,\"RowId\":null}";
            Assert.AreEqual(expected, new RowObject().ToJson());
            Assert.AreEqual(expected.GetType(), new RowObject().ToJson().GetType());
        }

        [TestMethod]
        public void RowObjectHelperTransformToJsonIsString()
        {
            string expected = "{\"Fields\":[],\"ParentRowId\":null,\"RowAction\":null,\"RowId\":null}";
            Assert.AreEqual(expected, OptionObjectHelpers.TransformToJson(new RowObject()));
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.TransformToJson(new RowObject()).GetType());
        }

        [TestMethod]
        public void FieldObjectTransformToJsonIsString()
        {
            string expected = "{\"Enabled\":\"\",\"FieldNumber\":\"\",\"FieldValue\":\"\",\"Lock\":\"\",\"Required\":\"\"}";
            Assert.AreEqual(expected, new FieldObject().ToJson());
            Assert.AreEqual(expected.GetType(), new FieldObject().ToJson().GetType());
        }

        [TestMethod]
        public void FieldObjectHelperTransformToJsonIsString()
        {
            string expected = "{\"Enabled\":\"\",\"FieldNumber\":\"\",\"FieldValue\":\"\",\"Lock\":\"\",\"Required\":\"\"}";
            Assert.AreEqual(expected, OptionObjectHelpers.TransformToJson(new FieldObject()));
            Assert.AreEqual(expected.GetType(), OptionObjectHelpers.TransformToJson(new FieldObject()).GetType());
        }
    }
}
