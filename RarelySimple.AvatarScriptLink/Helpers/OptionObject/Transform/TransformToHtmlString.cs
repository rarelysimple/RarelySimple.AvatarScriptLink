using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns <see cref="IOptionObject"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            return TransformToHtmlString(optionObject, false);
        }
        /// <summary>
        /// Returns <see cref="IOptionObject"/> as an HTML string with or without HTML headers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="includeHtmlHeaders"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IOptionObject optionObject, bool includeHtmlHeaders)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            StringBuilder sb = new StringBuilder();
            sb.Append(includeHtmlHeaders ? GetHtmlHeader() : "");
            sb.Append(GetPageHeader(optionObject.GetType().ToString()));
            sb.Append("<h2>Forms</h2>");
            foreach (FormObject formObject in optionObject.Forms)
            {
                sb.Append("<h3>Form<h3>");
                sb.Append(GetHtmlForObject(formObject, HtmlOutputType.Table));
                sb.Append("<h4>CurrentRow</h4>");
                sb.Append(GetHtmlForObject(formObject.CurrentRow, HtmlOutputType.Table));
                sb.Append("<h5>Fields</h5>");
                sb.Append("<table>");
                sb.Append(GetHtmlForObject(formObject.CurrentRow.Fields.First(), HtmlOutputType.TableHeaders));
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                }
                sb.Append("</table>");
                sb.Append("<h4>OtherRows</h4>");
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    sb.Append("<h5>Row</h5>");
                    sb.Append(GetHtmlForObject(rowObject, HtmlOutputType.Table));
                    sb.Append("<h6>Fields</h6>");
                    sb.Append("<table>");
                    sb.Append(GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders));
                    foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                    {
                        sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                    }
                    sb.Append("</table>");
                }
            }
            sb.Append(includeHtmlHeaders ? GetHtmlFooter() : "");
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IOptionObject2"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            return TransformToHtmlString(optionObject, false);
        }
        /// <summary>
        /// Returns <see cref="IOptionObject2"/> as an HTML string with or without HTML headers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="includeHtmlHeaders"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IOptionObject2 optionObject, bool includeHtmlHeaders)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            StringBuilder sb = new StringBuilder();
            sb.Append(includeHtmlHeaders ? GetHtmlHeader() : "");
            sb.Append(GetPageHeader(optionObject.GetType().ToString()));
            sb.Append("<h2>Forms</h2>");
            foreach (FormObject formObject in optionObject.Forms)
            {
                sb.Append("<h3>Form<h3>");
                sb.Append(GetHtmlForObject(formObject, HtmlOutputType.Table));
                sb.Append("<h4>CurrentRow</h4>");
                sb.Append(GetHtmlForObject(formObject.CurrentRow, HtmlOutputType.Table));
                sb.Append("<h5>Fields</h5>");
                sb.Append("<table>");
                sb.Append(GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders));
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                }
                sb.Append("</table>");
                sb.Append("<h4>OtherRows</h4>");
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    sb.Append("<h5>Row</h5>");
                    sb.Append(GetHtmlForObject(rowObject, HtmlOutputType.Table));
                    sb.Append("<h6>Fields</h6>");
                    sb.Append("<table>");
                    sb.Append(GetHtmlForObject(formObject.CurrentRow.Fields.First(), HtmlOutputType.TableHeaders));
                    foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                    {
                        sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                    }
                    sb.Append("</table>");
                }
            }
            sb.Append(includeHtmlHeaders ? GetHtmlFooter() : "");
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IOptionObject2015"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            return TransformToHtmlString(optionObject, false);
        }
        /// <summary>
        /// Returns <see cref="IOptionObject2015"/> as an HTML string with or without HTML headers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="includeHtmlHeaders"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IOptionObject2015 optionObject, bool includeHtmlHeaders)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            StringBuilder sb = new StringBuilder();
            sb.Append(includeHtmlHeaders ? GetHtmlHeader() : "");
            sb.Append(GetPageHeader(optionObject.GetType().ToString()));
            sb.Append("<h2>Forms</h2>");
            foreach (FormObject formObject in optionObject.Forms)
            {
                sb.Append("<h3>Form<h3>");
                sb.Append(GetHtmlForObject(formObject, HtmlOutputType.Table));
                sb.Append("<h4>CurrentRow</h4>");
                sb.Append(GetHtmlForObject(formObject.CurrentRow, HtmlOutputType.Table));
                sb.Append("<h5>Fields</h5>");
                sb.Append("<table>");
                sb.Append(GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders));
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                }
                sb.Append("</table>");
                sb.Append("<h4>OtherRows</h4>");
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    sb.Append("<h5>Row</h5>");
                    sb.Append(GetHtmlForObject(rowObject, HtmlOutputType.Table));
                    sb.Append("<h6>Fields</h6>");
                    sb.Append("<table>");
                    sb.Append(GetHtmlForObject(formObject.CurrentRow.Fields.First(), HtmlOutputType.TableHeaders));
                    foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                    {
                        sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                    }
                    sb.Append("</table>");
                }
            }
            sb.Append(includeHtmlHeaders ? GetHtmlFooter() : "");
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IFormObject"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            return TransformToHtmlString(formObject, false);
        }
        /// <summary>
        /// Returns <see cref="IFormObject"/> as an HTML string with or without HTML headers.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="includeHtmlHeaders"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IFormObject formObject, bool includeHtmlHeaders)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            StringBuilder sb = new StringBuilder();
            sb.Append(includeHtmlHeaders ? GetHtmlHeader() : "");
            sb.Append(GetPageHeader(formObject.GetType().ToString()));
            sb.Append(GetHtmlForObject(formObject, HtmlOutputType.Table));
            sb.Append("<h2>CurrentRow</h2>");
            sb.Append(GetHtmlForObject(formObject.CurrentRow, HtmlOutputType.Table));
            if (formObject.CurrentRow != null && formObject.CurrentRow.Fields != null)
            {
                sb.Append("<h3>Fields</h3>");
                sb.Append("<table>");
                sb.Append(GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders));
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                }
                sb.Append("</table>");
            }
            sb.Append("<h2>OtherRows</h2>");
            foreach (RowObject rowObject in formObject.OtherRows)
            {
                sb.Append("<h3>Row</h3>");
                sb.Append(GetHtmlForObject(rowObject, HtmlOutputType.Table));
                sb.Append("<h4>Fields</h4>");
                sb.Append("<table>");
                sb.Append(GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders));
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                }
                sb.Append("</table>");
            }
            sb.Append(includeHtmlHeaders ? GetHtmlFooter() : "");
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IRowObject"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IRowObject rowObject)
        {
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            return TransformToHtmlString(rowObject, false);
        }
        /// <summary>
        /// Returns <see cref="IRowObject"/> as an HTML string with or without HTML headers.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="includeHtmlHeaders"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IRowObject rowObject, bool includeHtmlHeaders)
        {
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            StringBuilder sb = new StringBuilder();
            sb.Append(includeHtmlHeaders ? GetHtmlHeader() : "");
            sb.Append(GetPageHeader(rowObject.GetType().ToString()));
            sb.Append(GetHtmlForObject(rowObject, HtmlOutputType.Table));
            if (rowObject.Fields != null)
            {
                sb.Append("<h2>Fields</h2>");
                sb.Append("<table>");
                sb.Append(GetHtmlForObject(rowObject.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders));
                foreach (FieldObject fieldObject in rowObject.Fields)
                {
                    sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                }
                sb.Append("</table>");
            }
            sb.Append(includeHtmlHeaders ? GetHtmlFooter() : "");
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IFieldObject"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            return TransformToHtmlString(fieldObject, false);
        }
        /// <summary>
        /// Returns <see cref="IFieldObject"/> as an HTML string with or without HTML headers.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <param name="includeHtmlHeaders"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IFieldObject fieldObject, bool includeHtmlHeaders)
        {
            if (fieldObject == null)
                throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            StringBuilder sb = new StringBuilder();
            sb.Append(includeHtmlHeaders ? GetHtmlHeader() : "");
            sb.Append(GetPageHeader(fieldObject.GetType().ToString()));
            sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.Table));
            sb.Append(includeHtmlHeaders ? GetHtmlFooter() : "");
            return sb.ToString();
        }

        #region HelperMethods
        private static string GetHtmlForObject(object rawObject, HtmlOutputType htmlOutputType)
        {
            if (rawObject == null) { return ""; }
            string html = "";
            Type type = rawObject.GetType();
            PropertyInfo[] properties = GetPropertyInfo(type);

            switch (htmlOutputType)
            {
                case HtmlOutputType.TableHeaders:
                    html += "<thead><tr>";
                    break;
                case HtmlOutputType.TableRow:
                    html += "<tr>";
                    break;
                case HtmlOutputType.Table:
                    html += "<table>" +
                            "<thead>" +
                            "<tr><th>Property</th><th>Value</th></tr>" +
                            "</thead>" +
                            "<tbody>";
                    break;
                case HtmlOutputType.OrderedList:
                    html += "<ol>";
                    break;
                case HtmlOutputType.UnorderedList:
                    html += "<ul>";
                    break;
                default:
                    break;
            }

            foreach (PropertyInfo property in properties)
            {
                switch (htmlOutputType)
                {
                    case HtmlOutputType.TableHeaders:
                        html += "<th>" + property.Name + "</th>";
                        break;
                    case HtmlOutputType.TableRow:
                        html += "<td>" + property.GetValue(rawObject).ToString() + "</td>";
                        break;
                    case HtmlOutputType.Table:
                        html += "<td>" + property.Name + "</td><td>" + property.GetValue(rawObject) + "</td>";
                        break;
                    case HtmlOutputType.OrderedList:
                    case HtmlOutputType.UnorderedList:
                        html += "<li>" + property.Name + "</td><td>" + property.GetValue(rawObject) + "</li>";
                        break;
                    default:
                        break;
                }
            }

            switch (htmlOutputType)
            {
                case HtmlOutputType.TableHeaders:
                    html += "</tr></thead>";
                    break;
                case HtmlOutputType.TableRow:
                    html += "</tr>";
                    break;
                case HtmlOutputType.Table:
                    html += "</tbody>" +
                            "</table>";
                    break;
                case HtmlOutputType.OrderedList:
                    html += "</ol>";
                    break;
                case HtmlOutputType.UnorderedList:
                    html += "</ul>";
                    break;
                default:
                    break;
            }

            return html;
        }

        private static PropertyInfo[] GetPropertyInfo(Type type)
        {
            return type.GetProperties(BindingFlags.Public);
        }

        private static string GetHtmlHeader()
        {
            string html = "<html>" +
                          "<head>" +
                          "</head>" +
                          "<body>";
            return html;
        }
        private static string GetPageHeader(string pageTitle)
        {
            string html = "<h1>" + pageTitle + "</h1>";
            return html;
        }
        private static string GetHtmlFooter()
        {
            string html = "</body>" +
                          "</html>";
            return html;
        }

        private enum HtmlOutputType
        {
            None,
            Table,
            TableRow,
            TableHeaders,
            UnorderedList,
            OrderedList
        }
        #endregion
    }
}
