using System.IO;
using Newtonsoft.Json;

namespace WaterPolo.Simple.Core
{
    public static class SettingsHelper
    {
        public static void SaveData(this object data, string rootFolder, string name)
        {
            var fileName = Path.Combine(rootFolder, name);
            if (!Directory.Exists(rootFolder)) Directory.CreateDirectory(rootFolder);
            File.WriteAllText(fileName, JsonConvert.SerializeObject(data));
        }

        public static T LoadData<T>(string rootFolder, string name)
        {
            var fileName = Path.Combine(rootFolder, name);
            if (!File.Exists(fileName)) return default(T);

            return JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
        }
    }
}