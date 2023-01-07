using NLog;
using RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Web.Services;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6
{
    /// <summary>
    /// Summary description for OptionObject2015Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class OptionObject2015Service : WebService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        [WebMethod]
        public string GetVersion()
        {
            IGetVersionCommand command = new GetVersionCommand(new OptionObject2015());
            if (command == null)
            {
                logger.Error("A valid GetVersion command was not retrieved.");
                return "";
            }
            return command.Execute();
        }

        [WebMethod]
        public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameterString)
        {
            IParameter parameter = new Parameter(parameterString);
            IRunScriptCommand command = CommandFactory.GetCommand(optionObject, parameter);
            if (command == null)
            {
                logger.Error("A valid RunScript command was not retrieved.");
                return optionObject;
            }
            return (OptionObject2015)command.Execute();
        }
    }
}
