﻿# AvatarScriptLink.NET

[![NuGet Latest](https://badgen.net/nuget/v/rarelysimple.avatarscriptlink/latest)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink/) [![NuGet Downloads](https://img.shields.io/nuget/dt/RarelySimple.AvatarScriptLink)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink/) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink&metric=alert_status)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink) [![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink) [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink) [![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink&metric=security_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink)

Essentially, AvatarScriptLink.NET is a framework for managing and manipulating [myAvatar](https://www.ntst.com/Solutions-and-Services/Offerings/myAvatar) ScriptLink OptionObjects. What it does is accelerate the development of clean and stable myAvatar ScriptLink-compatible APIs.

## Example

Most ScriptLink-compatible APIs are built with a local version of the NTST.ScriptLinkService.Objects library. Here's what a "Hello, World!" response might look like in this scenario.

```c#
[WebMethod]
public OptionObject RunScript(OptionObject optionObject, string parameter)
{
    OptionObject returnOptionObject = new OptionObject();

    returnOptionObject.ErrorCode = 3;
    returnOptionObject.ErrorMesg = "Hello, World!";

    returnOptionObject.EntityID = optionObject.EntityID;
    returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
    returnOptionObject.Facility = optionObject.Facility;
    returnOptionObject.OptionId = optionObject.OptionId;
    returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
    returnOptionObject.OptionUserId = optionObject.OptionUserId;
    returnOptionObject.SystemCode = optionObject.SystemCode;

    return returnOptionObject;
}
```

With AvatarScriptLink.NET, this same code can be simplified to:

```c#
[WebMethod]
public OptionObject RunScript(OptionObject optionObject, string parameter)
{
    return optionObject.ToReturnOptionObject(ErrorCode.Informational, "Hello, World!");
}
```

Likewise, to bring this same API up to the latest OptionObject version doesn't require accounting for the new properties. Just update the OptionObject version and import the new/updated WSDL into myAvatar.

```c#
[WebMethod]
public OptionObject2023 RunScript(OptionObject2023 optionObject, string parameter)
{
    return optionObject.ToReturnOptionObject(ErrorCode.Informational, "Hello, World!");
}
```

Check out [the documentation](https://scriptlink.rarelysimple.com/) to learn more.

## Licensing ##

AvatarScriptLink.NET is open source under the [MIT License](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/blob/master/LICENSE) and free for commercial use.