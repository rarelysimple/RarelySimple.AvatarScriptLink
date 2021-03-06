﻿using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class GetErrorCode2Command : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;

        public GetErrorCode2Command(IOptionObjectDecorator optionObjectDecorator)
        {
            _optionObject = optionObjectDecorator;
        }

        public IOptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Warning, "The code means the RunScript is providing a warning requiring a response from the user.");
        }
    }
}