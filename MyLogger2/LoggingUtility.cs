using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLogger2
{
    public class LoggingUtility
    {

        private static readonly Logger _appLogger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Logs an info-level level event.
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="functionName"></param>
        public static void LogInfoEvent(Exception ex, string functionName = "n/a")
        {
            _appLogger.Log(LogLevel.Info, ex, $"{DateTime.Now.ToLongTimeString()} {functionName}: {ex.GetBaseException()}");
        }

        /// <summary>
        /// Logs an info-level level event that may not have an exception associated with it.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="functionName"></param>
        public static void LogInfoEvent(string message, string functionName = "n/a")
        {
            _appLogger.Log(LogLevel.Info, $"{DateTime.Now.ToLongTimeString()} {functionName}: {message}");
        }

        /// <summary>
        /// Logs a debug-level level event.
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="functionName"></param>
        public static void LogDebugEvent(Exception ex, string functionName = "n/a")
        {
            _appLogger.Log(LogLevel.Debug, ex, $"{DateTime.Now.ToLongTimeString()} {functionName}: {ex.GetBaseException()}");
        }

        /// <summary>
        /// Logs a debug-level level event that may not have an exception associated with it.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="functionName"></param>
        public static void LogDebugEvent(string message, string functionName = "n/a")
        {
            _appLogger.Log(LogLevel.Debug, $"{DateTime.Now.ToLongTimeString()} {functionName}: {message}");
        }

        /// <summary>
        /// Logs an error-level level event.
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="functionName"></param>
        public static void LogErrorEvent(Exception ex, string functionName = "n/a")
        {
            _appLogger.Log(LogLevel.Error, ex, $"{DateTime.Now.ToLongTimeString()} {functionName}: {ex.GetBaseException()}");
        }

        /// <summary>
        /// Logs an error-level level event that may not have an exception associated with it.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="functionName"></param>
        public static void LogErrorEvent(string message, string functionName = "n/a")
        {
            _appLogger.Log(LogLevel.Error, $"{DateTime.Now.ToLongTimeString()} {functionName}: {message}");
        }
    }
}