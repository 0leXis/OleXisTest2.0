using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace OleXisTestServer
{

    static public class ConfigContainer
    {
        static private Config config;
        static public Config GetConfig()
        {
            if (config == null)
                config = Config.ConfigFromJSONFile(Config.DEFAULT_CONFIG_FILE);
            return config;
        }

        static public void Save()
        {
            config.Save(Config.DEFAULT_CONFIG_FILE);
        }

        public class Config
        {
            public const string DEFAULT_CONFIG_FILE = "config.cfg";
            public bool AllowRegistrationRequests { get; set; } = false;
            public bool AllowStudentsRegistration { get; set; } = false;
            public bool AllowTeacherRegistration { get; set; } = false;
            public bool AllowGroupsAdding { get; set; } = false;
            public bool AllowSubjectsAdding { get; set; } = false;
            public string DBIP { get; set; } = "127.0.0.1";
            public string DBUser { get; set; } = "root";
            public string DBPassword { get; set; } = "12345";
            public Config() { }

            static public Config ConfigFromJSONFile(string fileName)
            {
                if (File.Exists(fileName))
                    using (var file = new StreamReader(fileName, Encoding.UTF8))
                    {
                        return JsonConvert.DeserializeObject<Config>(file.ReadToEnd());
                    }
                else
                    return new Config();
            }

            public void Save(string fileName)
            {
                using (var file = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    file.Write(JsonConvert.SerializeObject(this));
                }
            }
        }
    }
}
