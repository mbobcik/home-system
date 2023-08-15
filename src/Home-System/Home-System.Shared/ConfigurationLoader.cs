using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Home_System.Shared
{
    public class ConfigurationLoader
    {
        // TODO: Create as singleton. Or maybe somehow via dependency injection

        private const string configFileName = "configuration.json";
        private Configuration configuration;
        private ConfigurationLoader() 
        { 
            if (File.Exists(configFileName))
            {
                string jsonString = File.ReadAllText(configFileName);
                configuration = JsonSerializer.Deserialize<Configuration>(jsonString);
                if (configuration == null )
                {
                    configuration = new Configuration();
                }
            }
            else
            {
                configuration = new Configuration();
                using FileStream createStream = File.Create(configFileName);
                JsonSerializer.Serialize(createStream, configuration, new JsonSerializerOptions
                {
                    AllowTrailingCommas = true,
                    WriteIndented = true,
                });
                createStream.Dispose();
            }
        }
        
    }
}
