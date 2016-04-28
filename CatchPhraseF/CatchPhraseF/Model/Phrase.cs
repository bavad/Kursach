using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPhraseF.Model
{
    [Serializable]
    class Phrase
    {
        public string Content { get; set; }
        public string Year { get; set; }     // !!!
        public Author Author { get; set; }
        public Source Source { get; set; }
        public double Id { get; set; }
        public Phrase()
        {
            Content = "";
            Year = "";
            Author = null;
            Source = null;
            Id = -1;
        }
        public Phrase(string c, string y, Author a, Source s,double i)
        {
            Content = c;
            Year = y;
            Author = a;
            Source = s;
            Id = i;
        }
        public bool Find(string s)
        {
            string temp = "";
            for (int i = 0; i <= Content.Length - s.Length; i++)
            {
                for (int j = i; j < i + s.Length; j++)
                {
                    temp += Content[j];
                }

                if (temp.Equals(s))
                    return true;
                temp = "";
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format("{0}({1},{2},{3}).", Content, Author.Name, Source, Year);
        }
    }
}
