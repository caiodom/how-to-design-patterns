using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ConfigurationManager
    {
        // Lazy instance ensures thread-safe lazy initialization
        private static readonly Lazy<ConfigurationManager> lazyInstance =
            new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        // Dictionary to store configuration settings
        private readonly Dictionary<string, string> settings;

        // Private constructor to prevent instantiation from outside
        private ConfigurationManager()
        {
            // Initialize the settings dictionary
            settings = new Dictionary<string, string>();

            // Load default settings (could be from a file, database, etc.)
            LoadDefaultSettings();
        }

        // Public static property to get the singleton instance
        public static ConfigurationManager Instance => lazyInstance.Value;

        // Method to load default settings
        private void LoadDefaultSettings()
        {
            settings["AppTitle"] = "My Application";
            settings["Version"] = "1.0.0";
            settings["DefaultLanguage"] = "en";
        }

        // Method to get a setting value by key
        public string GetSetting(string key)
        {
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            return null;
        }

        // Method to set a setting value
        public void SetSetting(string key, string value)
        {
            if (settings.ContainsKey(key))
            {
                settings[key] = value;
            }
            else
            {
                settings.Add(key, value);
            }
        }

    }
}
