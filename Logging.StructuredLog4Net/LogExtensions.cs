using log4net;
using Newtonsoft.Json;
using System;

namespace Logging.StructuredLog4Net
{
    public static class LogExtensions
    {
        /// <summary>
        /// Logs a formatted message string with the Debug level including a value object.
        /// </summary>
        public static void Debug(this ILog logger, string message, object value)
        {
            if (value == null)
            {
                logger.Debug(message);
            }
            else
            {
                logger.DebugFormat("{0} {1}", message, JsonConvert.SerializeObject(value));
            }
        }

        /// <summary>
        /// Logs a formatted message string with the Debug level including a value object and the stack trace of the exception.
        /// </summary>
        public static void Debug(this ILog logger, string message, object value, Exception exception)
        {
            if (value == null)
            {
                logger.DebugFormat("{0} {1}", message, JsonConvert.SerializeObject(exception));
            }
            else
            {
                logger.DebugFormat("{0} {1} {2}", message, JsonConvert.SerializeObject(value), JsonConvert.SerializeObject(exception));
            }
        }

        /// <summary>
        /// Logs a formatted message string with the Info level including a value object.
        /// </summary>
        public static void Info(this ILog logger, string message, object value)
        {
            if (value == null)
            {
                logger.Info(message);
            }
            else
            {
                logger.InfoFormat("{0} {1}", message, JsonConvert.SerializeObject(value));
            }
        }

        /// <summary>
        /// Logs a formatted message string with the Info level including a value object and the stack trace of the exception.
        /// </summary>
        public static void Info(this ILog logger, string message, object value, Exception exception)
        {
            if (value == null)
            {
                logger.InfoFormat("{0} {1}", message, JsonConvert.SerializeObject(exception));
            }
            else
            {
                logger.InfoFormat("{0} {1} {2}", message, JsonConvert.SerializeObject(value), JsonConvert.SerializeObject(exception));
            }
        }

        /// <summary>
        /// Logs a formatted message string with the Warn level including a value object.
        /// </summary>
        public static void Warn(this ILog logger, string message, object value)
        {
            if (value == null)
            {
                logger.Warn(message);
            }
            else
            {
                logger.WarnFormat("{0} {1}", message, JsonConvert.SerializeObject(value));
            }
        }

        /// <summary>
        /// Logs a formatted message string with the Warn level including a value object and the stack trace of the exception.
        /// </summary>
        public static void Warn(this ILog logger, string message, object value, Exception exception)
        {
            if (value == null)
            {
                logger.WarnFormat("{0} {1}", message, JsonConvert.SerializeObject(exception));
            }
            else
            {
                logger.WarnFormat("{0} {1} {2}", message, JsonConvert.SerializeObject(value), JsonConvert.SerializeObject(exception));
            }
        }

        /// <summary>
        /// Logs a formatted message string with the Error level including a value object.
        /// </summary>
        public static void Error(this ILog logger, string message, object value)
        {
            if (value == null)
            {
                logger.Error(message);
            }
            else
            {
                logger.ErrorFormat("{0} {1}", message, JsonConvert.SerializeObject(value));
            }
        }

        /// <summary>
        /// Logs a formatted message string with the Error level including a value object and the stack trace of the exception.
        /// </summary>
        public static void Error(this ILog logger, string message, object value, Exception exception)
        {
            if (value == null)
            {
                logger.ErrorFormat("{0} {1}", message, JsonConvert.SerializeObject(exception));
            }
            else
            {
                logger.ErrorFormat("{0} {1} {2}", message, JsonConvert.SerializeObject(value), JsonConvert.SerializeObject(exception));
            }
        }

        /// <summary>
        /// Logs a formatted message string with the Fatal level including a value object.
        /// </summary>
        public static void Fatal(this ILog logger, string message, object value)
        {
            if (value == null)
            {
                logger.Fatal(message);
            }
            else
            {
                logger.FatalFormat("{0} {1}", message, JsonConvert.SerializeObject(value));
            }
        }

        /// <summary>
        /// Logs a formatted message string with the Fatal level including a value object and the stack trace of the exception.
        /// </summary>
        public static void Fatal(this ILog logger, string message, object value, Exception exception)
        {
            if (value == null)
            {
                logger.FatalFormat("{0} {1}", message, JsonConvert.SerializeObject(exception));
            }
            else
            {
                logger.FatalFormat("{0} {1} {2}", message, JsonConvert.SerializeObject(value), JsonConvert.SerializeObject(exception));
            }
        }
    }
}
