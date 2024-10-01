using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class SaveSystem
    {
        private string pathToDirectory, localPathTryes, localSettingsPath;
        public SaveSystem(string _DirName = "pjd Project")
        {
            pathToDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + _DirName;
            localPathTryes = "//allTryes.txt";
            localSettingsPath = "//settings.sett";
            if (!Directory.Exists(pathToDirectory))
            {
                Directory.CreateDirectory(pathToDirectory);
                List<string> text = new List<string>();
                text.Add("0");
                File.WriteAllLines(pathToDirectory + localPathTryes, text);
            }
            if (!File.Exists(pathToDirectory + localSettingsPath))
            {
                List<string> text = new List<string>();
                text.Add("1");
                File.WriteAllLines(pathToDirectory + localSettingsPath, text);
            }
        }

        public List<string> GetAllTryes()
        {
            List<string> _list = File.ReadAllLines(pathToDirectory + localPathTryes).ToList();
            return _list;
        }

        public bool isActiveMusic => File.ReadAllLines(pathToDirectory + localSettingsPath)[0] == "1";
        public bool isActiveSound => File.ReadAllLines(pathToDirectory + localSettingsPath)[1] == "1";

        public void SaveSettings(bool music, bool sounds)
        {
            var _list = new List<string>();
            _list.Add(music ? "1" : "0");
            _list.Add(sounds ? "1" : "0");
            File.WriteAllLines(pathToDirectory + localSettingsPath, _list);
        }

        public void AddNewTry(string _try)
        {
            var _list = new List<string>();
            _list.Add(_try);
            foreach(var item in GetAllTryes())
            {
                _list.Add(item);
            }
            File.WriteAllLines(pathToDirectory + localPathTryes, _list);
        }
    }
}
