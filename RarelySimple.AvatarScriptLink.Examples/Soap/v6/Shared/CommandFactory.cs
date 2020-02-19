using NLog;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public static class CommandFactory
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Returns the desired command based on the provided <see cref="OptionObject2015"/> and parameter.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static IRunScriptCommand GetCommand(IOptionObject2015 optionObject, string parameter)
        {
            if (optionObject == null)
            {
                logger.Error("The provided {object} is null", nameof(OptionObject2015));
                return new DefaultScriptCommand(new OptionObjectDecorator(new OptionObject2015()), parameter);
            }

            // Setup Decorator
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);

            // Determine ScriptName
            string scriptName = parameter != null ? parameter.Split(',')[0] : "";
            logger.Debug("Script '" + scriptName + "' requested.");

            // Get Dependencies, such as repositories and services

            // Select Command
            switch (scriptName)
            {
                case "GetErrorCode0":
                    logger.Debug(nameof(GetErrorCode0Command) + " selected.");
                    return new GetErrorCode0Command(optionObjectDecorator);
                case "GetErrorCode1":
                    logger.Debug(nameof(GetErrorCode1Command) + " selected.");
                    return new GetErrorCode1Command(optionObjectDecorator);
                case "GetErrorCode2":
                    logger.Debug(nameof(GetErrorCode2Command) + " selected.");
                    return new GetErrorCode2Command(optionObjectDecorator);
                case "GetErrorCode3":
                    logger.Debug(nameof(GetErrorCode3Command) + " selected.");
                    return new GetErrorCode3Command(optionObjectDecorator);
                case "GetErrorCode4":
                    logger.Debug(nameof(GetErrorCode4Command) + " selected.");
                    return new GetErrorCode4Command(optionObjectDecorator);
                case "GetErrorCode5":
                    logger.Debug(nameof(GetErrorCode5Command) + " selected.");
                    return new GetErrorCode5Command(optionObjectDecorator);
                case "GetErrorCode6":
                    logger.Debug(nameof(GetErrorCode6Command) + " selected.");
                    return new GetErrorCode6Command(optionObjectDecorator);
                case "GetFieldValue":
                    logger.Debug(nameof(GetFieldValueCommand) + " selected.");
                    return new GetFieldValueCommand(optionObjectDecorator, parameter);
                case "SetFieldValue":
                    logger.Debug(nameof(SetFieldValueCommand) + " selected.");
                    return new SetFieldValueCommand(optionObjectDecorator, parameter);
                default:
                    logger.Debug(nameof(DefaultScriptCommand) + " selected.");
                    return new DefaultScriptCommand(optionObjectDecorator, scriptName);
            }
        }
    }
}