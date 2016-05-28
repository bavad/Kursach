using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchPhraseF.Model
{
    [Serializable]
    class Author
    {
        
        public string Name { get; set; }
        public string Born { get; set; }
        public string Die { get; set; }
        public string Bio { get; set; }        
        public double Id { get; set; }        
        public bool Change { get; set; }
        public bool AddChange { get; set; }

        public Author(string n, string b, string d, string bio,double i)
        {
            Name = n;
            Born = b;
            Die = d;
            Bio = bio;
            Id = i;
        }
    }
}
