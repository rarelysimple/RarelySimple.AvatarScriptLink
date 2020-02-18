using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v4.Shared
{
    public static class DefaultScript
    {
        public static OptionObject RunScript(OptionObject optionObject, string scriptName)
        {
            return RunScript(optionObject.ToOptionObject2015(), scriptName).ToOptionObject();
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject, string scriptName)
        {
            return RunScript(optionObject.ToOptionObject2015(), scriptName).ToOptionObject2();
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject, string scriptName)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Alert, "No script was found with the name '" + scriptName + "'.");
        }
    }
}