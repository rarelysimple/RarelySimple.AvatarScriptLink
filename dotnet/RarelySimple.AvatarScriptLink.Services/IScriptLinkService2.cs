using RarelySimple.AvatarScriptLink.Objects;
using System.ServiceModel;

namespace RarelySimple.AvatarScriptLink.Services
{
    [ServiceContract]
    public interface IScriptLinkService2
    {
        [OperationContract]
        string GetVersion();

        [OperationContract]
        OptionObject2 RunScript(OptionObject2 optionObject, string parameter);
    }
}
