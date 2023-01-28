```cs
[WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameters)
{
    return optionObject.ToReturnOptionObject(ErrorCode.Alert, "Hello, World!");
}
```