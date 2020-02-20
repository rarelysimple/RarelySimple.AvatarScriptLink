using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class SetFieldValueCommand : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;
        private readonly IParameter _parameter;

        public SetFieldValueCommand(IOptionObjectDecorator optionObjectDecorator, IParameter parameter)
        {
            _optionObject = optionObjectDecorator;
            _parameter = parameter;
        }

        public IOptionObject2015 Execute()
        {
            string fieldNumber = _parameter.Count() >= 2 ? _parameter.ParameterList()[1] : "";
            if (_optionObject.IsFieldPresent(fieldNumber))
            {
                string fieldValue = _optionObject.GetFieldValue(fieldNumber);
                if (string.IsNullOrEmpty(fieldValue))
                    fieldValue = "I have set the FieldValue.";
                else
                    fieldValue += " (I have appended the FieldValue.)";
                _optionObject.SetFieldValue(fieldNumber, fieldValue);
            }
            return _optionObject.ToReturnOptionObject(ErrorCode.Success, "If FieldNumber '" + fieldNumber + "' is found in OptionObject, then it should be the only FieldObject returned. Otherwise, no Forms should be returned.");
        }
    }
}