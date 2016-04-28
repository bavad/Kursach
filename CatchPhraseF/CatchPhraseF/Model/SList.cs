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
        public Source this[int i]
        {
            set { sources[i] = value; }
            get { return sources[i]; }
        }
        public int Length
        {
            get { return sources.Count; }
        }
        public void Write()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("slist.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, sources);
            }
        }
        public void Read()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("slist.dat", FileMode.Open))
                {
                    sources = (List<Source>)binFormat.Deserialize(fStream);
                }
            }
            catch { }
        }
        public void Add(Source s)
        {
            sources.Add(s);
        }
        public void Remove(Source s)
        {
            sources.Remove(s);
        }
        public void RemoveAt(int i)
        {
            sources.RemoveAt(i);
        }
        public string RemoveSpaces(string s)
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
        public List<Source> AuthSources(Author a)
        {
            List<Source> r = new List<Source>();
            for (int i = 0; i < this.Length; i++)
            {
                if (this[i].Author.Id == a.Id)
                {
                    r.Add(this[i]);
                }
            }
            return r;
        }

    }
}
