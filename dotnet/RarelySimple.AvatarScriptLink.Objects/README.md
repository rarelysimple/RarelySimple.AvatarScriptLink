# RarelySimple.AvatarScriptLink.Objects

[![NuGet Latest](https://badgen.net/nuget/v/rarelysimple.avatarscriptlink.objects/latest)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink.Objects/) [![NuGet Downloads](https://img.shields.io/nuget/dt/RarelySimple.AvatarScriptLink.Objects)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink.Objects/) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Objects&metric=alert_status)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Objects) [![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Objects&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Objects) [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Objects&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Objects) [![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Objects&metric=security_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Objects)

RarelySimple.AvatarScriptLink.Objects provides the ScriptLink Object classes to help create Netsmart myAvatar-compatible ScriptLink APIs.

Note: This package only includes the object definitions. For helpers and utilities to accelerate your ScriptLink development we recommend using the [RarelySimple.AvatarScriptLink.Net](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink..Net/) package.

# Usage

```c#
// Uncomment annotation for .NET Framework *.asmx
// [WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
{
    OptionObject2015 returnOptionObject = new OptionObject2015();

    returnOptionObject.ErrorCode = 3;
    returnOptionObject.ErrorMesg = "Hello, World!";

    returnOptionObject.EntityID = optionObject.EntityID;
    returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
    returnOptionObject.Facility = optionObject.Facility;
    returnOptionObject.NamespaceName = optionObject.NamespaceName;
    returnOptionObject.OptionId = optionObject.OptionId;
    returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
    returnOptionObject.OptionUserId = optionObject.OptionUserId;
    returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
    returnOptionObject.ServerName = optionObject.ServerName;
    returnOptionObject.SessionToken = optionObject.SessionToken;
    returnOptionObject.SystemCode = optionObject.SystemCode;

    return returnOptionObject;
}
```

Check out [the documentation](https://scriptlink.rarelysimple.com/) to learn more.

## Licensing ##

AvatarScriptLink.NET is open source under the [MIT License](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/blob/master/LICENSE) and free for commercial use.
