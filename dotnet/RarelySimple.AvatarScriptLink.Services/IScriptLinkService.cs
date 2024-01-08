using RarelySimple.AvatarScriptLink.Objects;
using System.ServiceModel;

namespace RarelySimple.AvatarScriptLink.Services
{
    [ServiceContract]
    public interface IScriptLinkService
    {
        [OperationContract]
        string GetVersion();

        [OperationContract]
        OptionObject RunScript(OptionObject optionObject, string parameter);
    }
}
