using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared
{
    public class GetFieldValueCommand : IRunScriptCommand
    {
        private readonly OptionObject2015 _optionObject;
        private readonly string _parameter;

        public GetFieldValueCommand(OptionObject2015 optionObject2015, string parameter)
        {
            _optionObject = optionObject2015;
            _parameter = parameter;
        }

        public OptionObject2015 Execute()
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