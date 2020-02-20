using NLog;
using RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Web.Services;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6
{
    /// <summary>
    /// Summary description for OptionObject2Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class OptionObject2Service : WebService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        [WebMethod]
        public string GetVersion()
        {
            IGetVersionCommand command = new GetVersionCommand(new OptionObject2());
            if (command == null)
            {
                logger.Error("A valid GetVersion command was not retrieved.");
                return "";
            }
            return command.Execute();
        }

        [WebMethod]
        public OptionObject2 RunScript(OptionObject2 optionObject, string parameterString)
        {
            IParameter parameter = new Parameter(parameterString);
            IRunScriptCommand command = CommandFactory.GetCommand(optionObject, parameter);
            if (command == null)
            {
                logger.Error("A valid RunScript command was not retrieved.");
                return optionObject;
            }
            return (OptionObject2)command.Execute();
        }
    }
}
