using System;
using Newtonsoft.Json;
using System.IO;
using QuickType;
namespace OBS_Scene_Packer
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Example Usage:");
                Console.WriteLine("Application BACKUP ./Scene.json");
                Console.WriteLine("Application RESTORE ./Scene.json");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(1);
            }
            if (args[0].ToUpper() == "BACKUP")
            {
                var Settings = ObsJson.FromJson(File.ReadAllText(args[1]));
                var newSettings = Settings;
                string tmpDir = "./SceneBackupTemp/";
                Directory.CreateDirectory(tmpDir);
                //.RootObject>(File.ReadAllText(args[0]));
                int x = 0;
                foreach (var source in Settings.Sources)
                {
                    var FileName = Path.GetFileName(source.Settings.File);
                    var newFile = tmpDir + FileName;
                    File.Copy(source.Settings.File, newFile);
                    newSettings.Sources[x].Settings.File = "%NEWPATH%" + "/" + FileName;
                }
                var JsonName = Path.GetFileName(args[1]);
                File.WriteAllText(tmpDir + JsonName, JsonConvert.SerializeObject(newSettings, Formatting.Indented));
                Directory.Move(tmpDir, JsonName);
                Console.WriteLine("Scene backed up to " + JsonName);
            }
            if (args[0].ToUpper() == "RESTORE")
            {
                var JsonName = Path.GetFullPath(args[1]);
                JsonName = JsonName.Remove(JsonName.Length, Path.GetFileName(args[1]).Length * -1);
                var JSON = File.ReadAllText(args[1]);
                JSON.Replace("%NEWPATH%", JsonName);
                File.WriteAllText(args[1] + ".Restored.json", JSON);
            }
        }
    }

}
