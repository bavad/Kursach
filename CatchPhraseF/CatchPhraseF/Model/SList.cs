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
    class SList
    {
        List<Source> sources = new List<Source>();

        public List<Source> Sources
        {            
            get { return sources; }
            set { sources = value; }
        }

        public Source this[int i] // Индексатор для коллекции источников.
        {
            set { sources[i] = value; }
            get { return sources[i]; }
        }

        public int Length // Свойство - длина коллекции источников.
        {
            get { return sources.Count; }
        }

        public void Write() // Сериализация коллекции источников.
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("slist.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, sources);
            }
        }
        public void Read() // Десериализация коллекции источников
        {
            BinaryFormatter binFormat = new BinaryFormatter();            
            using (Stream fStream = new FileStream("slist.dat", FileMode.Open))
            {
                sources = (List<Source>)binFormat.Deserialize(fStream);
            }            
        }

        public void Add(Source s) // Добавление источника в коллекцию.
        {
            sources.Add(s);
        }
        public void Remove(Source s) // Удаление источника из коллекции.
        {
            sources.Remove(s);
        }
        public void RemoveAt(int i) // Удаление источника из коллекции по номеру.
        {
            sources.RemoveAt(i);
        }

        public string RemoveSpaces(string s) // Убирает лишние пробелы из строки.
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
        public List<Source> AuthSources(Author a) // Возвращает коллекцию источников автора.
        {
            List<Source> r = new List<Source>();
            for (int i = 0; i < Length; i++)
            {
                if (this[i].Author.Id == a.Id)
                {
                    r.Add(this[i]);
                }
            }
            return r;
        }
        public bool Exist(Source a) // Метод, проверяющий наличие источника в базе.
        {
            foreach (Source s in sources)
            {
                if (s.Name == a.Name && s.Year == a.Year && s.Author.Name == a.Author.Name && s.Info == a.Info)
                    return true;
            }

            return false;
        }

    }
}
