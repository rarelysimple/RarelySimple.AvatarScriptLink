---
layout: default
title: RarelySimple.AvatarScriptLink
---

# AvatarScriptLink.NET

Essentially, AvatarScriptLink.NET is a framework for managing and manipulating myAvatar ScriptLink OptionObjects. What it does is accelerate the development of clean and stable myAvatar ScriptLink-compatible APIs. [More about AvatarScriptLink.NET](./about.md)

## Example

Most ScriptLink-compatible APIs are built with a local NTST.ScriptLinkService.Objects library. Here's what a "Hello, World!" response might look like in this scenario.

```c#
[WebMethod]
public OptionObject RunScript(OptionObject optionObject, string parameter)
{
    OptionObject returnOptionObject = new OptionObject();

    returnOptionObject.ErrorCode = 3;
    returnOptionObject.ErrorMesg = "Hello, World!";

    returnOptionObject.EntityID = _optionObject.EntityID;
    returnOptionObject.EpisodeNumber = _optionObject.EpisodeNumber;
    returnOptionObject.Facility = _optionObject.Facility;
    returnOptionObject.OptionId = _optionObject.OptionId;
    returnOptionObject.OptionStaffId = _optionObject.OptionStaffId;
    returnOptionObject.OptionUserId = _optionObject.OptionUserId;
    returnOptionObject.SystemCode = _optionObject.SystemCode;

    return returnOptionObject;
}
```

With AvatarScriptLink.NET, this same code can be simplified to:

```c#
[WebMethod]
public OptionObject RunScript(OptionObject optionObject, string parameter)
{
    return optionObject.ToReturnOptionObject(ErrorCode.Info, "Hello, World!");
}
```

Likewise, to bring this same API up to the latest OptionObject version doesn't require accounting for the new properties. Just update the OptionObject version and import the new WSDL.

```c#
[WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
{
    return optionObject.ToReturnOptionObject(ErrorCode.Info, "Hello, World!");
}
```

## Getting Started

AvatarScriptLink.NET is available on NuGet. Just install it to your ASP.NET Web Application and Unit Test projects and reference it where needed.

```c#
@using RarelySimple.AvatarScriptLink.Objects
```

### Learn More

Here are some walkthroughs to help you get started.

* [Create a New ScriptLink API Solution](./walkthrough-create-a-new-scriptlink-api-solution.md).
* [Migrate an Existing ScriptLink API Solution Based on NTST.ScriptLinkService.Objects](./walkthrough-migrate-an-existing-scriptlink-api-solution-based-on-ntst-scriptlinkservice-objects.md).
* [Migrate an Existing ScriptLink API Solution Based on ScriptLinkStandard](./walkthrough-migrate-an-existing-scriptlink-api-solution-based-on-scriptlinkstandard.md).

## Help

* [Compatibility](./compatibility.md)

Additional help resources coming soon.

## Licensing

AvatarScriptLink.NET is open source under the [MIT License](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/LICENSE.md) and free for commercial use.