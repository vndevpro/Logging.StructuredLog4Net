using log4net;
using MessageTemplates;
using System;

namespace Logging.StructuredLog4Net
{
    public static class LogExtensions
    {
        /// <summary>
        /// Logs a formatted message string with the Debug level including value objects.
        /// </summary>
        public static void Debug(this ILog logger, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Debug(message);
        }

        /// <summary>
        /// Logs a formatted message string with the Debug level including value objects and the stack trace of the exception.
        /// </summary>
        public static void Debug(this ILog logger, Exception exception, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Debug(message, exception);
        }

        /// <summary>
        /// Logs a formatted message string with the Info level including value objects.
        /// </summary>
        public static void Info(this ILog logger, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Info(message);
        }

        /// <summary>
        /// Logs a formatted message string with the Info level including value objects and the stack trace of the exception.
        /// </summary>
        public static void Info(this ILog logger, Exception exception, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Info(message, exception);
        }

        /// <summary>
        /// Logs a formatted message string with the Warn level including value objects.
        /// </summary>
        public static void Warn(this ILog logger, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Warn(message);
        }

        /// <summary>
        /// Logs a formatted message string with the Warn level including value objects and the stack trace of the exception.
        /// </summary>
        public static void Warn(this ILog logger, Exception exception, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Warn(message, exception);
        }

        /// <summary>
        /// Logs a formatted message string with the Error level including value objects.
        /// </summary>
        public static void Error(this ILog logger, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Error(message);
        }

        /// <summary>
        /// Logs a formatted message string with the Error level including value objects and the stack trace of the exception.
        /// </summary>
        public static void Error(this ILog logger, Exception exception, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Error(message, exception);
        }

        /// <summary>
        /// Logs a formatted message string with the Fatal level including value objects.
        /// </summary>
        public static void Fatal(this ILog logger, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Fatal(message);
        }

        /// <summary>
        /// Logs a formatted message string with the Fatal level including value objects and the stack trace of the exception.
        /// </summary>
        public static void Fatal(this ILog logger, Exception exception, string messageTemplate, params object[] values)
        {
            var message = MessageTemplate.Format(messageTemplate, values);
            logger.Fatal(message, exception);
        }
    }
}
