# RarelySimple.AvatarScriptLink.Objects.Validators

Extension methods for validating ScriptLink response objects.

## Usage

```csharp
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Validators;

var option = new OptionObject { EntityID = "PATID123", ErrorCode = 0, ErrorMesg = string.Empty };
var result = option.ValidateResponse();

if (!result.IsValid)
{
    foreach (var error in result.Errors)
    {
        // handle validation errors
    }
}

// Validate response payload structure
var form = new FormObject { FormId = "FORM1", MultipleIteration = true };
var row = new RowObject { RowId = "1", RowAction = RowObject.RowActions.Edit };
row.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "value" });
form.CurrentRow = row;
option.Forms.Add(form);

var payloadResult = option.ValidateResponsePayload();
if (!payloadResult.IsValid)
{
    foreach (var error in payloadResult.Errors)
    {
        // handle payload validation errors
    }
}
```

## Features

- Strict response validation for OptionObject variants
- Clear error messages for invalid response state

## Dependencies

- **RarelySimple.AvatarScriptLink.Objects** - Core object definitions
- .NET Standard 2.0+

## License

MIT
