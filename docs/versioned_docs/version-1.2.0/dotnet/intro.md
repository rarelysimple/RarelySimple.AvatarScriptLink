---
title: AvatarScriptLink.NET
image: ./AvatarScriptLink.NET.png
sidebar_position: 1
---

# AvatarScriptLink.NET

AvatarScriptLink.NET is a framework for managing and manipulating [Netsmart myAvatar](https://www.ntst.com/Solutions-and-Services/Offerings/myAvatar) ScriptLink OptionObjects. What it does is accelerate the development of clean and stable myAvatar ScriptLink-compatible APIs.

Most ScriptLink-compatible APIs are built with a local version of the NTST.ScriptLinkService.Objects library. Here's what a "Hello, World!" response might look like in this scenario.

```cs title="Without AvatarScriptLink.NET"
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

```cs title="With AvatarScriptLink.NET"
[WebMethod]
public OptionObject RunScript(OptionObject optionObject, string parameter)
{
    return optionObject.ToReturnOptionObject(ErrorCode.Informational, "Hello, World!");
}
```

Likewise, to bring this same API up to the latest OptionObject version doesn't require accounting for the new properties. Just update the OptionObject version and import the new/updated WSDL into myAvatar.

```cs title="Upgrading from OptionObject to OptionObject2015"
[WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
{
    return optionObject.ToReturnOptionObject(ErrorCode.Informational, "Hello, World!");
}
```
