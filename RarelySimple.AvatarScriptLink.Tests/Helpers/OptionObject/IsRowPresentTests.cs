using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class IsRowPresentTests
    {
        [TestMethod]
        public void IsRowPresent_OptionObject_IsTrue()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject(rowId);
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObject_IsFalse()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowPresent_OptionObject_FormsNull_Error()
        {
            // Arrange
            string rowId = "1||1";
            var optionObject = new OptionObject
            {
                Forms = null
            };

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObject_RowIdNull_Error()
        {
            // Arrange
            string rowId = null;
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObject_RowIdEmpty_Error()
        {
            // Arrange
            string rowId = "";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObject2_IsTrue()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject(rowId);
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObject2_IsFalse()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowPresent_OptionObject2_FormsNull_Error()
        {
            // Arrange
            string rowId = "1||1";
            var optionObject = new OptionObject2
            {
                Forms = null
            };

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObject2_RowIdNull_Error()
        {
            // Arrange
            string rowId = null;
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObject2_RowIdEmpty_Error()
        {
            // Arrange
            string rowId = "";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObject2015_IsTrue()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject(rowId);
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObject2015_IsFalse()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowPresent_OptionObject2015_FormsNull_Error()
        {
            // Arrange
            string rowId = "1||1";
            var optionObject = new OptionObject2015
            {
                Forms = null
            };

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObject2015_RowIdNull_Error()
        {
            // Arrange
            string rowId = null;
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObject2015_RowIdEmpty_Error()
        {
            // Arrange
            string rowId = "";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = optionObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void IsRowPresent_FormObject_IsTrue()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject(rowId);
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };

            // Act
            bool actual = formObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_FormObject_IsFalse()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };

            // Act
            bool actual = formObject.IsRowPresent(rowId);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowPresent_FormObject_FormsNull_Error()
        {
            // Arrange
            string rowId = "1||1";
            FormObject formObject = null;

            // Act
            bool actual = formObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_FormObject_RowIdNull_Error()
        {
            // Arrange
            string rowId = null;
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };

            // Act
            bool actual = formObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_FormObject_RowIdEmpty_Error()
        {
            // Arrange
            string rowId = "";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };

            // Act
            bool actual = formObject.IsRowPresent(rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObjectHelpers_OptionObject_IsTrue()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject(rowId);
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObjectHelpers_OptionObject_IsFalse()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowPresent_OptionObjectHelpers_OptionObject_FormsNull_Error()
        {
            // Arrange
            string rowId = "1||1";
            var optionObject = new OptionObject
            {
                Forms = null
            };

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObjectHelpers_OptionObject_RowIdNull_Error()
        {
            // Arrange
            string rowId = null;
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObjectHelpers_OptionObject_RowIdEmpty_Error()
        {
            // Arrange
            string rowId = "";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2_IsTrue()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject(rowId);
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2_IsFalse()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2_FormsNull_Error()
        {
            // Arrange
            string rowId = "1||1";
            var optionObject = new OptionObject2
            {
                Forms = null
            };

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2_RowIdNull_Error()
        {
            // Arrange
            string rowId = null;
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2_RowIdEmpty_Error()
        {
            // Arrange
            string rowId = "";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2015_IsTrue()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject(rowId);
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2015_IsFalse()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2015_FormsNull_Error()
        {
            // Arrange
            string rowId = "1||1";
            var optionObject = new OptionObject2015
            {
                Forms = null
            };

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2015_RowIdNull_Error()
        {
            // Arrange
            string rowId = null;
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObjectHelpers_OptionObject2015_RowIdEmpty_Error()
        {
            // Arrange
            string rowId = "";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };
            var optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(optionObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void IsRowPresent_OptionObjectHelpers_FormObject_IsTrue()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject(rowId);
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(formObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRowPresent_OptionObjectHelpers_FormObject_IsFalse()
        {
            // Arrange
            string rowId = "1||1";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(formObject, rowId);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObjectHelpers_FormObject_FormsNull_Error()
        {
            // Arrange
            string rowId = "1||1";
            FormObject formObject = null;

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(formObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObjectHelpers_FormObject_RowIdNull_Error()
        {
            // Arrange
            string rowId = null;
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(formObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsRowPresent_OptionObjectHelpers_FormObject_RowIdEmpty_Error()
        {
            // Arrange
            string rowId = "";
            var rowObject = new RowObject();
            var formObject = new FormObject()
            {
                CurrentRow = rowObject
            };

            // Act
            bool actual = OptionObjectHelpers.IsRowPresent(formObject, rowId);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}
