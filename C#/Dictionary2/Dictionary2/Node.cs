using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    public class Node
    {
        private Word data;
        private Node link;

        public Node(Word x)
        {
            Data = x;
            Link = null;
        }

        public Word Data { get => data; set => data = value; }
        public Node Link { get => link; set => link = value; }
    }
}
