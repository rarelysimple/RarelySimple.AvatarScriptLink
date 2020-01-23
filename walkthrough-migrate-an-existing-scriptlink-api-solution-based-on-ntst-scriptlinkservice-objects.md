---
layout: default
title: Migrate an Existing ScriptLink API Solution Based on NTST.ScriptLinkService.Objects
---

# Walkthrough: Migrate an Existing ScriptLink API Solution Based on NTST.ScriptLinkService.Objects

This walkthrough will highlight the key steps to migrate your ScriptLink API solution from the NTST.ScriptLinkService.Objects library to AvatarScriptLink.NET.

## Before You Begin

Before you begin the migration to AvatarScriptLink.NET, we need to confirm the version of .NET Framework you are using:

1. Right-click on the Web Application project and select Properties.
2. Select the Application tab and make note of the Target framework.
3. If your Target Framework is .NET Framework 4.6.1 or higher then you are ready to go. Otherwise, take a look at the following considerations.

### .NET Framework 4.5 to 4.6

If your Target framework is between 4.5 and 4.6 inclusively, then you should be able to update to 4.7.2 or higher with little to no conversion issues.

* Set your project to target .NET Framework 4.7.2 or higher.
* Refactor code as needed to address any compile errors.
* Verify unit tests pass and application runs as expected.

### .NET Framework 4

If your Target framework is .NET Framework 4, then you can expect some conversion issues when updating to .NET Framework 4.6.1 or higher. Depending on the time commitment, you can either attempt the in-place upgrade (as described above) or start a new project and migrate your code (as described below).

### .NET Framework 3.5 or lower
If your target framework is .NET Framework 3.5 or lower:

* Create a new ASP.NET Web Application (.NET Framework) based on .NET Framework 4.7.2 or higher.
* Migrate your code.

## Step 1: Install the AvatarScriptLink.NET NuGet Package

## Step 2: Replace Usings

In each file that references the NTST.ScriptLinkService.Objects library, replace it with RarelySimple.AvatarScriptLink.Objects.

```c#
//using NTST.ScriptLinkService.Objects;
using RarelySimple.AvatarScriptLink.Objects;
```

## Step 3: Convert Arrays to Lists

The following properties are changed from arrays to List<T> in AvatarScriptLink.NET:

* OptionObject2015.Forms
* OptionObject2.Forms
* OptionObject.Forms
* FormObject.OtherRows
* RowObject.Fields

If you have any code that initializes these properties then you need to change their initializations from arrays to lists.

```c#
//var forms = new FormObject[1];
var forms = new List<FormObject>();
var formObject = new FormObject();
var currentRow = new RowObject();
//var fields = new FieldObject[1];
var fields = new List<FieldObject>();
var field = new FieldObject();
```

At this point, your solution should be able to compile and all unit tests should pass. Congratulations! Your migration is complete.

## Step 4: Additional Recommended Changes (Optional)

One of the benefits of leveraging the AvatarScriptLink.NET library is the ability to simplify your code.

### Reference: Legacy Sample Code

Consider the following ScriptLink API based on NTST.ScripLinkService.Objects.

```c#
public class ScriptLinkController : System.Web.Services.WebService
{
    [WebMethod]
    public string GetVersion()
    {
        return "v.0.0.1";
    }

    [WebMethod]
    public OptionObject2 RunScript(OptionObject2 optionObject2, string parameter)
    {
        OptionObject2 returnOptionObject = new OptionObject2();

        switch (parameter)
        {
            case "SetValueBasedOnAnotherValueAndThrowError":
                returnOptionObject = SetValueBasedOnAnotherValueAndThrowError(optionObject2);
                break;
            default:
                returnOptionObject.ErrorCode = 3;
                returnOptionObject.ErrorMesg = "No script was found with this name.";
                returnOptionObject.EntityID = optionObject2.EntityID;
                returnOptionObject.OptionId = optionObject2.OptionId;
                returnOptionObject.EpisodeNumber = optionObject2.EpisodeNumber;
                returnOptionObject.SystemCode = optionObject2.SystemCode;
                returnOptionObject.Facility = optionObject2.Facility;
                returnOptionObject.ServerName = optionObject2.ServerName;
                returnOptionObject.ParentNamespace = optionObject2.ParentNamespace;
                returnOptionObject.NamespaceName = optionObject2.NamespaceName;
                break;
        }

        return returnOptionObject;
    }
}
```

If the parameter value is set correctly, then it calls the following private class.

