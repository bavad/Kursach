using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPhraseF.Model
{
    [Serializable]
    class Source
    {
        public string Name { get; set; }
        public Author Author { get; set; }
        public string Year { get; set; }
        public string Info { get; set; }
        public double Id { get; set; }
        public bool Change { get; set; }
        public bool AddChange { get; set; }

        public Source(string n, Author a, string y,string i,double id)
        {
            Name = n;
            Author = a;
            Year = y;
            Info = i;
            Id = id;
        }
    }
}
