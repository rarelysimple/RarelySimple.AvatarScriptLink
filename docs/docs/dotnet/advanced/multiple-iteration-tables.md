---
title: Multiple-Iteration Tables
image: ./MultipleIterationTables.png
sidebar_position: 1
---

Multiple-iteration tables are a special kind of [FormObject](../data-model/formobject.mdx) that allow for multiple [RowObjects](../data-model/rowobject.mdx).

There are some constraints when working with multiple-iteration tables.

* Cannot be the first [FormObject](../data-model/formobject.mdx) in an [OptionObject](../data-model/optionobject2015.mdx).
* [RowObjects](../data-model/rowobject.mdx) cannot share the same RowId.
* The ParentRowId is to be set with the RowId assigned to the primary FormObject's CurrentRow.

The AvatarScriptLink.NET library helps with managing these constraints by:

* Throwing an exception when attempting to add additional [RowObjects](../data-model/rowobject.mdx) to a non-multiple-iteration [FormObject](../data-model/formobject.mdx).
* Automatically setting the [RowAction](../data-model/rowaction.mdx).
* Automatically assigning RowIds to prevent duplicates.
* Automatically adds new [RowObjects](../data-model/rowobject.mdx) to OtherRows when CurrentRow is already set.
* Helping look up the ParentRowId.

## Reading RowObjects

How we read [RowObjects](../data-model/rowobject.mdx) may vary by use specific needs. For example, if you need all values from a single FieldNumber:

```cs title="Read all values of a single field"
var clone = _optionObject.Clone();

var miFormId = "123";
List<string> values = optionObject.GetFieldValues(miFormId);

// work with values

return clone.ToReturnOptionObject();
```

If you need to interact with multiple [FieldObjects](../data-model/fieldobject.mdx) in each [RowObject](../data-model/rowobject.mdx) (e.g., validating values).

```cs title="Read RowObjects in a multiple-iteration table"
var clone = _optionObject.Clone();

var miFormId = "123";

foreach (FormObject formObject in clone.Forms)
{
    if (formObject.FormId == secondFormId)
    {
        var selectedRow = formObject.CurrentRow;
        // read RowObject
        foreach (RowObject rowObject in formObject.OtherRows)
        {
            // read other RowObjects
        }
    }
}

return clone.ToReturnOptionObject();
```

## Adding RowObjects

:::warning
At this time we want to avoid using the [RowObject](../data-model/rowobject.mdx) Builder to build the [RowObjects](../data-model/rowobject.mdx) as it requires setting the RowId instead of allowing the AddRowObject method to auto-assign it. This may change in a future update.
:::

To take advantage of the library features described above, we want to use the AddRowObject method exclusively to add the new rows.

```cs title="Add multiple RowObjects to a multiple-iteration table"
var clone = _optionObject.Clone();

var parentFormId = "110";
var miFormId = "123";
var parentRowId = clone.GetCurrentRowId(parentFormId);

var firstRow = new RowObject();
firstRow.RowAction = RowAction.Add;
firstRow.ParentRowId = parentRowId;
firstRow.AddFieldObject(new FieldObject("123.45", "Test #1"));
clone.AddRowObject(miFormId, firstRow);

var secondRow = new RowObject();
secondRow.RowAction = RowAction.Add;
secondRow.ParentRowId = parentRowId;
secondRow.AddFieldObject(new FieldObject("123.45", "Test #2"));
clone.AddRowObject(miFormId, secondRow);

return clone.ToReturnOptionObject();
```

## Editing RowObjects

Editing rows in a multiple-iteration table can be tricky. It is recommended to do plenty of testing and validation to ensure the user experience is as expected.

```cs title="Set a value on all rows in a multiple-iteration table"
var clone = _optionObject.Clone();

var miFormId = "123";

foreach (FormObject formObject in clone.Forms)
{
    if (formObject.FormId == secondFormId)
    {
        var selectedRow = formObject.CurrentRow;
        // Using the SetFieldValue method automatically sets the RowAction to EDIT
        selectedRow.SetFieldValue("234.56", "Edited by ScriptLink API");

        foreach (RowObject rowObject in formObject.OtherRows)
        {
            rowObject.SetFieldValue("234.56", "Edited by ScriptLink API");
        }
    }
}

return clone.ToReturnOptionObject();
```

## Deleting RowObjects

Deleting [RowObject](../data-model/rowobject.mdx) is accomplished by setting the [RowAction](../data-model/rowaction.mdx) to DELETE. This can be accomplished a couple ways. The first is the most straightforward but requires RowId of the [RowObject](../data-model/rowobject.mdx) to delete.

```cs title="Delete a RowObject by RowId"
var clone = _optionObject.Clone();

var rowIdToDelete = "123||4";
clone.DeleteRowObject(rowIdToDelete);

return clone.ToReturnOptionObject();
```

In most cases, the RowId of the [RowObject(s)](../data-model/rowobject.mdx) will not be fixed or known when the API is called.

```cs title="Delete all rows in a multiple-iteration table"
var clone = _optionObject.Clone();

var miFormId = "123";

foreach (FormObject formObject in clone.Forms)
{
    if (formObject.FormId == secondFormId)
    {
        if (formObject.CurrentRow != null && formObject.CurrentRow.RowId)
            formObject.DeleteRowObject(formObject.CurrentRow.RowId);
        foreach (RowObject rowObject in formObject.OtherRows)
        {
            if (rowObject.RowId != null)
                formObject.DeleteRowObject(rowObject.RowId);
        }
    }
}

return clone.ToReturnOptionObject();
```

## Handling Exceptions

Two of the most common errors that can occur include:

* Attempting to reference a [FormObject](../data-model/formobject.mdx) that is not in this [OptionObject](../data-model/optionobject2015.mdx).
* Attempting to add multiple [RowObjects](../data-model/rowobject.mdx) to a non-multiple iteration [FormObject](../data-model/formobject.mdx).

This can be handled with conditionals and exception handling.

```cs title="Handling exceptions with if/else and try/catch"
var clone = _optionObject.Clone();

var parentFormId = "110";
var miFormId = "123";

if (clone.IsFormPresent(parentFormId))
{
    try
    {
        var parentRowId = clone.GetCurrentRowId(parentFormId);
        if (!clone.IsFormPresent(miFormId))
        {
            clone.AddFormObject(miFormId, true);
        }

        var firstRow = new RowObject();
        firstRow.RowAction = RowAction.Add;
        firstRow.ParentRowId = parentRowId;
        firstRow.AddFieldObject(new FieldObject("123.45", "Test #1"));
        clone.AddRowObject(miFormId, firstRow);

        var secondRow = new RowObject();
        secondRow.RowAction = RowAction.Add;
        secondRow.ParentRowId = parentRowId;
        secondRow.AddFieldObject(new FieldObject("123.45", "Test #2"));
        clone.AddRowObject(miFormId, secondRow);

        return clone.ToReturnOptionObject();
    }
    catch (ArgumentException ex) {
        return clone.ToReturnOptionObject(ErrorCode.Error, ex.Message);
    }
}
return clone.ToReturnOptionObject(ErrorCode.Error, "Could not find expected multiple-iteration form.");
```