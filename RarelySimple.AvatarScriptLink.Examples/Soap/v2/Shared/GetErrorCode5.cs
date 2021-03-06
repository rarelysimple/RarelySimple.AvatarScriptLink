﻿using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v2.Shared
{
    public static class GetErrorCode5
    {
        public static OptionObject RunScript(OptionObject optionObject)
        {
            OptionObject returnOptionObject = new OptionObject();

            returnOptionObject.ErrorCode = 5;
            returnOptionObject.ErrorMesg = "https://rarelysimple.com";

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

        public static OptionObject2 RunScript(OptionObject2 optionObject)
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

        public static OptionObject2015 RunScript(OptionObject2015 optionObject)
        {
            OptionObject2015 returnOptionObject = new OptionObject2015();

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
            returnOptionObject.SessionToken = optionObject.SessionToken;

            return returnOptionObject;
        }
    }
}