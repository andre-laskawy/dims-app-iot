using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Dims.Services.Speechrecognition.IoT.Helper
{
    public class Configuration
    {
        /// <summary>
        /// Defines the path to the configuration file
        /// </summary>
        private static string configFilePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationService"/> class.
        /// </summary>
        static Configuration()
        {
            var configFolderPath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "..");
            configFilePath = Path.Combine(configFolderPath, "appsettings.json");
        }

        public static Config Current { get; private set; }

        public static void Load()
        {
            if (File.Exists(configFilePath))
            {
                using (var s = File.OpenRead(configFilePath))
                {
                    using (var reader = new StreamReader(s))
                    {
                        var json = reader.ReadToEnd();
                        Current = JsonConvert.DeserializeObject<Config>(json);
                    }
                }
            }
        }

        public static void Save()
        {
            using (var s = File.OpenWrite(configFilePath))
            {
                using (var writer = new StreamWriter(s))
                {
                    var json = JsonConvert.SerializeObject(Current, Formatting.Indented);
                    writer.Write(json);
                }
            }
        }
    }
}
