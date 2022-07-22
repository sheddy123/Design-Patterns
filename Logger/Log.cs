using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    public class Log : ILog
    {
        private static int counter = 0;
        private Log()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());

        public static Log GetInstance
        {
            get => instance.Value;
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0} {1}.log", "Exception", DateTime.Now.ToShortDateString());
            string logFilePath = string.Format(@"{0}\{1}", "C:\\Users\\iodom\\source\\repos\\Design Patterns\\Design Patterns", fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine(DateTime.Now.ToShortDateString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
