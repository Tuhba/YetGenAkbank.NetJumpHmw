using _10.Hafta_Singleton;

ConfigurationService configurationService =     ConfigurationService.CreateInstance();
ConfigurationService.CreateInstance();
ConfigurationService.CreateInstance();
ConfigurationService.CreateInstance();

var azureConnectionString = configurationService.GetValue("Storage:Azure");
Console.WriteLine();