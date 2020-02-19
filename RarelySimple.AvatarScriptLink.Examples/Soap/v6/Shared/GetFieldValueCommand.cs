using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class GetFieldValueCommand : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;
        private readonly string _parameter;

        public GetFieldValueCommand(IOptionObjectDecorator optionObjectDecorator, string parameter)
        {
            _optionObject = optionObjectDecorator;
            _parameter = parameter;
        }

        public IOptionObject2015 Execute()
        {
            string[] parameters = _parameter.Split(',');
            string fieldNumber = parameters.Length >= 2 ? parameters[1] : "";
            string returnMessage = "The FieldValue is ";

            if (_optionObject.IsFieldPresent(fieldNumber))
                returnMessage += _optionObject.GetFieldValue(fieldNumber);

            returnMessage += ". Since no FieldObjects were modified, no Forms should be returned.";

            return _optionObject.ToReturnOptionObject(ErrorCode.Informational, returnMessage);
        }
    }
}