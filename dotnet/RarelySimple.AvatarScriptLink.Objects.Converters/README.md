# RarelySimple.AvatarScriptLink.Objects.Converters

Extension methods for converting ScriptLink objects between variants and cloning structures.

## Usage

```csharp
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Converters;

var option2 = new OptionObject2
{
    EntityID = "PATID123",
    ErrorCode = 0,
    ErrorMesg = string.Empty
};

OptionObject? option = option2.ToOptionObject();
```

## Features

- Converters between OptionObject variants
- Deep-copy helpers for FormObject, RowObject, and FieldObject
- Optional flags to include or exclude nested data
- Comprehensive XML documentation

## Dependencies

- **RarelySimple.AvatarScriptLink.Objects** - Core object definitions
- .NET Standard 2.0+

## License

MIT
