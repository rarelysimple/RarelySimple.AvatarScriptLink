---
title: AvatarScriptLink.NET Changelog
image: ./Changelog.png
---

# Changelog

[![NuGet Latest](https://img.shields.io/nuget/v/RarelySimple.AvatarScriptLink)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink/)

## 2.0.0 (Future)

:::info Subject to Change
The items listed below are under consideration for AvatarScriptLink.NET v.2.
This list is subject to change with some items being descoped or deferred to a later release.
:::

* Enable cross-platform development (i.e., Linux, MacOS, and Windows) and build of AvatarScriptLink.NET.
* Split library into multiple NuGet packages
    * `RarelySimple.AvatarScriptLink.Objects`: Simple package that provides just the ScriptLink objects without all of the helpers and other utilities. Work with ScriptLink your way.
    * `RarelySimple.AvatarScriptLink.Net`: Fully featured library with helpers and utilities to help accelerate ScriptLink API development in .NET and .NET Framework. Depends on `RarelySimple.AvatarScriptLink.Objects`.
    * `RarelySimple.AvatarScriptLink.Services`: SOAP Service definitions for .NET 8 and later. Depends on `RarelySimple.AvatarScriptLink.Objects`.
* Add support for Native AOT.
* Drop support for .NET Framework 4.6.1
* Remove dependency on `Newtonsoft.Json`.
* Include added Field and Row objects by default in returned OptionObjects.
* Correct an issue in which attributes in a newer version of the OptionObject are accessible in older versions.

## 1.2.0 (2023-06-25)

* Introduce Builder methods for each object to assist with object creation.
  * OptionObject2015 (incl. OptionObject2, OptionObject). Issue [#40](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/40)
  * FormObject. Issue [#39](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/39)
  * RowObject. Issue [#38](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/38)
  * FieldObject. Issue [#37](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/37)
* Allow for error code and message to be set prior to creation of return OptionObject. Issue [#52](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/52)

## 1.1.10 (2022-10-15)

* Corrects an issue preventing some forms from opening. Issue [#22](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/22)

## 1.1.6 (2022-09-04)

* Setting a field as required or disabled will no longer change other FieldObject attributes. Issue [#20](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/20)

## 1.0.28 (2022-07-25)

* Addresses CVE-2020-11022. Issue [#8](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/8)
* Addressed CVE-2020-11023. Issue [#7](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/7)

## 1.0.25 (2022-05-20)

* Maintenance release to update dependencies.
* NuGet will now show a README.

## 1.0.22 (2021-08-08)

* Addresses security vulnerabilities from dependencies.
* Converting OptionObject content to HTML has been improved.
* Miscellaneous code quality improvements.

## 1.0.7 (2020-12-12)

* Corrects an issue that occurs when the myAvatar registry setting, "Include FormObject for sections without a current row selected" is set to "Y".

## 1.0.6 (2020-06-09)

* Minor updates to initial release.

## 1.0.3 (2020-02-21)

* Initial release of AvatarScriptLink.NET.