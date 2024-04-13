using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;

namespace RarelySimple.AvatarScriptLink.Objects.Tests
{
    [TestClass]
    public class OptionObjectTests
    {
        [TestMethod]
        public void OptionObjectCloneAreEqual()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1"
            };
            OptionObject optionObject2 = optionObject1.Clone();
            Assert.AreEqual(optionObject1, optionObject2);
        }

        [TestMethod]
        public void OptionObjectEqualsMethodIsTrue()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            OptionObject optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObjectEqualsMethodObjectIsTrue()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            IOptionObject optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObjectEqualsMethodEmptyFormsIsTrue()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                Forms = [],
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            OptionObject optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObjectEqualsMethodFormsIsTrue()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                Forms = [ new FormObject() ],
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            OptionObject optionObject2 = optionObject1.Clone();
            Assert.IsTrue(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObjectEqualsMethodFormsIsFalse()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            OptionObject optionObject2 = optionObject1.Clone();
            optionObject2.Forms.Add(new FormObject());
            Assert.IsFalse(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObjectEqualsMethodIsFalse()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            OptionObject optionObject2 = optionObject1.Clone();
            optionObject2.ErrorMesg = "Modified";
            Assert.IsFalse(optionObject1.Equals(optionObject2));
        }

        [TestMethod]
        public void OptionObjectEqualsObjectMethodIsFalse()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
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
        public void OptionObjectEqualsObjectMethodNullIsFalse()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            Assert.IsFalse(optionObject1.Equals(null));
        }

        [TestMethod]
        public void OptionObjectEqualsOperatorIsTrue()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            OptionObject optionObject2 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            Assert.IsTrue(optionObject1 == optionObject2);
            Assert.IsFalse(optionObject1 != optionObject2);
        }

        [TestMethod]
        public void OptionObjectEqualsOperatorLeftNullIsFalse()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            Assert.IsFalse(null == optionObject1);
            Assert.IsTrue(null != optionObject1);
        }

        [TestMethod]
        public void OptionObjectEqualsOperatorRightNullIsFalse()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            Assert.IsFalse(optionObject1 == null);
            Assert.IsTrue(optionObject1 != null);
        }

        [TestMethod]
        public void OptionObjectGetHashCodeAreEqual()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            OptionObject optionObject2 = optionObject1;
            Assert.AreEqual(optionObject1.GetHashCode(), optionObject2.GetHashCode());
        }

        [TestMethod]
        public void OptionObjectGetHashCodeCloneAreEqual()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            OptionObject optionObject2 = optionObject1.Clone();
            Assert.AreEqual(optionObject1.GetHashCode(), optionObject2.GetHashCode());
        }

        [TestMethod]
        public void OptionObjectGetHashCodeAreNotEqual()
        {
            OptionObject optionObject1 = new()
            {
                EntityID = "1",
                EpisodeNumber = 2,
                ErrorCode = 3,
                ErrorMesg = "Test response",
                Facility = "4",
                OptionId = "OPTION001",
                OptionStaffId = "5",
                OptionUserId = "USER",
                SystemCode = "TEST"
            };
            OptionObject optionObject2 = optionObject1.Clone();
            optionObject2.ErrorMesg = "modified";
            Assert.AreNotEqual(optionObject1.GetHashCode(), optionObject2.GetHashCode());
        }
    }
}