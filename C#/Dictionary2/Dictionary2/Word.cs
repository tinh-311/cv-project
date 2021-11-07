using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    public class Word
    {
        private string tuTA;
        private List<string> nghia = new List<string>();

        public Word() { }

        public Word(string tuTA, List<string> nghia)
        {
            TuTA = tuTA;
            Nghia = nghia;
        }

        public string TuTA { get => tuTA; set => tuTA = value; }
        public List<string> Nghia { get => nghia; set => nghia = value; }
    }
}
