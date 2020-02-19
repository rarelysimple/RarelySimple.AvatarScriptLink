using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class DefaultScriptCommand : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;
        private readonly string _scriptName;

        public DefaultScriptCommand(IOptionObjectDecorator optionObjectDecorator, string scriptName)
        {
            _optionObject = optionObjectDecorator;
            _scriptName = scriptName;
        }

        public IOptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Alert, "No script was found with the name '" + _scriptName + "'.");
        }
    }
}