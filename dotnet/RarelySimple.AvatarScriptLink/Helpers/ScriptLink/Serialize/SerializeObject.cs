﻿using Newtonsoft.Json;
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
        /// <returns></returns>
        public static string SerializeObject<T>(T objectToSerialize) where T : class
        {
            if (objectToSerialize == null)
                throw new ArgumentNullException(nameof(objectToSerialize), GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

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
        /// <returns></returns>
        public static string SerializeObjectToJsonString<T>(T objectToSerialize) where T : class
        {
            if (objectToSerialize == null)
                throw new ArgumentNullException(nameof(objectToSerialize), GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

            try
            {
                return JsonConvert.SerializeObject(objectToSerialize);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(GetLocalizedString("objectCannotBeSerializedJson", CultureInfo.CurrentCulture), ex.InnerException);
            }
        }
        /// <summary>
        /// Serializes an object as Xml.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialize">The object to be serialized.</param>
        /// <returns></returns>
        public static string SerializeObjectToXmlString<T>(T objectToSerialize) where T : class
        {
            if (objectToSerialize == null)
                throw new ArgumentNullException(nameof(objectToSerialize), GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

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
                throw new ArgumentException(GetLocalizedString("objectCannotBeSerializedXmlOrJson", CultureInfo.CurrentCulture), ex.InnerException);
            }
        }
    }
}
