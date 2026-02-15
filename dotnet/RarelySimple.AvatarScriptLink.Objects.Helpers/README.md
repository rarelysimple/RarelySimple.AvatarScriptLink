# RarelySimple.AvatarScriptLink.Objects.Helpers

Extension methods for querying, manipulating, and validating ScriptLink objects.

## Usage

```csharp
using RarelySimple.AvatarScriptLink.Objects.Helpers;

// Query field status
if (field.IsEnabled() && field.IsRequired())
{
    // Process required fields
}

// Safely check for collections
if (form.HasOtherRows())
{
    // Iterate over rows
}

// Manipulate field properties
field.SetEnabled(true);
field.SetValue("new value");
```

## Features

- Query extension methods (IsEnabled, IsLocked, HasForms, etc.)
- Manipulation extension methods for modifying object properties
- Validation extension methods for checking object state
- Helpers organized by concern (Manipulators, Validators, etc.)
- Comprehensive XML documentation

## Dependencies

- **RarelySimple.AvatarScriptLink.Objects** - Core object definitions
- .NET Standard 2.0+

## License

MIT
