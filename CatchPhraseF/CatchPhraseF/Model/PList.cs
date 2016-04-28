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

        public Phrase this[int i]
        {
            get { return phrases[i]; }
            set { phrases[i] = value; }            
        }
        public int Length
        {
            get { return phrases.Count; }
        }
        public void Write()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("plist.dat", FileMode.OpenOrCreate))
                {
                    binFormat.Serialize(fStream, phrases);
                }
            }
            catch { }
        }
        public void Read()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("plist.dat", FileMode.Open))
                {
                    phrases = (List<Phrase>)binFormat.Deserialize(fStream);
                }
            }
            catch { }
        }
        public void Add(Phrase q)
        {
            phrases.Add(q);
        }
        public void Remove(Phrase q)
        {
            phrases.Remove(q);
        }

        public override string ToString()
        {
            Read();
            string r = "";
            foreach (Phrase q in phrases)
            {
                r += q.ToString();
            }
            return r;
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
    }
}
