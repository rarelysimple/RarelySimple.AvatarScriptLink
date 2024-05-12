using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class TransformToHtmlStringTests
    {
        [TestMethod]
        public void TransformToHtmlString_OptionObject_AreEqual()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>EntityID</td><td>1</td></tr>");
            sb.Append("<tr><td>EpisodeNumber</td><td>0</td></tr>");
            sb.Append("<tr><td>ErrorCode</td><td>0</td></tr>");
            sb.Append("<tr><td>Forms</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.FormObject]</td></tr>");
            sb.Append("<tr><td>SystemCode</td><td>UAT</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>Forms</h2>");
            string expected = sb.ToString();

            string actual = optionObject.ToHtmlString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject_IsString()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject</h1><h2>Forms</h2>";

            var actual = optionObject.ToHtmlString();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject_DoesNotHaveHeaders()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = optionObject.ToHtmlString();

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject_OverrideDoesNotHaveHeaders()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = optionObject.ToHtmlString(false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject_OverrideDoesHaveHeaders()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = optionObject.ToHtmlString(true);

            Assert.IsTrue(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject_Helper_AreEqual()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>EntityID</td><td>1</td></tr>");
            sb.Append("<tr><td>EpisodeNumber</td><td>0</td></tr>");
            sb.Append("<tr><td>ErrorCode</td><td>0</td></tr>");
            sb.Append("<tr><td>Forms</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.FormObject]</td></tr>");
            sb.Append("<tr><td>SystemCode</td><td>UAT</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>Forms</h2>");
            string expected = sb.ToString();

            string actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject)optionObject);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject_Helper_IsString()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject</h1><h2>Forms</h2>";

            var actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject)optionObject);

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject_Helper_DoesNotHaveHeaders()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject)optionObject);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject_Helper_OverrideDoesNotHaveHeaders()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject)optionObject, false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject_Helper_OverrideDoesHaveHeaders()
        {
            OptionObject optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject)optionObject, true);

            Assert.IsTrue(actual.Contains("<html>"));
        }


        [TestMethod]
        public void TransformToHtmlString_OptionObject2_AreEqual()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject2</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>EntityID</td><td>1</td></tr>");
            sb.Append("<tr><td>EpisodeNumber</td><td>0</td></tr>");
            sb.Append("<tr><td>ErrorCode</td><td>0</td></tr>");
            sb.Append("<tr><td>Forms</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.FormObject]</td></tr>");
            sb.Append("<tr><td>SystemCode</td><td>UAT</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>Forms</h2>");
            string expected = sb.ToString();

            string actual = optionObject.ToHtmlString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2_IsString()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject2</h1><h2>Forms</h2>";

            var actual = optionObject.ToHtmlString();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2_DoesNotHaveHeaders()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = optionObject.ToHtmlString();

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2_OverrideDoesNotHaveHeaders()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = optionObject.ToHtmlString(false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2_OverrideDoesHaveHeaders()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = optionObject.ToHtmlString(true);

            Assert.IsTrue(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2_Helper_AreEqual()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject2</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>EntityID</td><td>1</td></tr>");
            sb.Append("<tr><td>EpisodeNumber</td><td>0</td></tr>");
            sb.Append("<tr><td>ErrorCode</td><td>0</td></tr>");
            sb.Append("<tr><td>Forms</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.FormObject]</td></tr>");
            sb.Append("<tr><td>SystemCode</td><td>UAT</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>Forms</h2>");
            string expected = sb.ToString();

            string actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject2)optionObject);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2_Helper_IsString()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject2</h1><h2>Forms</h2>";

            var actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject2)optionObject);

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2_Helper_DoesNotHaveHeaders()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject2)optionObject);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2_Helper_OverrideDoesNotHaveHeaders()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject2)optionObject, false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2_Helper_OverrideDoesHaveHeaders()
        {
            OptionObject2 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString((IOptionObject2)optionObject, true);

            Assert.IsTrue(actual.Contains("<html>"));
        }



        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_AreEqual()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject2015</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>EntityID</td><td>1</td></tr>");
            sb.Append("<tr><td>EpisodeNumber</td><td>0</td></tr>");
            sb.Append("<tr><td>ErrorCode</td><td>0</td></tr>");
            sb.Append("<tr><td>Forms</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.FormObject]</td></tr>");
            sb.Append("<tr><td>SystemCode</td><td>UAT</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>Forms</h2>");
            string expected = sb.ToString();

            string actual = optionObject.ToHtmlString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_IsString()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject2015</h1><h2>Forms</h2>";

            var actual = optionObject.ToHtmlString();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_DoesNotHaveHeaders()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = optionObject.ToHtmlString();

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_OverrideDoesNotHaveHeaders()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = optionObject.ToHtmlString(false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_OverrideDoesHaveHeaders()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = optionObject.ToHtmlString(true);

            Assert.IsTrue(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_Helper_AreEqual()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject2015</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>EntityID</td><td>1</td></tr>");
            sb.Append("<tr><td>EpisodeNumber</td><td>0</td></tr>");
            sb.Append("<tr><td>ErrorCode</td><td>0</td></tr>");
            sb.Append("<tr><td>Forms</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.FormObject]</td></tr>");
            sb.Append("<tr><td>SystemCode</td><td>UAT</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>Forms</h2>");
            string expected = sb.ToString();

            string actual = OptionObjectHelpers.TransformToHtmlString(optionObject);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_Helper_IsString()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.OptionObject2015</h1><h2>Forms</h2>";

            var actual = OptionObjectHelpers.TransformToHtmlString(optionObject);

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_Helper_DoesNotHaveHeaders()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(optionObject);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_Helper_OverrideDoesNotHaveHeaders()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(optionObject, false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_OptionObject2015_Helper_OverrideDoesHaveHeaders()
        {
            OptionObject2015 optionObject = new()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(optionObject, true);

            Assert.IsTrue(actual.Contains("<html>"));
        }



        [TestMethod]
        public void TransformToHtmlString_FormObject_IsString()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.FormObject</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>FormId</td><td>1</td></tr>");
            sb.Append("<tr><td>MultipleIteration</td><td>False</td></tr>");
            sb.Append("<tr><td>OtherRows</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.RowObject]</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>CurrentRow</h2>");
            sb.Append("<h2>OtherRows</h2>");
            string expected = sb.ToString();

            string actual = formObject.ToHtmlString();

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_FormObject_DoesNotHaveHeaders()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };

            string actual = formObject.ToHtmlString();

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FormObject_OverrideDoesNotHaveHeaders()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };

            string actual = formObject.ToHtmlString(false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FormObject_OverrideDoesHaveHeaders()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };

            string actual = formObject.ToHtmlString(true);

            Assert.IsTrue(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FormObject_Helper_AreEqual()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.FormObject</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>FormId</td><td>1</td></tr>");
            sb.Append("<tr><td>MultipleIteration</td><td>False</td></tr>");
            sb.Append("<tr><td>OtherRows</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.RowObject]</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>CurrentRow</h2>");
            sb.Append("<h2>OtherRows</h2>");
            string expected = sb.ToString();

            string actual = OptionObjectHelpers.TransformToHtmlString(formObject);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_FormObject_Helper_IsString()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.FormObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table><h2>CurrentRow</h2><h2>OtherRows</h2>";

            var actual = OptionObjectHelpers.TransformToHtmlString(formObject);

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_FormObject_Helper_DoesNotHaveHeaders()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(formObject);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FormObject_Helper_OverrideDoesNotHaveHeaders()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(formObject, false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FormObject_Helper_OverrideDoesHaveHeaders()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(formObject, true);

            Assert.IsTrue(actual.Contains("<html>"));
        }



        [TestMethod]
        public void TransformToHtmlString_RowObject_AreEqual()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.RowObject</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>Fields</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.FieldObject]</td></tr>");
            sb.Append("<tr><td>RowId</td><td>1</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>Fields</h2>");
            sb.Append("<table></table>");
            string expected = sb.ToString();

            string actual = rowObject.ToHtmlString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_RowObject_IsString()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.RowObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table><h2>Fields</h2><table></table>";

            var actual = rowObject.ToHtmlString();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_RowObject_DoesNotHaveHeaders()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };

            string actual = rowObject.ToHtmlString();

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_RowObject_OverrideDoesNotHaveHeaders()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };

            string actual = rowObject.ToHtmlString(false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_RowObject_OverrideDoesHaveHeaders()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };

            string actual = rowObject.ToHtmlString(true);

            Assert.IsTrue(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_RowObject_Helper_AreEqual()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.RowObject</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>Fields</td><td>System.Collections.Generic.List`1[RarelySimple.AvatarScriptLink.Objects.FieldObject]</td></tr>");
            sb.Append("<tr><td>RowId</td><td>1</td></tr>");
            sb.Append("</tbody></table>");
            sb.Append("<h2>Fields</h2>");
            sb.Append("<table></table>");
            string expected = sb.ToString();

            string actual = OptionObjectHelpers.TransformToHtmlString(rowObject);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_RowObject_Helper_IsString()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.RowObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table><h2>Fields</h2><table></table>";

            var actual = OptionObjectHelpers.TransformToHtmlString(rowObject);

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_RowObject_Helper_DoesNotHaveHeaders()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(rowObject);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_RowObject_Helper_OverrideDoesNotHaveHeaders()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(rowObject, false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_RowObject_Helper_OverrideDoesHaveHeaders()
        {
            RowObject rowObject = new()
            {
                RowId = "1"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(rowObject, true);

            Assert.IsTrue(actual.Contains("<html>"));
        }



        [TestMethod]
        public void TransformToHtmlString_FieldObject_AreEqual()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.FieldObject</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>Enabled</td><td></td></tr>");
            sb.Append("<tr><td>FieldNumber</td><td>1</td></tr>");
            sb.Append("<tr><td>FieldValue</td><td>TEST</td></tr>");
            sb.Append("<tr><td>Lock</td><td></td></tr>");
            sb.Append("<tr><td>Required</td><td></td></tr>");
            sb.Append("<tr><td>Modified</td><td>False</td></tr>");
            sb.Append("</tbody></table>");
            string expected = sb.ToString();

            string actual = fieldObject.ToHtmlString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_FieldObject_IsString()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.FieldObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table>";

            var actual = fieldObject.ToHtmlString();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_FieldObject_DoesNotHaveHeaders()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };

            string actual = fieldObject.ToHtmlString();

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FieldObject_OverrideDoesNotHaveHeaders()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };

            string actual = fieldObject.ToHtmlString(false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FieldObject_OverrideDoesHaveHeaders()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };

            string actual = fieldObject.ToHtmlString(true);

            Assert.IsTrue(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FieldObject_Helper_AreEqual()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            StringBuilder sb = new();
            sb.Append("<h1>RarelySimple.AvatarScriptLink.Objects.FieldObject</h1>");
            sb.Append("<table><thead>");
            sb.Append("<tr><th>Property</th><th>Value</th></tr>");
            sb.Append("</thead><tbody>");
            sb.Append("<tr><td>Enabled</td><td></td></tr>");
            sb.Append("<tr><td>FieldNumber</td><td>1</td></tr>");
            sb.Append("<tr><td>FieldValue</td><td>TEST</td></tr>");
            sb.Append("<tr><td>Lock</td><td></td></tr>");
            sb.Append("<tr><td>Required</td><td></td></tr>");
            sb.Append("<tr><td>Modified</td><td>False</td></tr>");
            sb.Append("</tbody></table>");
            string expected = sb.ToString();

            string actual = OptionObjectHelpers.TransformToHtmlString(fieldObject);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TransformToHtmlString_FieldObject_Helper_IsString()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            string expected = "<h1>RarelySimple.AvatarScriptLink.Objects.FieldObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table>";

            var actual = OptionObjectHelpers.TransformToHtmlString(fieldObject);

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void TransformToHtmlString_FieldObject_Helper_DoesNotHaveHeaders()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(fieldObject);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FieldObject_Helper_OverrideDoesNotHaveHeaders()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(fieldObject, false);

            Assert.IsFalse(actual.Contains("<html>"));
        }

        [TestMethod]
        public void TransformToHtmlString_FieldObject_Helper_OverrideDoesHaveHeaders()
        {
            FieldObject fieldObject = new()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };

            string actual = OptionObjectHelpers.TransformToHtmlString(fieldObject, true);

            Assert.IsTrue(actual.Contains("<html>"));
        }
    }
}
