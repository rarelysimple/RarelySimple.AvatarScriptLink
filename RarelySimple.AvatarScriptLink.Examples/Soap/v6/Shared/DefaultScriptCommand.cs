using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class DefaultScriptCommand : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;
        private readonly IParameter _parameter;

        public DefaultScriptCommand(IOptionObjectDecorator optionObjectDecorator, IParameter parameter)
        {
            _optionObject = optionObjectDecorator;
            _parameter = parameter;
        }

        public IOptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Alert, "No script was found with the name '" + _parameter.ScriptName + "'.");
        }
    }
}