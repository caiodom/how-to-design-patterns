
using Singleton;

//Access the singleton instance
ConfigurationManager configManager = ConfigurationManager.Instance;

// Get and display default settings
Console.WriteLine("AppTitle: " + configManager.GetSetting("AppTitle"));
Console.WriteLine("Version: " + configManager.GetSetting("Version"));
Console.WriteLine("DefaultLanguage: " + configManager.GetSetting("DefaultLanguage"));

// Set a new setting
configManager.SetSetting("AppTitle", "My Updated Application");

// Get and display the updated setting
Console.WriteLine("Updated AppTitle: " + configManager.GetSetting("AppTitle"));