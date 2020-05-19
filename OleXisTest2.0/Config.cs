using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace OleXisTest
{
    public class Config
    {
        public const string DEFAULT_CONFIG_FILE = "config.cfg";
        public int? ServerPort { get; set; } = null;
        public string ServerIP { get; set; } = null;

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
