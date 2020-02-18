using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v3.Shared
{
    public static class GetErrorCode3
    {
        public static OptionObject RunScript(OptionObject optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Informational, "The code means the RunScript was successful, however is providing an alert or informational notice.");
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Informational, "The code means the RunScript was successful, however is providing an alert or informational notice.");
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Informational, "The code means the RunScript was successful, however is providing an alert or informational notice.");
        }
    }
}