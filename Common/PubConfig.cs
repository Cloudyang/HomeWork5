using System;
using System.Configuration;
using System.IO;

namespace Common
{
    public class PubConfig
    {

        public static string GetAppSet(string key)
        {
            string value = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ConfigurationErrorsException($"未读取到配置项{key}，请在配置文件中进行配置");
            }
            return value;
        }


        public static string ReadConfigFile(string fileName)
        {
            var configPath = GetAppSet("ConfigPath");
            string path =$"{AppDomain.CurrentDomain.BaseDirectory}{(string.IsNullOrWhiteSpace(configPath) ? "" : "\\" + configPath)}"; 
            fileName = $"{path}\\{fileName}";
            return File.ReadAllText(fileName);
        }
    }

    
}