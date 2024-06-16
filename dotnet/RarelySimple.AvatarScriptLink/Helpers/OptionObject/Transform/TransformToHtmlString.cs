using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        const string HtmlHeader = "<html><head></head><body>";
        const string HtmlFooter = "</body></html>";
        /// <summary>
        /// Returns <see cref="IOptionObject"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IOptionObject optionObject)
        {
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
            StringBuilder sb = new StringBuilder();
            sb.Append(GetHeader(optionObject.GetType().ToString(), includeHtmlHeaders));
            sb.Append(GetHtmlForObject(optionObject, HtmlOutputType.Table));
            sb.Append(AddFormTables(optionObject, 2));
            sb.Append(GetFooter(includeHtmlHeaders));
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IOptionObject2"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IOptionObject2 optionObject)
        {
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
            StringBuilder sb = new StringBuilder();
            sb.Append(GetHeader(optionObject.GetType().ToString(), includeHtmlHeaders));
            sb.Append(GetHtmlForObject(optionObject, HtmlOutputType.Table));
            sb.Append(AddFormTables(optionObject, 2));
            sb.Append(GetFooter(includeHtmlHeaders));
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IOptionObject2015"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IOptionObject2015 optionObject)
        {
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
            StringBuilder sb = new StringBuilder();
            sb.Append(GetHeader(optionObject.GetType().ToString(), includeHtmlHeaders));
            sb.Append(GetHtmlForObject(optionObject, HtmlOutputType.Table));
            sb.Append(AddFormTables(optionObject, 2));
            sb.Append(GetFooter(includeHtmlHeaders));
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IFormObject"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IFormObject formObject)
        {
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
            StringBuilder sb = new StringBuilder();
            sb.Append(GetHeader(formObject.GetType().ToString(), includeHtmlHeaders));
            sb.Append(GetHtmlForObject(formObject, HtmlOutputType.Table));
            sb.Append(AddRowTables(formObject, 2));
            sb.Append(GetFooter(includeHtmlHeaders));
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IRowObject"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IRowObject rowObject)
        {
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
            StringBuilder sb = new StringBuilder();
            sb.Append(GetHeader(rowObject.GetType().ToString(), includeHtmlHeaders));
            sb.Append(GetHtmlForObject(rowObject, HtmlOutputType.Table));
            sb.Append(AddFieldsTable(rowObject, 2));
            sb.Append(GetFooter(includeHtmlHeaders));
            return sb.ToString();
        }
        /// <summary>
        /// Returns <see cref="IFieldObject"/> as an HTML string without HTML headers.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static string TransformToHtmlString(IFieldObject fieldObject)
        {
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
            StringBuilder sb = new StringBuilder();
            sb.Append(GetHeader(fieldObject.GetType().ToString(), includeHtmlHeaders));
            sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.Table));
            sb.Append(GetFooter(includeHtmlHeaders));
            return sb.ToString();
        }

        #region HelperMethods

        private static string AddFormTables(IOptionObject optionObject, int headingLevel)
        {
            StringBuilder sb = new StringBuilder();
            if (optionObject != null)
            {
                sb.Append("<h{}>Forms</h{}>").Replace("{}", headingLevel.ToString());
                foreach (FormObject formObject in optionObject.Forms)
                {
                    sb.Append("<h{}>Form</h{}>").Replace("{}", (headingLevel - 1).ToString());
                    sb.Append(GetHtmlForObject(formObject, HtmlOutputType.Table));
                    sb.Append(AddRowTables(formObject, headingLevel - 2));
                }
            }
            return sb.ToString();
        }

        private static string AddRowTables(IFormObject formObject, int headingLevel)
        {
            StringBuilder sb = new StringBuilder();
            if (formObject != null)
            {
                sb.Append("<h{}>CurrentRow</h{}>").Replace("{}", headingLevel.ToString());
                sb.Append(GetHtmlForObject(formObject.CurrentRow, HtmlOutputType.Table));
                if (formObject.CurrentRow != null && formObject.CurrentRow.Fields != null)
                {
                    sb.Append(AddFieldsTable(formObject.CurrentRow, headingLevel - 1));
                }
                sb.Append("<h{}>OtherRows</h{}>").Replace("{}", headingLevel.ToString());
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    sb.Append("<h{}>Row</h{}>").Replace("{}", (headingLevel - 1).ToString());
                    sb.Append(GetHtmlForObject(rowObject, HtmlOutputType.Table));
                    sb.Append(AddFieldsTable(rowObject, headingLevel - 2));
                }
            }
            return sb.ToString();
        }

        private static string AddFieldsTable(IRowObject rowObject, int headingLevel)
        {
            StringBuilder sb = new StringBuilder();
            if (rowObject != null && rowObject.Fields != null)
            {
                sb.Append("<h{}>Fields</h{}>").Replace("{}", headingLevel.ToString());
                sb.Append("<table>");
                sb.Append(GetHtmlForObject(rowObject.Fields.FirstOrDefault(), HtmlOutputType.TableHeaders));
                foreach (FieldObject fieldObject in rowObject.Fields)
                {
                    sb.Append(GetHtmlForObject(fieldObject, HtmlOutputType.TableRow));
                }
                sb.Append("</table>");
            }
            return sb.ToString();
        }

        private static string GetHtmlForObject(object rawObject, HtmlOutputType htmlOutputType)
        {
            if (rawObject == null) { return ""; }
            StringBuilder sb = new StringBuilder();
            Type type = rawObject.GetType();
            PropertyInfo[] properties = GetPropertyInfo(type);
            sb.Append(GetHtmlHeaders(htmlOutputType));

            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(rawObject, null) != null) {
                    switch (htmlOutputType)
                    {
                        case HtmlOutputType.TableHeaders:
                            sb.Append("<th>").Append(property.Name).Append("</th>");
                            break;
                        case HtmlOutputType.TableRow:
                            sb.Append("<td>").Append(property.GetValue(rawObject, null).ToString()).Append("</td>");
                            break;
                        case HtmlOutputType.Table:
                            sb.Append("<tr><td>").Append(property.Name).Append("</td><td>").Append(property.GetValue(rawObject, null).ToString()).Append("</td></tr>");
                            break;
                        case HtmlOutputType.OrderedList:
                        case HtmlOutputType.UnorderedList:
                            sb.Append("<li>").Append(property.Name).Append(": ").Append(property.GetValue(rawObject, null).ToString()).Append("</li>");
                            break;
                        default:
                            break;
                    }
                }
            }

            sb.Append(GetHtmlFooters(htmlOutputType));
            return sb.ToString();
        }

        private static string GetHtmlHeaders(HtmlOutputType htmlOutputType)
        {
            StringBuilder sb = new StringBuilder();
            switch (htmlOutputType)
            {
                case HtmlOutputType.TableHeaders:
                    sb.Append("<thead><tr>");
                    break;
                case HtmlOutputType.TableRow:
                    sb.Append("<tr>");
                    break;
                case HtmlOutputType.Table:
                    sb.Append("<table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody>");
                    break;
                case HtmlOutputType.OrderedList:
                    sb.Append("<ol>");
                    break;
                case HtmlOutputType.UnorderedList:
                    sb.Append("<ul>");
                    break;
                default:
                    break;
            }
            return sb.ToString();
        }

        private static string GetHtmlFooters(HtmlOutputType htmlOutputType)
        {
            StringBuilder sb = new StringBuilder();
            switch (htmlOutputType)
            {
                case HtmlOutputType.TableHeaders:
                    sb.Append("</tr></thead>");
                    break;
                case HtmlOutputType.TableRow:
                    sb.Append("</tr>");
                    break;
                case HtmlOutputType.Table:
                    sb.Append("</tbody></table>");
                    break;
                case HtmlOutputType.OrderedList:
                    sb.Append("</ol>");
                    break;
                case HtmlOutputType.UnorderedList:
                    sb.Append("</ul>");
                    break;
                default:
                    break;
            }
            return sb.ToString();
        }

        private static PropertyInfo[] GetPropertyInfo(Type type)
        {
            return type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        private static string GetHeader(string type, bool includeHtmlHeaders)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(includeHtmlHeaders ? HtmlHeader : "");
            sb.Append(GetPageHeader(type));
            return sb.ToString();
        }

        private static string GetPageHeader(string pageTitle)
        {
            string html = "<h1>" + pageTitle + "</h1>";
            return html;
        }

        private static string GetFooter(bool includeHtmlHeaders)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(includeHtmlHeaders ? HtmlFooter : "");
            return sb.ToString();
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
