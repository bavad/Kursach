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
    class AList
    {
        List<Author> authors = new List<Author>();

        public List<Author> Authors
        {
            get { return authors; }
            set { authors = value; }            
        }

        public Author this[int i]
        {
            get { return authors[i]; }
            set { authors[i] = value; }            
        }
        public int Length
        {
            get { return authors.Count; }
        }

        public void Write()
        {
            
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("alist.dat", FileMode.OpenOrCreate))
                    {
                        binFormat.Serialize(fStream, authors);
                    }
            }
            catch { }
        }

        public void Read()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("alist.dat", FileMode.OpenOrCreate))
                {
                    authors = (List<Author>)binFormat.Deserialize(fStream);
                }
            }
            catch { }
        }

        public void Add(Author a)
        {
            authors.Add(a);
        }

        public void RemoveAt(int n)
        {
            authors.RemoveAt(n);

        }
        public bool Exist(Author a)
        {
            foreach (Author x in authors)
            {
                if (x.Name == a.Name && x.Born == a.Born && x.Die == a.Die && a.Bio == x.Bio)
                    return true;
            }
            return false;
        }
        public bool checkDate(string s)
        {
            string[] s1 = s.Split('.');
            if (s1[0] == "" && s1[1] == "" && s1[2] == "")
                return false;
            int[] temp = { Convert.ToInt32(s1[0]), Convert.ToInt32(s1[1]), Convert.ToInt32(s1[2]) };
            if (temp[1] <= 0 || temp[1] > 12)
                return false;            
            else if (temp[1] == 1 || temp[1] == 3 || temp[1] == 5 || temp[1] == 7 || temp[1] == 8 || temp[1] == 10 || temp[1] == 12)
            {
                if (temp[0] <= 0 || temp[0] > 31)
                    return false;                
            }
            else if (temp[1] == 4 || temp[1] == 6 || temp[1] == 9 || temp[1] == 11)
            {
                if (temp[0] <= 0 || temp[0] > 30)
                    return false;                
            }
            else if (temp[1] == 2)
            {
                if (temp[0] <= 0 || temp[0] > 29)
                    return false;            
            }
            if (temp[2] > 2016)
                return false;

            return true;
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
