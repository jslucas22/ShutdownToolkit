using ShutdownToolkit.Domain.Global;
using System;
using System.IO;

namespace ShutdownToolkit.Service.Service.LogService
{
    public class Log
    {
        private static void CreateDirectory()
        {
            if (!Directory.Exists(Properties.Directory))
                Directory.CreateDirectory(Properties.Directory);
        }

        private static void WriteToFile(string message)
        {
            using (var sw = new StreamWriter(path: Properties.FileName, append: true))
            {
                sw.WriteLine($"SHTDWN_TLKT | {DateTime.Now} | {message}");
            }
        }

        public static void WriteLog(string message)
        {
            CreateDirectory();

            WriteToFile(message: message);
        }
    }
}
