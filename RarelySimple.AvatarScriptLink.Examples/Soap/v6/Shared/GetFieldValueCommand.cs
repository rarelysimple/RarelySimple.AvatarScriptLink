using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class GetFieldValueCommand : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;
        private readonly IParameter _parameter;

        public GetFieldValueCommand(IOptionObjectDecorator optionObjectDecorator, IParameter parameter)
        {
            _optionObject = optionObjectDecorator;
            _parameter = parameter;
        }

        public IOptionObject2015 Execute()
        {
            string fieldNumber = _parameter.Count() >= 2 ? _parameter.ParameterArray()[1] : "";
            string returnMessage = "The FieldValue is ";

            if (_optionObject.IsFieldPresent(fieldNumber))
                returnMessage += _optionObject.GetFieldValue(fieldNumber);

            returnMessage += ". Since no FieldObjects were modified, no Forms should be returned.";

            return _optionObject.ToReturnOptionObject(ErrorCode.Informational, returnMessage);
        }
    }
}