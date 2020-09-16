using System;
using System.IO;
using System.Net.Http;

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
            string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            logFilePath = $"{directory}/log.txt";
        }

        /// <summary>
        /// Method for handling messages
        /// </summary>
        /// <param name="message"></param>
        public static void Log(string message)
        {

        }

        /// <summary>
        /// Method for handling exception Logs
        /// </summary>
        /// <param name="ex"></param>
        public static void Log(Exception ex)
        {
            string message = "Message: " + ex.Message + Environment.NewLine + "StackTrace :" + ex.StackTrace +
                       "" + Environment.NewLine + "Date :" + DateTime.Now.ToString() + "\n-----------------------------------------------------------------------------";
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