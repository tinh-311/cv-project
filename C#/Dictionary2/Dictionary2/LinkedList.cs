using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    public class LinkedList
    {
        #region properties
        private Node first;
        private Node last;

        public LinkedList()
        {
            First = Last = null;
        }

        public Node First { get => first; set => first = value; }
        public Node Last { get => last; set => last = value; }

        #endregion

        #region methods
        public void insertLast(Word x)
        {
            Node p = new Node(x);

            if (this.First == null)
            {
                this.First = this.last = p;
            }
            else
            {
                this.Last.Link = p;
                this.Last = p;
            }
        }

        public Boolean xoa(String s)
        {
            Node temp = first, prev = null;

            if (temp != null && temp.Data.TuTA.ToUpper() == s.ToUpper())
            {
                first = temp.Link;
                return true;
            }

            while (temp != null && temp.Data.TuTA.ToUpper() != s.ToUpper())
            {
                prev = temp;
                temp = temp.Link;
            }

            if (temp != null)
            {
                if (temp == last)
                {
                    prev.Link = null;
                    last = prev;
                    return true;
                }
                else
                {
                    prev.Link = temp.Link;
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
