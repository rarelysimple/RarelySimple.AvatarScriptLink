namespace RarelySimple.AvatarScriptLink.Objects.Tests
{
    [TestClass]
    public class OptionObject2015Tests
    {
        [TestMethod]
        public void OptionObject2015CloneAreEqual()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1"
            };
            OptionObject2015 optionObject2 = optionObject1.Clone();
            Assert.AreEqual(optionObject1, optionObject2);
        }

        [TestMethod]
        public void OptionObject2015EqualsMethodIsTrue()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            OptionObject2015 optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2015EqualsMethodEmptyFormsIsTrue()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                Forms = [],
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            OptionObject2015 optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2015EqualsMethodFormsIsTrue()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                Forms = [ new FormObject() ],
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            OptionObject2015 optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2015EqualsMethodFormsIsFalse()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            OptionObject2015 optionObject2 = optionObject1.Clone();
            optionObject2.Forms.Add(new FormObject());
            Assert.IsFalse(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2015EqualsMethodIsFalse()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            OptionObject2015 optionObject2 = optionObject1.Clone();
            optionObject2.ErrorMesg = "Modified";
            Assert.IsFalse(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2015EqualsObjectMethodIsFalse()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            OptionObject2 optionObject2 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SystemCode = "TEST"
            };
            Assert.IsFalse(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2015EqualsOperatorIsTrue()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            OptionObject2015 optionObject2 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            Assert.IsTrue(optionObject1 == optionObject2);
        }

        [TestMethod]
        public void OptionObject2015EqualsOperatorLeftNullIsFalse()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            Assert.IsFalse(null == optionObject1);
        }

        [TestMethod]
        public void OptionObject2015EqualsOperatorRightNullIsFalse()
        {
            OptionObject2015 optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                NamespaceName = "Namespace",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                ParentNamespace = "Parent",
                ServerName = "Server",
                SessionToken = "6",
                SystemCode = "TEST"
            };
            Assert.IsFalse(optionObject1 == null);
        }
    }
}