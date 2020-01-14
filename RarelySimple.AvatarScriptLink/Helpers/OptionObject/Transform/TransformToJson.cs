namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Transforms an object to a Json-formatted string.
        /// </summary>
        /// <param name="objectToSerialize"></param>
        /// <returns></returns>
        public static string TransformToJson(object objectToSerialize) => ScriptLinkHelpers.SerializeObjectToJsonString(objectToSerialize);
    }
}
