namespace RarelySimple.AvatarScriptLink.Objects.Tests
{
    [TestClass]
    public class OptionObject2Tests
    {
        [TestMethod]
        public void OptionObject2CloneAreEqual()
        {
            OptionObject2 optionObject1 = new()
            {
                EntityID = "1"
            };
            OptionObject2 optionObject2 = optionObject1.Clone();
            Assert.AreEqual(optionObject1, optionObject2);
        }

        [TestMethod]
        public void OptionObject2EqualsMethodIsTrue()
        {
            OptionObject2 optionObject1 = new()
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
            OptionObject2 optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2EqualsMethodEmptyFormsIsTrue()
        {
            OptionObject2 optionObject1 = new()
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
                SystemCode = "TEST"
            };
            OptionObject2 optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2EqualsMethodFormsIsTrue()
        {
            OptionObject2 optionObject1 = new()
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
                SystemCode = "TEST"
            };
            OptionObject2 optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2EqualsMethodFormsIsFalse()
        {
            OptionObject2 optionObject1 = new()
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
            OptionObject2 optionObject2 = optionObject1.Clone();
            optionObject2.Forms.Add(new FormObject());
            Assert.IsFalse(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2EqualsMethodIsFalse()
        {
            OptionObject2 optionObject1 = new()
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
            OptionObject2 optionObject2 = optionObject1.Clone();
            optionObject2.ErrorMesg = "Modified";
            Assert.IsFalse(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2EqualsObjectMethodIsFalse()
        {
            OptionObject2 optionObject1 = new()
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
            Assert.IsFalse(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObject2EqualsOperatorIsTrue()
        {
            OptionObject2 optionObject1 = new()
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
            Assert.IsTrue(optionObject1 == optionObject2);
        }

        [TestMethod]
        public void OptionObject2EqualsOperatorLeftNullIsFalse()
        {
            OptionObject2 optionObject1 = new()
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
            Assert.IsFalse(null == optionObject1);
        }

        [TestMethod]
        public void OptionObject2EqualsOperatorRightNullIsFalse()
        {
            OptionObject2 optionObject1 = new()
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
            Assert.IsFalse(optionObject1 == null);
        }
    }
}