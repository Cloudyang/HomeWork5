using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace Common
{
    public class LogHelper
    {
        private static object lockThis = new object();
        public static void WriteLog(string msg,ConsoleColor color=ConsoleColor.White)
        {
            lock (lockThis)
            {
                var configPath = PubConfig.GetAppSet("LogsPath");
                string path =
                    $"{AppDomain.CurrentDomain.BaseDirectory}{(string.IsNullOrWhiteSpace(configPath) ? "" : "\\" + configPath)}";
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                var fileName = $"{path}\\{DateTime.Now.ToString("yyyy-MM-dd")}.log";
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine($"{DateTime.Now}  :  {msg}");
                }
                Console.ForegroundColor = color;
                //Console.WriteLine(msg);
                msg.ToCharArray().ToList().ForEach(r => { Console.Write(r); Thread.Sleep(20); });
                Console.WriteLine();
            }
        }
    }
}