```c#
private OptionObject2 SetValueBasedOnAnotherValueAndThrowError(OptionObject2 optionObject2)
{
    OptionObject2 returnOptionObject2 = new OptionObject2();
    string fieldValue = "Field not found in OptionObject.";

    foreach (var form in optionObject2.Forms)
    {
        foreach (var currentField in form.CurrentRow.Fields)
        {
            try
            {
                switch (currentField.FieldNumber)
                {
                    case "15":
                        fieldValue = currentField.FieldValue;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                //
            }
        }
    }

    if (fieldValue != "6")
    {
        var forms = new FormObject[1];
        var formObject = new FormObject();
        var currentRow = new RowObject();
        var fields = new FieldObject[1];
        var field = new FieldObject();

        field.FieldNumber = "15";
        field.FieldValue = "6";
        field.Enabled = "1";
        fields[0] = field;

        currentRow.Fields = fields;
        currentRow.RowId = optionObject2.Forms[0].CurrentRow.RowId;
        currentRow.ParentRowId = optionObject2.Forms[0].CurrentRow.ParentRowId;
        currentRow.RowAction = "EDIT";

        formObject.FormId = "14";
        formObject.CurrentRow = currentRow;
        forms[0] = formObject;

        returnOptionObject2.ErrorCode = 3;
        returnOptionObject2.ErrorMesg = "The FieldValue must be 6.";
        returnOptionObject2.Forms = forms;
    }
    else
    {
        returnOptionObject2.ErrorCode = 3;
        returnOptionObject2.ErrorMesg = "You have chosen wisely.";
    }
    returnOptionObject2.EntityID = optionObject2.EntityID;
    returnOptionObject2.OptionId = optionObject2.OptionId;
    returnOptionObject2.EpisodeNumber = optionObject2.EpisodeNumber;
    returnOptionObject2.SystemCode = optionObject2.SystemCode;
    returnOptionObject2.Facility = optionObject2.Facility;
    returnOptionObject2.ServerName = optionObject2.ServerName;
    returnOptionObject2.ParentNamespace = optionObject2.ParentNamespace;
    returnOptionObject2.NamespaceName = optionObject2.NamespaceName;

    return returnOptionObject2;
}
```

### Recommendation 1: Refactor ReturnOptionObject Creation

AvatarScriptLink.NET allows you to create your return OptionObject2 directly from the received OptionObject2 in this sample. This means you do not have to write the code set the required values, remove the unmodifed FormObjects, RowObjects, and FieldObjects. As a result, the refactored WebMethod could look something like this.

```c#
[WebMethod]
public OptionObject2 RunScript(OptionObject2 optionObject2, string parameter)
{
    switch (parameter)
    {
        case "SetValueBasedOnAnotherValueAndThrowError":
            return SetValueBasedOnAnotherValueAndThrowError(optionObject2);
        default:
            return optionObject2.ToReturnOptionObject(3,"No script was found with this name.");
    }
}
```

### Recommendation 2: Refactor Setting and Getting FieldValues

With AvatarScriptLink.NET, you are no longer required to write the loops needed to get FieldValues from the OptionObject. Additionally, it keeps track of the changes made to OptionObject such as setting a FieldValue to properly setup the return OptionObject later. Here's how the private method could be refactored.

```c#
private OptionObject2 SetValueBasedOnAnotherValueAndThrowError(OptionObject2 optionObject2)
{
    if (optionObject2.GetFieldValue("15") != "6")
    {
        optionObject2.SetFieldValue("15", "6");
        return optionObject2.ToReturnOptionObject(3, "The FieldValue must be 6.");
    }
    return optionObject2.ToReturnOptionObject(3, "You have chosen wisely.");
}
```

### Recommendation 3: Use the ErrorCode Enum to Set the ErrorCode

AvatarScriptLink.NET provides an ErrorCode enum that helps you select the desired ErrorCode without having to recall what each Code means. Here's how are previous code could be updated to use the ErrorCode enum.

```c#
[WebMethod]
public OptionObject2 RunScript(OptionObject2 optionObject2, string parameter)
{
    switch (parameter)
    {
        case "SetValueBasedOnAnotherValueAndThrowError":
            return SetValueBasedOnAnotherValueAndThrowError(optionObject2);
        default:
            return optionObject2.ToReturnOptionObject(ErrorCode.Info,"No script was found with this name.");
    }
}

private OptionObject2 SetValueBasedOnAnotherValueAndThrowError(OptionObject2 optionObject2)
{
    if (optionObject2.GetFieldValue("15") != "6")
    {
        optionObject2.SetFieldValue("15", "6");
        return optionObject2.ToReturnOptionObject(ErrorCode.Info, "The FieldValue must be 6.");
    }
    return optionObject2.ToReturnOptionObject(ErrorCode.Info, "You have chosen wisely.");
}
```

### Recommendation 4: Unit Testing

Our sample code above cannot be unit tested. Move both your switch statements and private method(s) into their own public classes and methods so that they can be targeted by Unit Tests.

## Troubleshooting

### Ambiguous Reference Error

You cannot declare both NTST.ScriptLinkService.Objects and RarelySimple.AvatarScriptLink.Objects in the same file. This creates an ambiguous reference compile error. Comment out or remove NTST.ScriptLinkService.Objects from the list of usings after you add the using for RarelySimple.AvatarScriptLink.Objects.

```c#
//using NTST.ScriptLinkService.Objects;
using RarelySimple.AvatarScriptLink.Objects;
```