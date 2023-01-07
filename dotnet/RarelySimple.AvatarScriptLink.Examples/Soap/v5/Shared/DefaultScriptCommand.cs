using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared
{
    public class DefaultScriptCommand : IRunScriptCommand
    {
        private readonly OptionObject2015 _optionObject;
        private readonly string _scriptName;

        public DefaultScriptCommand(OptionObject2015 optionObject2015, string scriptName)
        {
            _optionObject = optionObject2015;
            _scriptName = scriptName;
        }

        public OptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Alert, "No script was found with the name '" + _scriptName + "'.");
        }
    }
}