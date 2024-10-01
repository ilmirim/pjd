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
        private string pathToDirectory, localPathTryes;
        public SaveSystem(string _DirName)
        {
            pathToDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + _DirName;
            localPathTryes = "//allTryes.txt";
            if (!Directory.Exists(pathToDirectory))
            {
                Directory.CreateDirectory(pathToDirectory);
                List<string> text = new List<string>();
                text.Add("time 0:00");
                File.WriteAllLines(pathToDirectory + localPathTryes, text);
            }
        }

        public List<string> GetAllTryes()
        {
            List<string> _list = File.ReadAllLines(pathToDirectory + localPathTryes).ToList();
            return _list;
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
