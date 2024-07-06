---
title: Migrating to AvatarScriptLink.NET v2 
image: ./migration-to-v2.png
sidebar_position: 10
sidebar_label: Migration
---

# Migrating to v2

:::danger
The following content is based on possible changes in AvatarScriptLink.NET version and is subject to change.
:::

AvatarScriptLink.NET version introduces a number of improvements from version, however this comes with some changes you will need to account for.

## From v1

If you are migrating from version 1, please review the changes below.

### NuGet package has changed

In version 1, the NuGet package was named `RarelySimple.AvatarScriptLink`.
With version 2, we have split this package to better support a greater variety of use cases and better support solutions built with .NET 8 and later.

The simplest option is to replace the `RarelySimple.AvatarScriptLink` package with `RarelySimple.AvatarScriptLink.Net`.

```bash
dotnet remove package RarelySimple.AvatarScriptLink
dotnet add package RarelySimple.AvatarScriptLink.Net --version 2.0.0
```

If your use case only uses the objects and none of the helper methods, you may be able to get by with just using the `RarelySimple.AvatarScriptLink.Objects` package. This is uncommon but a use case this new version is intended to better support.

### Helper methods are no longer available on the native objects

In version 1, helper methods like `GetFieldValue()` and `SetFieldValue()` were available on the ScriptLink objects directly.
These have been removed in version 2 to provide a lean objects library for those who just need the basics and desire a trimmed down solution.
The helper methods are still available for use but the implementation is a little different.

To use the helper methods in version consider this example v1 implementation:

```cs
public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string paramter)
{
    var fieldNumber = "123.45";
    if (optionObject2015.IsFieldPresent(fieldNumber))
        optionObject2015.SetFieldObject(fieldNumber, "default value");
    return optionObject2015.ToReturnOptionObject();
}
```

To migrate to v2 create a new `OptionObject2015Decorator` (wrapper class) using the received `OptionObject2015`.
You will then read and modify the objectObject using the decorator.

```cs
public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string paramter)
{
    var decorator = new OptionObject2015Decorator(optionObject2015);

    var fieldNumber = "123.45";
    if (decorator.IsFieldPresent(fieldNumber))
        decorator.SetFieldObject(fieldNumber, "default value");
    return decorator.ToReturnOptionObject();
}
```

If you were using the `Clone()` method to leave the received OptionObject2015 intact then you can just replace your clone line with the new decorator constructor line.

```cs
// var clone = optionObject2015.Clone();
var clone = new OptionObject2015Decorator(_optionObject2015);
// rest of implementation
```

## From NTST.ScriptLinkService.Objects

If you are migrating from the NTST.ScriptLinkService.Objects library, please review the below changes.

### Arrays are now Lists

Arrays in the object model have been replaced by Lists.

```c#
// In NTST.ScriptLinkService.Objects
// public FormObject[] Forms { get; set; }
// AvatarScriptLink.NET
public List<FormObject> Forms { get; set; }
```

There are no expected impacts to your code however it does alter your WSDL slightly. You will need to reimport your WSDL into myAvatar after deploying your changes.
