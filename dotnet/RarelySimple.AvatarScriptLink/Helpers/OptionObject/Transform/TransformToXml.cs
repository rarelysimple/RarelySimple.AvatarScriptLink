namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Transforms an object to a Xml-formatted string.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="objectToTransform">object to transform.</param>
        /// <returns></returns>
        public static string TransformToXml<T>(T objectToTransform)
        {
            return ScriptLinkHelpers.SerializeObjectToXmlString(objectToTransform);
        }
    }
}
