---
layout: default
title: About AvatarScriptLink.NET
---

# About

[AvatarScriptLink.NET](./index.md) (on NuGet as RarelySimple.AvatarScriptLink) is a .NET Standard library designed to help accelerate the safe and stable adoption of ScriptLink extensions for the [Netsmart myAvatar electronic medical record](https://www.ntst.com/Solutions-and-Services/Offerings/myAvatar). This library assists developers in the management and manipulation of the OptionObject, especially with common tasks such as reading/setting field values and returning a compliant OptionObject back to myAvatar.

## History

AvatarScriptLink.NET represents the third generation of a concept that has been has been interate on since 2013.

### ScriptLink-Core (1st Generation)

When first learning to write a ScriptLink-compatible SOAP API, we write a lot of the same for loops, create the same return objects, and copy the same properties. This is not unique to specific organizations. We all have to do it. This motivated the creation of [ScriptLink Core](https://github.com/scottolsonjr/scriptlink-core) in 2013 which was intended to provide all of the core (common) functionality needed to manipulate the OptionObjects regardless of implementation.

[Scott Olson Jr](https://github.com/scottolsonjr) and [Luis Quicano](https://github.com/luivis07) collaborated to create this initial concept.

Development of this library ended in 2014 and is not recommended for production use.

### ScriptLinkStandard (2nd Generation)

A couple factors prompted the migration to this second generation library.
- First, [Microsoft announced .NET Core](https://devblogs.microsoft.com/dotnet/net-core-is-open-source/). This naming was seen as a potential cause for confusion as ScriptLink Core was not a .NET Core library.
- Second, with .NET Core came [.NET Standard](https://devblogs.microsoft.com/dotnet/introducing-net-standard/) for creating .NET libraries that could work with both .NET Framework and .NET Core.
- Third, [Rebekah Children's Services](https://www.rcskids.org) was moving into a new interoperability project that would leverage ScriptLink and the existing code base could not confidently support the new demands. The ScriptLink solution needed to be rebuilt to support the greater demands and regression testing.

ScriptLink Core was migrated to .NET Standard and rebranded as [ScriptLinkStandard](https://github.com/rcskids/ScriptLinkStandard) in 2017. Unlike the previous generation, this library went into production use at Rebekah Children's Services and became available as [a pre-release package on NuGet](https://www.nuget.org/packages/ScriptLinkStandard) in 2018.

As of January 2020, Rebekah Children's Services has unlisted the NuGet package and has not yet indicated whether they will be continuing to support ScriptLinkStandard. This is subject to change.

### AvatarScriptLink.NET (3rd Generation)

AvatarScriptLink.NET is a new .NET Standard library that is designed like its predecessors to help accelerate ScriptLink API development and encourage the writing of clean and testable code in .NET. A few of the initial goals for this library included:

- Immutable IOptionObject, IOptionObject2, and IOptionObject2015 interfaces. (i.e., these interfaces will not be changed in future updates)
- Reduce repeated code segments.
- Reduce the dependency on conversions between OptionObject versions.
- Minimize code changes required to change solution from either NTST.ScriptLinkService.Objects or ScriptLinkStandard.
- Continue open source development.
- Provide and maintain a NuGet package.
- Leverage CI/CD processes to build and release.

The first pre-release version was made [available on NuGet](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink/) for testing and validation in January 2020.