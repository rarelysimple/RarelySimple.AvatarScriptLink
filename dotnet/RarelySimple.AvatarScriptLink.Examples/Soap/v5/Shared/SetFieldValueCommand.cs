using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared
{
    public class SetFieldValueCommand : IRunScriptCommand
    {
        private readonly OptionObject2015 _optionObject;
        private readonly string _parameter;

        public SetFieldValueCommand(OptionObject2015 optionObject2015, string parameter)
        {
            _optionObject = optionObject2015;
            _parameter = parameter;
        }

        public OptionObject2015 Execute()
        {
            if (_optionObject.IsFieldPresent("123"))
            {
                string fieldValue = _optionObject.GetFieldValue("123");
                if (string.IsNullOrEmpty(fieldValue))
                    fieldValue = "I have set the FieldValue.";
                else
                    fieldValue += " (I have appended the FieldValue.)";
                _optionObject.SetFieldValue("123", fieldValue);
            }
            return _optionObject.ToReturnOptionObject(ErrorCode.Success, "If FieldNumber 123 is found in OptionObject, then it should be the only FieldObject returned. Otherwise, no Forms should be returned.");
        }
    }
}