using Newtonsoft.Json;
using System.IO;

namespace RubberDuckGPT
{
    public class AppSettings
    {
        public string OpenAIApiKey { get; set; }

        public static AppSettings LoadSettings(string path)
        {
            if(File.Exists(path))
            {
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<AppSettings>(json);
            }
             
            return new AppSettings();
        }

        public void SaveSettings(string path)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
