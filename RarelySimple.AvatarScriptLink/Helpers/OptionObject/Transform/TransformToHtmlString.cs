using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

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
            string html = "";
            html += includeHtmlHeaders ? GetHtmlHeader() : "";
            html += GetPageHeader(optionObject.GetType().ToString());
            html += "<h2>Forms</h2>";
            foreach (FormObject formObject in optionObject.Forms)
            {
                html += "<h3>Form<h3>";
                html += GetHtmlForObject(formObject, HtmlOutputType.Table);
                html += "<h4>CurrentRow</h4>";
                html += GetHtmlForObject(formObject.CurrentRow, HtmlOutputType.Table);
                html += "<h5>Fields</h5>";
                html += "<table>";
                html += GetHtmlForObject(formObject.CurrentRow.Fields.First(), HtmlOutputType.TableHeaders);
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    html += GetHtmlForObject(fieldObject, HtmlOutputType.TableRow);
                }
                html += "</table>";
                html += "<h4>OtherRows</h4>";
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    html += "<h5>Row</h5>";
                    html += GetHtmlForObject(rowObject, HtmlOutputType.Table);
                    html += "<h6>Fields</h6>";
                    html += "<table>";
                    html += GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders);
                    foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                    {
                        html += GetHtmlForObject(fieldObject, HtmlOutputType.TableRow);
                    }
                    html += "</table>";
                }
            }
            html += includeHtmlHeaders ? GetHtmlFooter() : "";
            return html;
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
            string html = "";
            html += includeHtmlHeaders ? GetHtmlHeader() : "";
            html += GetPageHeader(optionObject.GetType().ToString());
            html += "<h2>Forms</h2>";
            foreach (FormObject formObject in optionObject.Forms)
            {
                html += "<h3>Form<h3>";
                html += GetHtmlForObject(formObject, HtmlOutputType.Table);
                html += "<h4>CurrentRow</h4>";
                html += GetHtmlForObject(formObject.CurrentRow, HtmlOutputType.Table);
                html += "<h5>Fields</h5>";
                html += "<table>";
                html += GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders);
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    html += GetHtmlForObject(fieldObject, HtmlOutputType.TableRow);
                }
                html += "</table>";
                html += "<h4>OtherRows</h4>";
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    html += "<h5>Row</h5>";
                    html += GetHtmlForObject(rowObject, HtmlOutputType.Table);
                    html += "<h6>Fields</h6>";
                    html += "<table>";
                    html += GetHtmlForObject(formObject.CurrentRow.Fields.First(), HtmlOutputType.TableHeaders);
                    foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                    {
                        html += GetHtmlForObject(fieldObject, HtmlOutputType.TableRow);
                    }
                    html += "</table>";
                }
            }
            html += includeHtmlHeaders ? GetHtmlFooter() : "";
            return html;
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
            string html = "";
            html += includeHtmlHeaders ? GetHtmlHeader() : "";
            html += GetPageHeader(optionObject.GetType().ToString());
            html += "<h2>Forms</h2>";
            foreach (FormObject formObject in optionObject.Forms)
            {
                html += "<h3>Form<h3>";
                html += GetHtmlForObject(formObject, HtmlOutputType.Table);
                html += "<h4>CurrentRow</h4>";
                html += GetHtmlForObject(formObject.CurrentRow, HtmlOutputType.Table);
                html += "<h5>Fields</h5>";
                html += "<table>";
                html += GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders);
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    html += GetHtmlForObject(fieldObject, HtmlOutputType.TableRow);
                }
                html += "</table>";
                html += "<h4>OtherRows</h4>";
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    html += "<h5>Row</h5>";
                    html += GetHtmlForObject(rowObject, HtmlOutputType.Table);
                    html += "<h6>Fields</h6>";
                    html += "<table>";
                    html += GetHtmlForObject(formObject.CurrentRow.Fields.First(), HtmlOutputType.TableHeaders);
                    foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                    {
                        html += GetHtmlForObject(fieldObject, HtmlOutputType.TableRow);
                    }
                    html += "</table>";
                }
            }
            html += includeHtmlHeaders ? GetHtmlFooter() : "";
            return html;
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
            string html = "";
            html += includeHtmlHeaders ? GetHtmlHeader() : "";
            html += GetPageHeader(formObject.GetType().ToString());
            html += GetHtmlForObject(formObject, HtmlOutputType.Table);
            html += "<h2>CurrentRow</h2>";
            html += GetHtmlForObject(formObject.CurrentRow, HtmlOutputType.Table);
            if (formObject.CurrentRow != null && formObject.CurrentRow.Fields != null)
            {
                html += "<h3>Fields</h3>";
                html += "<table>";
                html += GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders);
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    html += GetHtmlForObject(fieldObject, HtmlOutputType.TableRow);
                }
                html += "</table>";
            }
            html += "<h2>OtherRows</h2>";
            foreach (RowObject rowObject in formObject.OtherRows)
            {
                html += "<h3>Row</h3>";
                html += GetHtmlForObject(rowObject, HtmlOutputType.Table);
                html += "<h4>Fields</h4>";
                html += "<table>";
                html += GetHtmlForObject(formObject.CurrentRow.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders);
                foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                {
                    html += GetHtmlForObject(fieldObject, HtmlOutputType.TableRow);
                }
                html += "</table>";
            }
            html += includeHtmlHeaders ? GetHtmlFooter() : "";
            return html;
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
            string html = "";
            html += includeHtmlHeaders ? GetHtmlHeader() : "";
            html += GetPageHeader(rowObject.GetType().ToString());
            html += GetHtmlForObject(rowObject, HtmlOutputType.Table);
            if (rowObject.Fields != null)
            {
                html += "<h2>Fields</h2>";
                html += "<table>";
                html += GetHtmlForObject(rowObject.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders);
                foreach (FieldObject fieldObject in rowObject.Fields)
                {
                    html += GetHtmlForObject(fieldObject, HtmlOutputType.TableRow);
                }
                html += "</table>";
            }
            html += includeHtmlHeaders ? GetHtmlFooter() : "";
            return html;
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
            string html = "";
            html += includeHtmlHeaders ? GetHtmlHeader() : "";
            html += GetPageHeader(fieldObject.GetType().ToString());
            html += GetHtmlForObject(fieldObject, HtmlOutputType.Table);
            html += includeHtmlHeaders ? GetHtmlFooter() : "";
            return html;
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
