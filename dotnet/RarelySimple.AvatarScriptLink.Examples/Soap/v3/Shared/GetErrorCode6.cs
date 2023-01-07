using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v3.Shared
{
    public static class GetErrorCode6
    {
        public static OptionObject RunScript(OptionObject optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.OpenForm, "[PM]USER100");
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.OpenForm, "[PM]USER100");
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.OpenForm, "[PM]USER100");
        }
    }
}