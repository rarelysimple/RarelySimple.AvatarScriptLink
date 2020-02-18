using RarelySimple.AvatarScriptLink.Objects;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v2.Shared
{
    public static class SetFieldValue
    {
        public static OptionObject RunScript(OptionObject optionObject, string parameter)
        {
            OptionObject returnOptionObject = new OptionObject();
            List<FormObject> forms = new List<FormObject>();

            foreach (var form in optionObject.Forms)
            {
                List<FieldObject> fields = new List<FieldObject>();
                foreach (var currentField in form.CurrentRow.Fields)
                {
                    switch (currentField.FieldNumber)
                    {
                        case "123":
                            if (string.IsNullOrEmpty(currentField.FieldValue))
                            {
                                FieldObject fieldObject = new FieldObject()
                                {
                                    Enabled = currentField.Enabled,
                                    FieldNumber = currentField.FieldNumber,
                                    FieldValue = "I have set the FieldValue.",
                                    Lock = currentField.Lock,
                                    Required = currentField.Required
                                };
                                fields.Add(fieldObject);
                            }
                            else
                            {
                                FieldObject fieldObject = new FieldObject()
                                {
                                    Enabled = currentField.Enabled,
                                    FieldNumber = currentField.FieldNumber,
                                    FieldValue = currentField.FieldValue + " (I have appended the FieldValue.)",
                                    Lock = currentField.Lock,
                                    Required = currentField.Required
                                };
                                fields.Add(fieldObject);
                            }
                            break;
                        default:
                            break;
                    }
                }
                if (fields.Count > 0)
                {
                    RowObject rowObject = new RowObject()
                    {
                        Fields = fields,
                        ParentRowId = form.CurrentRow.ParentRowId,
                        RowAction = "EDIT",
                        RowId = form.CurrentRow.RowId,
                    };
                    FormObject formObject = new FormObject()
                    {
                        CurrentRow = rowObject,
                        FormId = form.FormId,
                        MultipleIteration = form.MultipleIteration
                    };
                    forms.Add(formObject);
                }
            }
            returnOptionObject.Forms = forms;

            returnOptionObject.ErrorCode = 0;
            returnOptionObject.ErrorMesg = "If FieldNumber 123 is found in OptionObject, then it should be the only FieldObject returned. Otherwise, no Forms should be returned.";

            returnOptionObject.EntityID = optionObject.EntityID;
            returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
            returnOptionObject.Facility = optionObject.Facility;
            //returnOptionObject.NamespaceName = optionObject.NamespaceName;
            returnOptionObject.OptionId = optionObject.OptionId;
            returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
            returnOptionObject.OptionUserId = optionObject.OptionUserId;
            //returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
            //returnOptionObject.ServerName = optionObject.ServerName;
            returnOptionObject.SystemCode = optionObject.SystemCode;
            //returnOptionObject.SessionToken = optionObject.SessionToken;

            return returnOptionObject;
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject, string parameter)
        {
            OptionObject2 returnOptionObject = new OptionObject2();
            List<FormObject> forms = new List<FormObject>();

            foreach (var form in optionObject.Forms)
            {
                List<FieldObject> fields = new List<FieldObject>();
                foreach (var currentField in form.CurrentRow.Fields)
                {
                    switch (currentField.FieldNumber)
                    {
                        case "123":
                            if (string.IsNullOrEmpty(currentField.FieldValue))
                            {
                                FieldObject fieldObject = new FieldObject()
                                {
                                    Enabled = currentField.Enabled,
                                    FieldNumber = currentField.FieldNumber,
                                    FieldValue = "I have set the FieldValue.",
                                    Lock = currentField.Lock,
                                    Required = currentField.Required
                                };
                                fields.Add(fieldObject);
                            }
                            else
                            {
                                FieldObject fieldObject = new FieldObject()
                                {
                                    Enabled = currentField.Enabled,
                                    FieldNumber = currentField.FieldNumber,
                                    FieldValue = currentField.FieldValue + " (I have appended the FieldValue.)",
                                    Lock = currentField.Lock,
                                    Required = currentField.Required
                                };
                                fields.Add(fieldObject);
                            }
                            break;
                        default:
                            break;
                    }
                }
                if (fields.Count > 0)
                {
                    RowObject rowObject = new RowObject()
                    {
                        Fields = fields,
                        ParentRowId = form.CurrentRow.ParentRowId,
                        RowAction = "EDIT",
                        RowId = form.CurrentRow.RowId,
                    };
                    FormObject formObject = new FormObject()
                    {
                        CurrentRow = rowObject,
                        FormId = form.FormId,
                        MultipleIteration = form.MultipleIteration
                    };
                    forms.Add(formObject);
                }
            }
            returnOptionObject.Forms = forms;

            returnOptionObject.ErrorCode = 0;
            returnOptionObject.ErrorMesg = "If FieldNumber 123 is found in OptionObject, then it should be the only FieldObject returned. Otherwise, no Forms should be returned.";

            returnOptionObject.EntityID = optionObject.EntityID;
            returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
            returnOptionObject.Facility = optionObject.Facility;
            returnOptionObject.NamespaceName = optionObject.NamespaceName;
            returnOptionObject.OptionId = optionObject.OptionId;
            returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
            returnOptionObject.OptionUserId = optionObject.OptionUserId;
            returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
            returnOptionObject.ServerName = optionObject.ServerName;
            returnOptionObject.SystemCode = optionObject.SystemCode;
            //returnOptionObject.SessionToken = optionObject.SessionToken;

            return returnOptionObject;
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
        {
            OptionObject2015 returnOptionObject = new OptionObject2015();
            List<FormObject> forms = new List<FormObject>();

            foreach (var form in optionObject.Forms)
            {
                List<FieldObject> fields = new List<FieldObject>();
                foreach (var currentField in form.CurrentRow.Fields)
                {
                    switch (currentField.FieldNumber)
                    {
                        case "123":
                            if (string.IsNullOrEmpty(currentField.FieldValue))
                            {
                                FieldObject fieldObject = new FieldObject()
                                {
                                    Enabled = currentField.Enabled,
                                    FieldNumber = currentField.FieldNumber,
                                    FieldValue = "I have set the FieldValue.",
                                    Lock = currentField.Lock,
                                    Required = currentField.Required
                                };
                                fields.Add(fieldObject);
                            }
                            else
                            {
                                FieldObject fieldObject = new FieldObject()
                                {
                                    Enabled = currentField.Enabled,
                                    FieldNumber = currentField.FieldNumber,
                                    FieldValue = currentField.FieldValue + " (I have appended the FieldValue.)",
                                    Lock = currentField.Lock,
                                    Required = currentField.Required
                                };
                                fields.Add(fieldObject);
                            }
                            break;
                        default:
                            break;
                    }
                }
                if (fields.Count > 0)
                {
                    RowObject rowObject = new RowObject()
                    {
                        Fields = fields,
                        ParentRowId = form.CurrentRow.ParentRowId,
                        RowAction = "EDIT",
                        RowId = form.CurrentRow.RowId,
                    };
                    FormObject formObject = new FormObject()
                    {
                        CurrentRow = rowObject,
                        FormId = form.FormId,
                        MultipleIteration = form.MultipleIteration
                    };
                    forms.Add(formObject);
                }
            }
            returnOptionObject.Forms = forms;

            returnOptionObject.ErrorCode = 0;
            returnOptionObject.ErrorMesg = "If FieldNumber 123 is found in OptionObject, then it should be the only FieldObject returned. Otherwise, no Forms should be returned.";

            returnOptionObject.EntityID = optionObject.EntityID;
            returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
            returnOptionObject.Facility = optionObject.Facility;
            returnOptionObject.NamespaceName = optionObject.NamespaceName;
            returnOptionObject.OptionId = optionObject.OptionId;
            returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
            returnOptionObject.OptionUserId = optionObject.OptionUserId;
            returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
            returnOptionObject.ServerName = optionObject.ServerName;
            returnOptionObject.SystemCode = optionObject.SystemCode;
            returnOptionObject.SessionToken = optionObject.SessionToken;

            return returnOptionObject;
        }
    }
}