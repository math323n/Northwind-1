using System;
using System.IO;
using System.Net.Http;

namespace NT.Logger
{
    static class Logger
    {
       private static string logFilePath;

        private static void Configure()
        {
            string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            logFilePath = $"{directory}/log.txt";
        }

        public static void Log(string message)
        {

        }

        public static void Log(Exception e)
        {
            
        }

        private static void WriteLog(string message)
        {
            using(StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                // Write...
                writer.WriteLine(message);
            }
        }
    }
}