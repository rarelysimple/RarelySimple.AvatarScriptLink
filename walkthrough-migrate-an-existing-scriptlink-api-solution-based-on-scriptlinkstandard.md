---
layout: default
title: Migrate an Existing ScriptLink API Solution Based on ScriptLinkStandard
---

# Walkthrough: Migrate an Existing ScriptLink API Solution Based on ScriptLinkStandard

One of the goals of the AvatarScriptLink.NET project was to minimize the number of changes that would be required to migrate from my previous project, [ScriptLinkStandard](https://github.com/rcskids/ScriptLinkStandard). However, to accomplish some of the other goals changes needed to be made. The guide will walk through the changes you may need to make to migrate your project from ScriptLinkStandard (v.1.0.58-beta). If [Rebekah Children's Services](https://www.rcskids.org) resumes maintenance of ScriptLinkStandard then these instructions may not match the later versions.

## Before You Begin

To follow along, you will need:

* [Visual Studio 2019](https://visualstudio.microsoft.com/vs/). Community edition is free and has everything you will need.
* A ScriptLink API project based on the ScriptLinkStandard NuGet package.

## Overview

Here are the tasks you may need to complete to migrate to AvatarScriptLink.NET depending on your project.

* Install the RarelySimple.AvatarScriptLink NuGet package.
* Replace references to ScriptLinkStandard.Objects with RarelySimple.AvatarScriptLink.Objects.

Here are some additional, but unlikely, changes that may need to be made as well.

* Convert your int ErrorCode variables to double. (Unlikely)
* Implement your own [IScriptLink interface](https://github.com/rcskids/ScriptLinkStandard/blob/master/ScriptLinkStandard/Interfaces/IScriptLink.cs). (Unlikely)
* Change your uses of the ScriptLinkHelpers class to OptionObjectHelpers when related to OptionObjects. (Unlikely)

## Step 1: Install the AvatarScriptLink.NET NuGet Package

1. Right-click on the solution and select Manage NuGet Packages for Solution...
2. Select the Browse tab and search for RarelySimple. If trying this before the release version is out, check Include prerelease.
3. Select the RarelySimple.AvatarScriptLink package.
4. Check the boxes next to the Web Application and Unit Testing projects and select Install.
5. Once installed, close the NuGet - Solution tab.

## Step 2: Replace Usings

In each file that references the ScriptLinkStandard.Objects library, replace it with RarelySimple.AvatarScriptLink.Objects.

```c#
//using ScriptLinkStandard.Objects;
using RarelySimple.AvatarScriptLink.Objects;
```

## Step 3: Remove the ScriptLinkStandard Reference

To avoid confusion with future work, it is recommended to remove the Reference project reference from your Web Application and Unit Test projects.

1. Right-click on the References node under the Web Application project and select Add Reference...
2. Uncheck ScriptLinkStandard.Objects and select OK.
3. Run Unit Tests to verify all references (usings) were successfully replaced.
4. Repeat for the Unit Test project and any other projects in this solution that reference the NTST library.

Congratulations! Your migration is complete.

## Step 4: Additional Changes (Limited Cases)

### The Objects Namespace

#### Methods

AvatarScriptLink.NET continues the practice of extending the OptionObjects with methods to aid in their management and modification. This means that all of the methods available in ScriptLinkStandard are available in AvatarScriptLink.NET. However, there are some changes.

* SetEnabledField and SetEnabledFields are aliases to SetOptionalField and SetOptionalFields respectively.
* ToReturnOptionObject now correctly requests the ErrorCode as a double instead of an int.

TASK: You may need to change or converts your error codes from int to double because of the above changes. However, this is unlikely.

#### Objects

Here is where it gets interesting. As far as myAvatar is concerned nothing has changed here and everything will just work. However, there are notable differences that you will discover as you work with AvatarScriptLink.NET.

##### OptionObjects

All three OptionObject versions inherit the same base (abstract) class which means you will see properties for the newer vesions listed on the older versions. For example, you will see the SessionToken property listed on both the OptionObject and OptionObject2. When serialized for myAvatar these newer properties are ignored on the older versions. This means that all three versions can be received by a method that accepts an IOptionObject2015 class. This will help reduce duplicate/repeated code to support backwards or forwards compatibility.

Aside from seeing properties you wouldn't expect in Intellisense, there are no breaking changes identified in this migration regarding the OptionObjects.

##### ErrorCode

The ErrorCode class has changed a bit in comparison to ScriptLinkStandard. This is intended to help with the readability of your code.

| ErrorCode | ScriptLinkStandard | AvatarScriptLink.NET |
| :-------: | ------------------ | -------------------- |
| 0         | None               | None, Success        |
| 1         | Error              | Error                |
| 2         | OkCancel           | Warning, OkCancel    |
| 3         | Info         | Alert, Informational, Info |
| 4         | YesNo              | Confirm, YesNo       |
| 5         | OpenUrl            | OpenUrl              |
| 6         | OpenForm           | OpenForm             |

By including all of the properties from ScriptLinkStandard, there should be no breaking changes.

##### Interfaces

It is with the interfaces that we see the fundamental differences between the two libraries. Here are the key differences:

* Interfaces are located in the RarelySimple.AvatarScriptLink.Objects.Advanced namespace instead of a dedicated root level namespace.
* Interfaces match the contract established by Netsmart and do not include the methods that the library provides. This is to keep them immutable in future updates.
* Interfaces inherit previous versions. This is to show the relationship of these contracts to one another.
* The IScriptLink interface does not exist. There are a number of techniques for creating ScriptLink scripts/commands that support Unit Testing. This felt out of scope for this library.

TASK: If you wish to continue to inherit from this interface, you can add you own to the solution. Here is the [source code for the IScriptLink interface](https://github.com/rcskids/ScriptLinkStandard/blob/master/ScriptLinkStandard/Interfaces/IScriptLink.cs).

### Helpers

The Helpers are also very different when compared to ScriptLinkStandard. Here are the differences:

* All OptionObject-related helpers are in the OptionObjectHelpers class. For example, `OptionObjectHelpers.GetNextAvailableRowId(formObject);`
* All other common helpers are in the ScriptLinkHelpers class. For example, `ScriptLinkHelpers.IsValidUrl(url);`

Here are the helper methods that are new to AvatarScriptLink.NET.

* SetEnabledField and SetEnabledFields are aliases for SetOptionalField and SetOptionalFields respectively in the OptionObjectHelpers class.
* SafeGetBool and SafeGetDateTime are available to help safely get these type of values from ODBC and other sources that may return a string.

TASK: Change OptionObject related helpers to use the OptionObjectHelpers class instead of ScriptLinkHelpers.

## Troubleshooting

### Ambiguous Reference Error

You cannot declare both ScriptLinkStandard.Objects and RarelySimple.AvatarScriptLink.Objects in the same file. This creates an ambiguous reference compile error. Comment out or remove ScriptLinkStandard.Objects from the list of usings after you add the using for RarelySimple.AvatarScriptLink.Objects.

```c#
//using ScriptLinkStandard.Objects;
using RarelySimple.AvatarScriptLink.Objects;
```