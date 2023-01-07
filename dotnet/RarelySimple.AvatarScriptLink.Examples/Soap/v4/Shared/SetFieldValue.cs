using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v4.Shared
{
    public static class SetFieldValue
    {
        public static OptionObject RunScript(OptionObject optionObject, string parameter)
        {
            return RunScript(optionObject.ToOptionObject2015(), parameter).ToOptionObject();
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject, string parameter)
        {
            return RunScript(optionObject.ToOptionObject2015(), parameter).ToOptionObject2();
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
        {
            if (optionObject.IsFieldPresent("123"))
            {
                string fieldValue = optionObject.GetFieldValue("123");
                if (string.IsNullOrEmpty(fieldValue))
                    fieldValue = "I have set the FieldValue.";
                else
                    fieldValue += " (I have appended the FieldValue.)";
                optionObject.SetFieldValue("123", fieldValue);
            }
            return optionObject.ToReturnOptionObject(ErrorCode.Success, "If FieldNumber 123 is found in OptionObject, then it should be the only FieldObject returned. Otherwise, no Forms should be returned.");
        }
    }
}