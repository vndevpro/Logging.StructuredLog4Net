using log4net;
using Logging.StructuredLog4Net;
using System;

namespace Logging.StructuredLog4NetPOC
{
    class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            LogDebugWithObjectValue();
            LogDebugWithObjectValueAndException();

            LogInfoWithObjectValue();
            LogInfoWithObjectValueAndException();

            LogWarnWithObjectValue();
            LogWarnWithObjectValueAndException();

            LogErrorWithObjectValue();
            LogErrorWithObjectValueAndException();

            LogFatalWithObjectValue();
            LogFatalWithObjectValueAndException();

            Console.ReadLine();
        }

        private static void LogDebugWithObjectValue()
        {
            Logger.Debug("It happens at {@TheDate:d} - {TheDate:t}", DateTime.Now);
            Logger.Debug("Ext Info 1", new { Number = 100 });
            Logger.Debug("Ext Info 2 {0}", new
            {
                Time = DateTime.Now,
                Message = "This is \"NICE\""
            });
            Logger.Debug("Ext Info 3", new User
            {
                Id = 1,
                DateOfBirth = DateTime.Today,
                Status = true
            });
        }

        private static void LogDebugWithObjectValueAndException()
        {
            try
            {
                int y = 0;
                object x = 100 / y;
            }
            catch (Exception ex)
            {
                Logger.Debug(ex, "Error on ABCD {@X} - {@Y}", new { X = 100 }, new { Y = 0 });
            }
        }

        private static void LogInfoWithObjectValue()
        {
            Logger.Info("Ext Info 1", new { Number = 100 });
            Logger.Info("Ext Info 2 {0}", new
            {
                Time = DateTime.Now,
                Message = "This is \"NICE\""
            });
            Logger.Info("Ext Info 3", new User
            {
                Id = 1,
                DateOfBirth = DateTime.Today,
                Status = true
            });
        }

        private static void LogInfoWithObjectValueAndException()
        {
            try
            {
                int y = 0;
                object x = 100 / y;
            }
            catch (Exception ex)
            {
                Logger.Info(ex, "Error on ABCD {@X} - {@Y}", new { X = 100 }, new { Y = 0 });
            }
        }

        private static void LogWarnWithObjectValue()
        {
            Logger.Warn("Ext Info 1", new { Number = 100 });
            Logger.Warn("Ext Info 2 {0}", new
            {
                Time = DateTime.Now,
                Message = "This is \"NICE\""
            });
            Logger.Warn("Ext Info 3", new User
            {
                Id = 1,
                DateOfBirth = DateTime.Today,
                Status = true
            });
        }

        private static void LogWarnWithObjectValueAndException()
        {
            try
            {
                int y = 0;
                object x = 100 / y;
            }
            catch (Exception ex)
            {
                Logger.Warn(ex, "Error on ABCD {@X} - {@Y}", new { X = 100 }, new { Y = 0 });
            }
        }

        private static void LogErrorWithObjectValue()
        {
            Logger.Error("Ext Info 1", new { Number = 100 });
            Logger.Error("Ext Info 2 {0}", new
            {
                Time = DateTime.Now,
                Message = "This is \"NICE\""
            });
            Logger.Error("Ext Info 3", new User
            {
                Id = 1,
                DateOfBirth = DateTime.Today,
                Status = true
            });
        }

        private static void LogErrorWithObjectValueAndException()
        {
            try
            {
                int y = 0;
                object x = 100 / y;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error on ABCD {@X} - {@Y}", new { X = 100 }, new { Y = 0 });
            }
        }

        private static void LogFatalWithObjectValue()
        {
            Logger.Fatal("Ext Info 1", new { Number = 100 });
            Logger.Fatal("Ext Info 2 {0}", new
            {
                Time = DateTime.Now,
                Message = "This is \"NICE\""
            });
            Logger.Fatal("Ext Info 3", new User
            {
                Id = 1,
                DateOfBirth = DateTime.Today,
                Status = true
            });
        }

        private static void LogFatalWithObjectValueAndException()
        {
            try
            {
                int y = 0;
                object x = 100 / y;
            }
            catch (Exception ex)
            {
                Logger.Fatal(ex, "Error on ABCD {@X} - {@Y}", new { X = 100 }, new { Y = 0 });
            }
        }
    }
}
