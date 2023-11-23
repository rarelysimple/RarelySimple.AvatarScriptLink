---
title: Adding Rows to Multiple-Iteration Tables
image: ./AddingRowsToMultipleIterationTables.png
sidebar_position: 1
---

Multiple-iteration tables are a special kind of [FormObject](../data-model/formobject.mdx) that allow for multiple [RowObjects](../data-model/rowobject.mdx).

There are some constraints when working with multiple-iteration tables.

* Cannot be the first [FormObject](../data-model/formobject.mdx) in an [OptionObject](../data-model/optionobject2015.mdx).
* [RowObjects](../data-model/rowobject.mdx) cannot share the same RowId.

The AvatarScriptLink.NET library helps with managing these constraints by:

* Throwing an exception when attempting to add additional [RowObjects](../data-model/rowobject.mdx) to a non-multiple-iteration [FormObject](../data-model/formobject.mdx).
* Automatically sets the [RowAction](../data-model/rowaction.mdx) to "ADD".
* Automatically assigns RowIds to prevent duplicates.
* Automatically adds new [RowObjects](../data-model/rowobject.mdx) to OtherRows when CurrentRow is already set.

## Add RowObjects with AddRowObject

:::warning
At this time we want to avoid using the [RowObject](../data-model/rowobject.mdx) Builder to build the [RowObjects](../data-model/rowobject.mdx) as it requires setting the RowId instead of allowing the AddRowObject method to auto-assign it. This may change in a future update.
:::

To take advantage of the library features described above, we want to use the AddRowObject method exclusively to add the new rows.

```cs
var clone = _optionObject.Clone();

var miFormId = "123";

var firstRow = new RowObject();
firstRow.AddFieldObject(new FieldObject("123.45", "Test #1"));
clone.AddRowObject(miFormId, firstRow);

var secondRow = new RowObject();
secondRow.AddFieldObject(new FieldObject("123.45", "Test #2"));
clone.AddRowObject(miFormId, secondRow);

return clone.ToReturnOptionObject();
```

## Handling Exceptions

Two of the most common errors that can occur include:

* Attempting to reference a [FormObject](../data-model/formobject.mdx) that is not in this [OptionObject](../data-model/optionobject2015.mdx).
* Attempting to add multiple [RowObjects](../data-model/rowobject.mdx) to a non-multiple iteration [FormObject](../data-model/formobject.mdx).

This can be handled with conditionals and exception handling.

```cs
var clone = _optionObject.Clone();

var miFormId = "123";
if (clone.IsFormPresent(miFormId))
{
    try
    {
        var firstRow = new RowObject();
        firstRow.AddFieldObject(new FieldObject("123.45", "Test #1"));
        clone.AddRowObject(miFormId, firstRow);

        var secondRow = new RowObject();
        secondRow.AddFieldObject(new FieldObject("123.45", "Test #2"));
        clone.AddRowObject(miFormId, secondRow);

        return clone.ToReturnOptionObject();
    }
    catch (ArguementException ex) {
        return clone.ToReturnOptionObject(ErrorCode.Error, ex.Message);
    }
}
return clone.ToReturnOptionObject(ErrorCode.Error, "Could not find expected multiple-iteration form.");
```

## Complete Example

Below is the complete example with options for initializing and building the different objects.

```cs
// Cloning the received OptionObject2015 to avoid modifying what was received
var clone = _optionObject.Clone();

// The FormID of the Multiple-Iteration Table to add rows to
var miFormId = "123";
// Verify Form is present
if (clone.IsFormPresent(miFormId))
{
    try
    {
        // Using Constructor instead of Builder to allow AddRowObject to assign the RowId automatically 
        var firstRow = new RowObject();
        // Adding FieldObjects using Constructors
        firstRow.AddFieldObject(new FieldObject("123.45", "Test #1"));
        firstRow.AddFieldObject(new FieldObject("123.46", "Another field in the row."));
        // If the MI Form doesn't have any rows yet this will be placed in CurrentRow. Otherwise, it will be added to OtherRows.
        clone.AddRowObject(miFormId, firstRow);

        // You can also use the Initializer
        var secondRow = RowObject.Initialize();
        // Adding FieldObjects using Builder
        secondRow.AddFieldObject(FieldObject.Builder().FieldNumber("123.45").FieldValue("Test #2").Build());
        firstRow.AddFieldObject(FieldObject.Builder().FieldNumber("123.46").FieldValue("More information.").Build());
        // This row will be added to OtherRows
        clone.AddRowObject(miFormId, secondRow);

        return clone.ToReturnOptionObject();
    }
    catch (ArgumentException ex)
    {
        // ArgumentException is expected when attempting to add multiple rows to a non-MI form
        logger.Error(ex);
        return clone.ToReturnOptionObject(ErrorCode.Error, ex.Message);
    }
}
logger.Error("Could not find expected multiple-iteration FormObject.");
return clone.ToReturnOptionObject(ErrorCode.Error, "Could not find expected multiple-iteration form.");
```