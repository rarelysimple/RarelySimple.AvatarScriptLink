using RarelySimple.AvatarScriptLink.Objects;
using System.ServiceModel;

namespace RarelySimple.AvatarScriptLink.Services
{
    [ServiceContract]
    public interface IScriptLinkService2015
    {
        [OperationContract]
        string GetVersion();

        [OperationContract]
        OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter);
    }
}
