---
layout: default
title: AvatarScriptLink.NET Compatibility
description: AvatarScriptLink.NET is compatible with ScriptLink API solutions built on .NET Framework 4.6.1 and higher.
---

# Compatibility

AvatarScriptLink.NET is built on .NET Standard 2.0. to support the widest range of [.NET Framework](https://docs.microsoft.com/en-us/dotnet/framework/) and Windows Server versions and features.

## .NET Framework

.NET Standard 2.0 libraries are compatible with the following [.NET Framework](https://docs.microsoft.com/en-us/dotnet/framework/) versions.

| .NET Framework | Compatible |
|:-------------- |:-----------|
| 4.8 | Yes |
| 4.7.2 | Yes |
| 4.7.1 | Yes |
| 4.7 | Yes |
| 4.6.2 | Yes |
| 4.6.1 | Yes* |
| 4.6 and earlier | No |

For .NET Framework v.4.6.1 projects, the recommendation is to upgrade to version 4.7.2 or higher due to several issue with consuming .NET Standard libraries. The AvatarScriptLink.NET NuGet package includes a version that specifically targets v.4.6.1 to address these issues if upgrading is not currently an option.

Check out the Microsoft Docs for more information on [.NET Standard compatibility](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

## Windows Server

Windows Server support is based on the .NET Framework version you choose to use in your ASP.NET Web Application. These are the Windows Servers that can support .NET Framework 4.6.1 or higher.

| Version | Compatible |
|:--------|:-----------|
| Windows Server 2019 | Yes |
| Windows Server 2016 | Yes |
| Windows Server 2012 R2 | Yes |
| Windows Server 2012 | Yes |
| Windows Server 2008 R2 | Yes, with SP1 |
| Windows Server 2008 or earlier | No |

More information can be found on [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/framework/get-started/system-requirements).

## .NET Core and .NET 5?

AvatarScriptLink.NET is technically compatible with [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/) 2.0 and later, including the upcoming .NET 5. However, the [System.Web.Services](https://docs.microsoft.com/en-us/dotnet/api/system.web.services?view=netframework-4.8) namespace that we typically leverage is not available in .NET Core and not expected in .NET 5. 