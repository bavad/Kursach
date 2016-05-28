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
        public string Year { get; set; }     
        public Author Author { get; set; }
        public Source Source { get; set; }
        public string Theme { get; set; }
        public double Id { get; set; }
        public bool Change { get; set; }
        public bool AddChange { get; set; }

        public Phrase()
        {
            Content = "";
            Year = "";
            Author = null;
            Source = null;
            Theme = "";
            Id = -1;
        }
        public Phrase(string c, string y, Author a, Source s,string t,double i)
        {
            Content = c;
            Year = y;
            Author = a;
            Source = s;
            Theme = t;
            Id = i;
        }
        
        public override string ToString() // Переопределение метода ToString().
        {
            return String.Format("{0}({1},{2},{3}).", Content, Author.Name, Source.Name, Year);
        }

        
    }
}
