using System;
using System.IO;
using System.Net.Http;
using System.Configuration;

namespace NT.Logger
{
    public static class Logger
    {
        private static string logFilePath;

        /// <summary>
        /// Configure the filepath.
        /// </summary>
        public static void Configure()
        {



            logFilePath = ConfigurationManager.AppSettings["LogFilePath"].ToString();


            // = $"{directory}/log.txt";
        }

        /// <summary>
        /// Method for handling message Logs
        /// </summary>
        /// <param name="message"></param>
        public static void Log(string message)
        {
            WriteLog(message);
        }

        /// <summary>
        /// Method for handling exception Logs
        /// </summary>
        /// <param name="ex"></param>
        public static void Log(Exception ex)
        {
            // a line of dashes to seperate logs
            string line = new string('-', 170);
            // The string to be written to a log
            string message =
                $"Date: {DateTime.Now}\n" +
                $"Message: {ex.Message}\n" +
                $"Source: {ex.Source}\n" +
                $"InnerException: {ex.InnerException}\n" +
                $"StackTrace: {ex.StackTrace}\n" +
                $"{line}";
            // Send message to be written
            WriteLog(message);
        }

        /// <summary>
        /// Write log to the log file .txt document
        /// </summary>
        /// <param name="message"></param>
        private static void WriteLog(string message)
        {
            using StreamWriter writer = new StreamWriter(logFilePath, true);
            // Write...
            writer.WriteLine(message);
        }
    }
}