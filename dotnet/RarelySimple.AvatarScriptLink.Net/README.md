# RarelySimple.AvatarScriptLink.Net

[![NuGet Latest](https://img.shields.io/nuget/v/RarelySimple.AvatarScriptLink.Net)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink.Net/) [![NuGet Downloads](https://img.shields.io/nuget/dt/RarelySimple.AvatarScriptLink.Net)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink.Net/) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Net&metric=alert_status)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Net) [![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Net&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Net) [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Net&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Net) [![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Net&metric=security_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Net)

**RarelySimple.AvatarScriptLink.Net** is a batteries-included meta-package that provides all the tools you need for [myAvatar](https://www.ntst.com/Solutions-and-Services/Offerings/myAvatar) ScriptLink development.

## What's Included

This package includes:

- **Objects** - Core ScriptLink data types and constants (OptionObject, FormObject, RowObject, FieldObject, ErrorCode)
- **Builders** - Fluent builder pattern for creating ScriptLink objects
- **Converters** - Deep-copy and cross-variant conversion utilities
- **Helpers** - Extension methods for querying and manipulating objects
- **Validators** - Response validation for ScriptLink SOAP requirements

## Quick Start

Install the package:

```bash
dotnet add package RarelySimple.AvatarScriptLink.Net
```

Build a simple ScriptLink response:

```csharp
using RarelySimple.AvatarScriptLink.Net;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Builders;

public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
{
    return OptionObject2015Builder
        .FromOptionObject(optionObject)
        .WithErrorCode(ErrorCode.Informational)
        .WithErrorMessage("Hello, World!")
        .Build();
}
```

Query and manipulate field values:

```csharp
using RarelySimple.AvatarScriptLink.Objects.Helpers;

// Get a field value (searches all forms)
string? patientName = optionObject.GetFieldValue("123");

// Check if field is present
if (optionObject.IsFieldPresent("456"))
{
    // Set field value
    optionObject.SetFieldValue("456", formId, rowId, "New Value");
}

// Disable all fields in a row except specific ones
row.DisableAllFieldObjects(excludedFieldNumbers: new List<string> { "789" });
```

Validate responses:

```csharp
using RarelySimple.AvatarScriptLink.Objects.Validators;

var result = optionObject.ValidateResponse();
if (!result.IsValid)
{
    foreach (var error in result.Errors)
    {
        Console.WriteLine(error);
    }
}
```

## Documentation

Check out [the documentation](https://scriptlink.rarelysimple.com/) to learn more.

## Licensing

AvatarScriptLink.NET is open source under the [MIT License](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/blob/master/LICENSE) and free for commercial use.
