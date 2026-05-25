using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class ScriptLinkHelpers
    {
        private const string ParameterCannotBeNull = "parameterCannotBeNull";
        /// <summary>
        /// Serializes an object as Xml.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialize">The object to be serialized.</param>
        /// <exception cref="ArgumentException">Thrown when the object cannot be serialized.</exception>
        /// <returns></returns>
        public static string SerializeObject<T>(T objectToSerialize)
        {
            try 
            { 
                return SerializeObjectToXmlString<T>(objectToSerialize); 
            }
            catch 
            {
                throw new ArgumentException(GetLocalizedString("objectCannotBeSerializedXmlOrJson", CultureInfo.CurrentCulture));
            }
        }
        /// <summary>
        /// Serializes an object as Json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialize">The object to be serialized.</param>
        /// <exception cref="ArgumentException">Thrown when the object cannot be serialized to JSON.</exception>
        /// <returns></returns>
        public static string SerializeObjectToJsonString<T>(T objectToSerialize)
        {
            try
            {
                return JsonConvert.SerializeObject(objectToSerialize);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(GetLocalizedString("objectCannotBeSerializedJson", CultureInfo.CurrentCulture), ex);
            }
        }
        /// <summary>
        /// Serializes an object as Xml.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialize">The object to be serialized.</param>
        /// <exception cref="ArgumentException">Thrown when the object cannot be serialized to XML.</exception>
        /// <returns></returns>
        public static string SerializeObjectToXmlString<T>(T objectToSerialize)
        {
            try
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(stringWriter, objectToSerialize);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(GetLocalizedString("objectCannotBeSerializedXmlOrJson", CultureInfo.CurrentCulture), ex);
            }
        }
    }
}
