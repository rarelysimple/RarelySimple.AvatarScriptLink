# RarelySimple.AvatarScriptLink.Services

[![NuGet Latest](https://img.shields.io/nuget/v/RarelySimple.AvatarScriptLink.Services)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink.Services/) [![NuGet Downloads](https://img.shields.io/nuget/dt/RarelySimple.AvatarScriptLink.Services)](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink.Services/) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Services&metric=alert_status)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Services) [![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Services&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Services) [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Services&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Services) [![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=rarelysimple_RarelySimple.AvatarScriptLink.Services&metric=security_rating)](https://sonarcloud.io/dashboard?id=rarelysimple_RarelySimple.AvatarScriptLink.Services)

RarelySimple.AvatarScriptLink.Services provides the ScriptLink service definitions to help create Netsmart myAvatar-compatible ScriptLink APIs in .NET.

For additional helpers and utilities to accelerate your ScriptLink development we recommend using the [RarelySimple.AvatarScriptLink.Net](https://www.nuget.org/packages/RarelySimple.AvatarScriptLink.Net/) package.

# Usage

Implement the IScriptLinkService2015 interface.

```c#
public class ScriptLinkService2015 : IScriptLinkService2015
{
    public string GetVersion()
    {
        return "0.1.0";
    }

    public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
    {
        OptionObject2015 returnOptionObject = new OptionObject2015();

        returnOptionObject.ErrorCode = 3;
        returnOptionObject.ErrorMesg = "Hello, World!";

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
}
```

In your Program.cs reference the your ScriptLink service class(es).

```c#
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSoapCore();
builder.Services.TryAddSingleton<IScriptLinkService2015, ScriptLinkService2015>();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    _ = endpoints.UseSoapEndpoint<IScriptLinkService2015>("/ScriptLinkService2015.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();
```

Check out [the documentation](https://scriptlink.rarelysimple.com/) to learn more.

## Licensing ##

AvatarScriptLink.NET is open source under the [MIT License](https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/blob/master/LICENSE) and free for commercial use.
