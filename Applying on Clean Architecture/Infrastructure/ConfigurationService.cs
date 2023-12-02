using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applying_on_Clean_Architecture.Infrastructure
{
    internal class ConfigurationService
    {
        private static ConfigurationService instance;
        public static ConfigurationService CreateInstance()
        {
            if (instance is null)
                instance = new ConfigurationService();
            return instance;
        }
        public string GetValue(string key)
        {
            ConfigurationManager configurationManager = new();
            string path = Directory.GetCurrentDirectory();
            configurationManager.SetBasePath(path);
            configurationManager.AddJsonFile("Configuration.json");

            return configurationManager.GetSection(key).Value;
        }

        ConfigurationService()
        {
            Console.WriteLine("Instance Created");
        }
    }
}
