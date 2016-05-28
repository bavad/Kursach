using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CatchPhraseF.Model
{
    [Serializable]
    class TList
    {
        List<string> themes = new List<string>();

        public List<string> Themes
        {
            get { return themes; }
            set { themes = value; }           
        }

        public string this[int i] // Индексатор коллекции тем.
        {
            get { return themes[i]; }
            set { themes[i] = value; }            
        }

        public void Write() // Сериализация коллекции тем.
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("tlist.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, themes);
            }
        }
       
        public void Read() // Десериализация коллекции тем.
        {
            BinaryFormatter binFormat = new BinaryFormatter();            
            using (Stream fStream = new FileStream("tlist.dat", FileMode.Open))
            {
                themes = (List<string>)binFormat.Deserialize(fStream);
            }            
        }

        public void Add(string s) // Добавление темы в коллекцию.
        {
            themes.Add(s);
        }

        public bool Exist(string a) // Метод, проверяющий наличие темы в коллекции.
        {
            foreach (string t in themes)
            {
                if (t==a)
                    return true;
            }
            return false;
        }

        public string RemoveSpaces(string s) // Убирает лишние пробелы.
        {
            string[] s1 = s.Split(' ');
            string r = "";
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != "")
                {
                    r += s1[i];
                    if (i != s1.Length - 1)
                    {
                        r += " ";
                    }
                }
            }
            return r;
        }
    }
}
