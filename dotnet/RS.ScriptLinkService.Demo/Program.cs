using Microsoft.Extensions.DependencyInjection.Extensions;
using RarelySimple.AvatarScriptLink.Services;
using RS.ScriptLinkService.Demo;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSoapCore();
builder.Services.TryAddSingleton<IScriptLinkService, ScriptLinkService>();
builder.Services.TryAddSingleton<IScriptLinkService2, ScriptLinkService2>();
builder.Services.TryAddSingleton<IScriptLinkService2015, ScriptLinkService2015>();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    _ = endpoints.UseSoapEndpoint<IScriptLinkService>("/ScriptLinkService.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
    _ = endpoints.UseSoapEndpoint<IScriptLinkService2>("/ScriptLinkService2.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
    _ = endpoints.UseSoapEndpoint<IScriptLinkService2015>("/ScriptLinkService2015.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();
