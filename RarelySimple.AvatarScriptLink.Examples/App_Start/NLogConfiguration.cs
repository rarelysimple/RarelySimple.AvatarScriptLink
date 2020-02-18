using NLog;
using NLog.Config;
using NLog.Targets;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Examples
{
    public static class NLogConfiguration
    {
        [SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "Target is disposed elsewhere.")]
        public static void RegisterLogs()
        {
            var config = new LoggingConfiguration();

            string fileLocation = "C:\\Logs\\RarelySimple.AvatarScriptLink.Examples\\";
            string fileFolder = "";
            string fileExtension = ".log";
            LogLevel minLogLevel = LogLevel.Info;

            // Set values based on DEBUG vs RELEASE environment
#if DEBUG
            fileFolder = "Test\\";
            minLogLevel = LogLevel.Debug;
#else
            fileFolder = "Production\\";
#endif

            // Set Logging Targets
            FileTarget apiLogfile = new FileTarget("apiSoaplogfile")
            {
                Name = "Api.Commands",
                FileName = fileLocation + fileFolder + "api.soap" + fileExtension,
                ArchiveFileName = fileLocation + fileFolder + "Archive\\Api\\api.{#}" + fileExtension,
                ArchiveEvery = FileArchivePeriod.Day,
                ArchiveNumbering = ArchiveNumberingMode.Date,
                MaxArchiveFiles = 14,
                ConcurrentWrites = true,
                KeepFileOpen = false,
                Encoding = Encoding.UTF8
            };

            // Set Rules for mapping loggers to targets            
            config.AddRule(minLogLevel, LogLevel.Fatal, apiLogfile, "RarelySimple.AvatarScriptLink.Examples.Soap.*");       // Logs from .asmx files

            // Apply config           
            LogManager.Configuration = config;
        }
    }
}