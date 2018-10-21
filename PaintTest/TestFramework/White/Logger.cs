using NLog;
namespace TestFramework.white
{
    public class Logger
    {
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();

        public static void Log(string message, LogLevel logLevel = null)
        {
            _logger.Log(logLevel??LogLevel.Info,message);
        }
    }
}
