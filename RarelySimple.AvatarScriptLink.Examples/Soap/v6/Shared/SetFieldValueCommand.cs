using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class SetFieldValueCommand : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;
        private readonly string _parameter;

        public SetFieldValueCommand(IOptionObjectDecorator optionObjectDecorator, string parameter)
        {
            _optionObject = optionObjectDecorator;
            _parameter = parameter;
        }

        public IOptionObject2015 Execute()
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