using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v3.Shared
{
    public static class DefaultScript
    {
        public static OptionObject RunScript(OptionObject optionObject, string scriptName)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Alert, "No script was found with the name '" + scriptName + "'.");
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject, string scriptName)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Alert, "No script was found with the name '" + scriptName + "'.");
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject, string scriptName)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Alert, "No script was found with the name '" + scriptName + "'.");
        }
    }
}