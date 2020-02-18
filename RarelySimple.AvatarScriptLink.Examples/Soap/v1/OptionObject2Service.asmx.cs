using NLog;
using RarelySimple.AvatarScriptLink.Objects;
using System.Collections.Generic;
using System.Web.Services;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v1
{
    /// <summary>
    /// Summary description for OptionObject2Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class OptionObject2Service : WebService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        [WebMethod]
        public string GetVersion()
        {
            return "v.1.0.0";
        }

        [WebMethod]
        public OptionObject2 RunScript(OptionObject2 optionObject, string parameter)
        {
            OptionObject2 returnOptionObject = new OptionObject2();
            string scriptName = parameter != null ? parameter.Split(',')[0] : "";
            logger.Debug("Script '" + scriptName + "' requested.");

            switch (scriptName)
            {
                case "GetErrorCode0":
                    returnOptionObject = GetErrorCode0(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode1":
                    returnOptionObject = GetErrorCode1(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode2":
                    returnOptionObject = GetErrorCode2(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode3":
                    returnOptionObject = GetErrorCode3(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode4":
                    returnOptionObject = GetErrorCode4(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode5":
                    returnOptionObject = GetErrorCode5(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode6":
                    returnOptionObject = GetErrorCode6(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetFieldValue":
                    returnOptionObject = GetFieldValue(optionObject, parameter);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "SetFieldValue":
                    returnOptionObject = SetFieldValue(optionObject, parameter);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                default:
                    logger.Warn("ScriptName '" + scriptName + "' does not match an existing script.");
                    returnOptionObject.ErrorCode = 3;
                    returnOptionObject.ErrorMesg = "No script was found with the name '" + parameter + "'.";

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
                    //returnOptionObject.SessionToken = optionObject.SessionToken;  // NOTE: This property will compile will be removed when serialized. 
                    break;
            }

            return returnOptionObject;
        }

        private OptionObject2 GetErrorCode0(OptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            returnOptionObject.ErrorCode = 0;
            returnOptionObject.ErrorMesg = "The code means the RunScript was successful.";

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

        private OptionObject2 GetErrorCode1(OptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            returnOptionObject.ErrorCode = 1;
            returnOptionObject.ErrorMesg = "The code means the RunScript experienced an Error and to stop processing.";

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

        private OptionObject2 GetErrorCode2(OptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            returnOptionObject.ErrorCode = 2;
            returnOptionObject.ErrorMesg = "The code means the RunScript is providing a warning requiring a response from the user.";

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

        private OptionObject2 GetErrorCode3(OptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            returnOptionObject.ErrorCode = 3;
            returnOptionObject.ErrorMesg = "The code means the RunScript was successful, however is providing an alert or informational notice.";

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

        private OptionObject2 GetErrorCode4(OptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            returnOptionObject.ErrorCode = 4;
            returnOptionObject.ErrorMesg = "The code means the RunScript is prompting a confirmation.";

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

        private OptionObject2 GetErrorCode5(OptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            returnOptionObject.ErrorCode = 5;
            returnOptionObject.ErrorMesg = "https://rarelysimple.com";

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

        private OptionObject2 GetErrorCode6(OptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            returnOptionObject.ErrorCode = 6;
            returnOptionObject.ErrorMesg = "[PM]USER100";

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

        private OptionObject2 GetFieldValue(OptionObject2 optionObject, string parameter)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            string[] parameters = parameter.Split(',');
            string fieldNumber = parameters.Length >= 2 ? parameters[1] : "";
            string returnMessage = "The FieldValue is ";

            foreach (var form in optionObject.Forms)
            {
                foreach (var currentField in form.CurrentRow.Fields)
                {
                    if (currentField.FieldNumber == fieldNumber)
                    {
                        returnMessage += currentField.FieldValue;
                    }
                }
            }

            returnOptionObject.ErrorCode = 3;
            returnOptionObject.ErrorMesg = returnMessage + ". Since no FieldObjects were modified, no Forms should be returned.";

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

        private OptionObject2 SetFieldValue(OptionObject2 optionObject, string parameter)
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
    }
}
