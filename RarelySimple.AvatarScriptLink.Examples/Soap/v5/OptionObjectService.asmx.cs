using NLog;
using RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using System.Web.Services;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v5
{
    /// <summary>
    /// Summary description for OptionObjectService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class OptionObjectService : WebService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        [WebMethod]
        public string GetVersion()
        {
            IGetVersionCommand command = new GetVersionCommand(new OptionObject());
            if (command == null)
            {
                logger.Error("A valid GetVersion command was not retrieved.");
                return "";
            }
            return command.Execute();
        }

        [WebMethod]
        public OptionObject RunScript(OptionObject optionObject, string parameter)
        {
            IRunScriptCommand command = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);
            if (command == null)
            {
                logger.Error("A valid RunScript command was not retrieved.");
                return optionObject;
            }
            return command.Execute().ToOptionObject();
        }
    }
}
