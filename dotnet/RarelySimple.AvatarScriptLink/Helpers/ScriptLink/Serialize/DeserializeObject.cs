using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Attempts to deserialize a string to specified object as Xml or Json (if Xml fails).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedString">The <see cref="string"/> to deserialize.</param>
        /// <returns></returns>
        public static T DeserializeObject<T>(string serializedString) where T : new()
        {
            if (string.IsNullOrEmpty(serializedString))
                throw new ArgumentNullException(nameof(serializedString), GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

            try { return DeserializeObjectFromXmlString<T>(serializedString); }
            catch { /* Not valid XML or doesn't match the object specification */ }
            try { return DeserializeObjectFromJsonString<T>(serializedString); }
            catch { /* Not valid JSON or doesn't match the object specification */ }

            throw new ArgumentException(GetLocalizedString("serializedStringIncompatibleFormat", CultureInfo.CurrentCulture));
        }
        /// <summary>
        /// Deserializes a Json string as specified object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">The Json <see cref="string"/> to deserialize.</param>
        /// <returns></returns>
        public static T DeserializeObjectFromJsonString<T>(string json)
        {
            if (string.IsNullOrEmpty(json))
                throw new ArgumentNullException(nameof(json), GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                throw new ArgumentException(GetLocalizedString("jsonCouldNotBeDeserialized", CultureInfo.CurrentCulture), nameof(json));
            }
        }
        /// <summary>
        /// Deserializes an Xml string as specified object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml">The Xml <see cref="string"/> to deserialize.</param>
        /// <returns></returns>
        public static T DeserializeObjectFromXmlString<T>(string xml)
        {
            if (string.IsNullOrEmpty(xml))
                throw new ArgumentNullException(nameof(xml), GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

            try
            {
                using (var stringReader = new StringReader(xml))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    XmlReader xmlReader = XmlReader.Create(stringReader);
                    var response = (T)serializer.Deserialize(xmlReader);
                    xmlReader.Dispose();
                    return response;
                }
            }
            catch
            {
                throw new ArgumentException(GetLocalizedString("xmlCouldNotBeDeserialized", CultureInfo.CurrentCulture), nameof(xml));
            }
        }
    }
}
