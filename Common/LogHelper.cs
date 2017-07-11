using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace Common
{
    public class LogHelper
    {
        private static readonly object lockThis = new object();
        private static string sPath;

        static LogHelper()
        {
            var configPath = "Log";
            sPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configPath);
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }

        }
        public static void WriteLog(string msg, ConsoleColor color = ConsoleColor.White)
        {
            lock (lockThis)
            {

                var fileName = Path.Combine(sPath, $"{DateTime.Now.ToString("yyyy-MM-dd")}.log");
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine($"{DateTime.Now}  :  {msg}");
                    sw.Flush();
                }
                Console.ForegroundColor = color;
                msg.ToCharArray().ToList().ForEach(r => { Console.Write(r); Thread.Sleep(20); });
                Console.WriteLine();
            }
        }
    }
}