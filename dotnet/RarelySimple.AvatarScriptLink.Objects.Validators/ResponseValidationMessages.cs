namespace RarelySimple.AvatarScriptLink.Objects.Validators
{
    internal static class ResponseValidationMessages
    {
        internal const string FieldObjectIsNull = "FieldObject is null.";
        internal const string FieldNumberIsRequired = "FieldNumber is required.";
        internal const string FieldFlagMustBeZeroOrOne = "{0} must be \"0\" or \"1\" when set.";

        internal const string FormObjectIsNull = "FormObject is null.";
        internal const string FormIdIsRequired = "FormId is required.";
        internal const string OtherRowsCollectionMustNotBeNull = "OtherRows collection must not be null.";
        internal const string OtherRowsMustBeEmptyWhenMultipleIterationIsFalse = "OtherRows must be empty when MultipleIteration is false.";

        internal const string RowObjectIsNull = "RowObject is null.";
        internal const string RowIdIsRequired = "RowId is required.";
        internal const string RowActionMustBeAddEditDeleteOrEmpty = "RowAction must be ADD, EDIT, DELETE, or empty.";
        internal const string FieldsCollectionMustNotBeNull = "Fields collection must not be null.";
        internal const string RowActionIsRequiredWhenRowContainsFields = "RowAction is required when row contains fields.";

        internal const string OptionObjectIsNull = "OptionObject is null.";
        internal const string EntityIdIsRequired = "EntityID is required.";
        internal const string ErrorCodeMustBeFiniteBetween0And6 = "ErrorCode must be a finite number between 0 and 6.";
        internal const string ErrorCodeMustBeBetween0And6 = "ErrorCode must be between 0 and 6.";
        internal const string ErrorCodeMustBeIntegerBetween0And6 = "ErrorCode must be an integer between 0 and 6.";
        internal const string ErrorMesgMustBeEmptyWhenErrorCodeIs0 = "ErrorMesg must be empty when ErrorCode is 0.";
        internal const string ErrorMesgIsRequiredWhenErrorCodeIsBetween1And4 = "ErrorMesg is required when ErrorCode is between 1 and 4.";
        internal const string ErrorMesgMustBeValidAbsoluteUrlWhenErrorCodeIs5 = "ErrorMesg must be a valid absolute URL when ErrorCode is 5.";
        internal const string ErrorMesgMustBeValidOpenFormStringWhenErrorCodeIs6 = "ErrorMesg must be a valid OpenForm string when ErrorCode is 6.";
    }
}
