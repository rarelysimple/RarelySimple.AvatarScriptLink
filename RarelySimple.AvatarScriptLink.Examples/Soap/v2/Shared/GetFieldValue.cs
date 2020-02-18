using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v2.Shared
{
    public static class GetFieldValue
    {
        public static OptionObject RunScript(OptionObject optionObject, string parameter)
        {
            OptionObject returnOptionObject = new OptionObject();

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

        public static OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
        {
            OptionObject2015 returnOptionObject = new OptionObject2015();

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
            returnOptionObject.SessionToken = optionObject.SessionToken;

            return returnOptionObject;
        }
    }
}