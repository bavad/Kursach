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
    class PList
    {
        List<Phrase> phrases = new List<Phrase>();

        public List<Phrase> Phrases
        {
            get { return phrases; }
            set { phrases = value; }            
        }

        public Phrase this[int i] // Индексатор для коллекции фраз.
        {
            get { return phrases[i]; }
            set { phrases[i] = value; }            
        }

        public int Length // Свойство - длина коллекции фраз.
        {
            get { return phrases.Count; }
        }

        public void Write() // Сериализация коллекции фраз.
        {
            BinaryFormatter binFormat = new BinaryFormatter();            
            using (Stream fStream = new FileStream("plist.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, phrases);
            }
            
        }
        public void Read() // Десериализация коллекции фраз.
        {
            BinaryFormatter binFormat = new BinaryFormatter();            
            using (Stream fStream = new FileStream("plist.dat", FileMode.Open))
            {
                phrases = (List<Phrase>)binFormat.Deserialize(fStream);
            }
            
        }

        public void Add(Phrase q) // Добавление фразы в коллекцию.
        {
            phrases.Add(q);
        }
        public void Remove(Phrase q) // Удаление фразы из коллекции.
        {
            phrases.Remove(q);
        }
        public void RemoveAt(int i) // Удаление фразы из коллекции по номеру.
        {
            phrases.RemoveAt(i);
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

        public List<string> AllP() // Возвращает строковую коллекцию фраз.
        {
            Read();
            List<string> r = new List<string>();
            foreach (Phrase p in phrases)
            {
                r.Add(p.ToString());
            }
            return r;
        }

        public List<string> Search(string s, int n) // Метод поиска
        {
            Read();
            s = s.ToLower();
            List<string> r = new List<string>();
            for (int k = 0; k < Length; k++)
            {
                string sArea = "";
                if (n == 0)
                    sArea = this[k].Content.ToLower(); // Поиск по тексту.
                if (n == 1)
                    sArea = this[k].Author.Name.ToLower(); // По авторам.
                if (n == 2)
                    sArea = this[k].Theme.ToLower(); // По теме.
                if (n == 3)
                    sArea = this[k].Source.Name.ToLower();// По источнику.
                if (n == 4)
                    sArea = this[k].Source.Year;// По году.

                string temp = "";
                for (int i = 0; i <= sArea.Length - s.Length; i++)
                {
                    for (int j = i; j < i + s.Length; j++)   
                    {
                        temp += sArea[j];
                    }

                    if (temp.Equals(s))
                    {                        
                        r.Add(this[k].ToString());
                        break;
                    }

                    temp = "";
                }
            }
            return r;
        }
        public bool Exist(Phrase a) // Метод, проверяющий наличие фразы в базе.
        {
            foreach (Phrase p in phrases)
            {
                if (p.Author.Name == a.Author.Name && p.Source.Name == a.Source.Name && p.Theme == a.Theme && p.Content == a.Content)
                    return true;
            }

            return false;
        }
    }
}
