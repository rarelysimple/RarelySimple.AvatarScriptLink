using RarelySimple.AvatarScriptLink.Objects.Interfaces;

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
        public void OptionObject2Clone_WhenFormsAreNull_TreatsFormsAsEmptyCollection()
        {
            OptionObject2 optionObject1 = new()
            {
                EntityID = "1",
                Forms = null
            };

            OptionObject2 optionObject2 = optionObject1.Clone();

            Assert.IsNotNull(optionObject2.Forms);
            Assert.AreEqual(0, optionObject2.Forms.Count);
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
        public void OptionObject2EqualsMethodObjectIsTrue()
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
            IOptionObject2 optionObject2 = optionObject1.Clone();
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
        public void OptionObject2EqualsObjectMethodNullIsFalse()
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
            Assert.IsFalse(optionObject1.Equals(null));
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
            Assert.IsFalse(optionObject1 != optionObject2);
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
            Assert.IsTrue(null != optionObject1);
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
            Assert.IsTrue(optionObject1 != null);
        }

        [TestMethod]
        public void OptionObject2GetHashCodeAreEqual()
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
            OptionObject2 optionObject2 = optionObject1;
            Assert.AreEqual(optionObject1.GetHashCode(), optionObject2.GetHashCode());
        }

        [TestMethod]
        public void OptionObject2GetHashCodeCloneAreEqual()
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
            Assert.AreEqual(optionObject1.GetHashCode(), optionObject2.GetHashCode());
        }

        [TestMethod]
        public void OptionObject2GetHashCodeAreNotEqual()
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
            optionObject2.ErrorMesg = "modified";
            Assert.AreNotEqual(optionObject1.GetHashCode(), optionObject2.GetHashCode());
        }

        #region Collection Presence Helper Tests

        [TestMethod]
        public void TestOptionObject2_HasForms_WhenEmpty()
        {
            var optionObject = OptionObject2.Initialize();
            Assert.IsFalse(optionObject.HasForms());
        }

        [TestMethod]
        public void TestOptionObject2_HasForms_WhenNotEmpty()
        {
            var optionObject = OptionObject2.Initialize();
            optionObject.Forms.Add(FormObject.Initialize());
            Assert.IsTrue(optionObject.HasForms());
        }

        [TestMethod]
        public void TestOptionObject2_HasForms_WhenMultipleForms()
        {
            var optionObject = OptionObject2.Initialize();
            optionObject.Forms.Add(FormObject.Initialize());
            optionObject.Forms.Add(FormObject.Initialize());
            Assert.IsTrue(optionObject.HasForms());
        }

        #endregion
    }
}