﻿using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v4.Shared
{
    public static class GetErrorCode1
    {
        public static OptionObject RunScript(OptionObject optionObject)
        {
            return RunScript(optionObject.ToOptionObject2015()).ToOptionObject();
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject)
        {
            return RunScript(optionObject.ToOptionObject2015()).ToOptionObject2();
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Error, "The code means the RunScript experienced an Error and to stop processing.");
        }
    }
}