using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Hafta_Singleton
{
    public class ConfigurationService
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
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
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
