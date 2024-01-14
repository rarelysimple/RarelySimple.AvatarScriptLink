# RarelySimple.AvatarScriptLink.Net

[![NuGet Latest](https://badgen.net/nuget/v/rarelysimple.avatarscriptlink.Net/latest)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink.Net/) [![NuGet Downloads](https://img.shields.io/nuget/dt/RarelySimple.AvatarScriptLink.Net)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink.Net/) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Net&metric=alert_status)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Net) [![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Net&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Net) [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Net&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Net) [![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Net&metric=security_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Net)

RarelySimple.AvatarScriptLink.Net provides helpers and utilities to accelerate your [myAvatar](https://www.ntst.com/Solutions-and-Services/Offerings/myAvatar) ScriptLink development.

# Example

Most ScriptLink-compatible APIs are working with the ScriptLink objects and are resposible for handling all aspects of reading, updating, and returning them. Here's what a "Hello, World!" response might look like in this scenario.

```c#
// Uncomment annotation for .NET Framework *.asmx
// [WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
{
    // Create return OptionObject
    OptionObject2015 returnOptionObject = new OptionObject2015();

    // Do work

    // Set Error Code and Message
    returnOptionObject.ErrorCode = 3;
    returnOptionObject.ErrorMesg = "Hello, World!";
    // Copy required OptionObject attributes
    returnOptionObject.EntityID = optionObject.EntityID;
    returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
    returnOptionObject.Facility = optionObject.Facility;
    returnOptionObject.NamespaceName = optionObject.NamespaceName;
    returnOptionObject.OptionId = optionObject.OptionId;
    returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
    returnOptionObject.OptionUserId = optionObject.OptionUserId;
    returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
    returnOptionObject.ServerName = optionObject.ServerName;
    returnOptionObject.SessionToken = optionObject.SessionToken;
    returnOptionObject.SystemCode = optionObject.SystemCode;

    return returnOptionObject;
}
```

With AvatarScriptLink.NET, this same code can be simplified to:

```c#
// Uncomment annotation for .NET Framework *.asmx
// [WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
{
    
    var decorator = new OptionObjectDecorator(optionObject);

    // Do work

    return decorator.Return()
        .WithErrorCode(ErrorCode.Alert)
        .WithErrorMesg("Hello World!")
        .AsOptionObject2015();
}
```

Check out [the documentation](https://scriptlink.rarelysimple.com/) to learn more.

## Licensing ##

AvatarScriptLink.NET is open source under the [MIT License](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/blob/master/LICENSE) and free for commercial use.
