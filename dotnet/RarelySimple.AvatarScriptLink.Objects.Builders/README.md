# RarelySimple.AvatarScriptLink.Objects.Builders

Extension methods for building and creating ScriptLink objects.

## Usage

```csharp
using RarelySimple.AvatarScriptLink.Objects.Builders;
using RarelySimple.AvatarScriptLink.Objects.Builders.ResponseBuilders;

// Create a field using builder extension methods
var field = FieldObject.Initialize()
    .WithFieldNumber("12345.0")
    .WithFieldValue("value")
    .AsEnabled(true);

// Create a simple success response with a form, row, and field
var response = OptionObjectResponseBuilders.CreateSuccessResponse("PATID123");
var form = response.AddResponseForm("FORM1", multipleIteration: true);
var row = form.CreateResponseCurrentRow("1");
row.AddResponseField("100", "value");
```

## Features

- Factory and builder extension methods for creating ScriptLink objects
- Fluent interface for convenient object construction
- Response builder extensions for creating proper SOAP responses
- Comprehensive XML documentation

## Dependencies

- **RarelySimple.AvatarScriptLink.Objects** - Core object definitions
- .NET Standard 2.0+

## License

MIT
