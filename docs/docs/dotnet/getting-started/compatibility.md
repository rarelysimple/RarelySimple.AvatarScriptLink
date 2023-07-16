---
title: Compatibility
image: ./Compatibility.png
sidebar_position: 2
---

# Compatibility

AvatarScriptLink.NET is built on .NET Standard 2.0. to support the widest range of .NET Framework and Windows Server versions and features.

## .NET Framework

.NET Standard 2.0 libraries are compatible with the following [.NET Framework versions](https://docs.microsoft.com/en-us/dotnet/framework/).

| .NET Framework  | Compatible |
|-----------------|------------|
| 4.8.1           | Yes        |
| 4.8             | Yes        |
| 4.7.2           | Yes        |
| 4.7.1           | Yes        |
| 4.7             | Yes        |
| 4.6.2           | Yes        |
| 4.6.1           | Yes*       |
| 4.6 and earlier | No         |

For .NET Framework v.4.6.1 projects, the recommendation is to upgrade to version 4.7.2 or higher due to several issue with consuming .NET Standard libraries. The AvatarScriptLink.NET NuGet package includes a version that specifically targets v.4.6.1 to address these issues if upgrading is not currently an option.

Check out the Microsoft Docs for more information on [.NET Standard compatibility](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

## Windows Server

Windows Server support is based on the .NET Framework version you choose to use in your ASP.NET Web Application. These are the Windows Servers that can support .NET Framework 4.6.1 or higher.

| Version                        | Compatible                           |
|:-------------------------------|:-------------------------------------|
| Windows Server 2022            | Yes                                  |
| Windows Server 2019            | Yes                                  |
| Windows Server 2016            | Yes                                  |
| Windows Server 2012 R2         | Yes                                  |
| Windows Server 2012            | Yes                                  |
| Windows Server 2008 R2         | Yes, with SP1                        |
| Windows Server 2008 SP2        | Maybe, requires .NET Framework 4.6.2 |
| Windows Server 2008 or earlier | No                                   |

More information can be found on [Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/framework/get-started/system-requirements#supported-server-operating-systems).

## .NET 5 and later?

AvatarScriptLink.NET is technically compatible with .NET 5 and later.
However, the System.Web.Services namespace that we typically leverage is not available.
If anyone has an example project, please let me know and I can update these docs accordingly.
