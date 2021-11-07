using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    public class HashTable
    {
        #region properties
        private LinkedList[] linked_List = new LinkedList[28];

        public HashTable()
        {
            for (int i = 0; i < 28; i++)
            {
                Linked_List[i] = new LinkedList();
            }
        }

        public LinkedList[] Linked_List { get => linked_List; set => linked_List = value; }
        #endregion

        #region methods
        public Word find(String s)
        {
            int temp = cons.hash(s[0]);

            for (Node i = Linked_List[temp].First; i != null; i = i.Link)
            {
                String k = cons.xuLyTen(i.Data.TuTA);
                if (s.Equals(k))
                {
                    return i.Data;
                }
            }

            return null;
        }
        public void insert(Word x)
        {
            char temp = x.TuTA[0];
            int k = cons.hash(temp);
            Linked_List[k].insertLast(x);
        }

        public void docFileTxt()
        {
            try
            {
                using (StreamReader read = new StreamReader("data.txt"))
                {
                    string s = read.ReadLine();
                    while (s != null)
                    {
                        Word x = new Word();
                        if (s[0] == '@')
                        {
                            String[] s1 = s.Split('@');
                            x.TuTA = s1[1];
                        }

                        String c;
                        while ((c = read.ReadLine()) != null)
                        {
                            if (c[0] == '@')
                            {
                                break;
                            }
                            x.Nghia.Add(c);
                        }

                        int k = cons.hash(s[1]);
                        s = c;

                        Linked_List[k].insertLast(x);
                    }
                    read.Close();
                }
            }
            catch { }
        }

        public void ghiFileTxt()
        {
            try
            {
                using (StreamWriter write = new StreamWriter("data.txt"))
                {
                    for (int k = 0; k < 28; k++)
                    {
                        for (Node i = Linked_List[k].First; i != null; i = i.Link)
                        {
                            write.WriteLine($"@{i.Data.TuTA}");
                            for (int j = 0; j < i.Data.Nghia.Count; j++)
                            {
                                write.WriteLine(i.Data.Nghia[j]);
                            }

                        }
                    }

                    write.Close();
                }
            }
            catch { }
        }

        public void docFileBinary()
        {
            try
            {
                using (BinaryReader br = new BinaryReader(new FileStream("data.dat", FileMode.Open)))
                {
                    string s = br.ReadString();

                    while (s != null)
                    {
                        Word x = new Word();
                        if (s[0] == '@')
                        {
                            String[] s1 = s.Split('@');
                            x.TuTA = s1[1];
                        }

                        String c;
                        while ((c = br.ReadString()) != null)
                        {
                            if (c[0] == '@')
                            {
                                break;
                            }
                            x.Nghia.Add(c);
                        }

                        int k = cons.hash(s[1]);
                        s = c;

                        Linked_List[k].insertLast(x);
                    }
                    br.Close();
                }
            }
            catch (Exception) { }
        }

        public void ghiFileBinary()
        {
            try
            {
                using (BinaryWriter bw = new BinaryWriter(new FileStream("data.dat", FileMode.Create)))
                {
                    for (int k = 0; k < 28; k++)
                    {
                        for (Node i = Linked_List[k].First; i != null; i = i.Link)
                        {
                            bw.Write($"@{i.Data.TuTA}");
                            for (int j = 0; j < i.Data.Nghia.Count; j++)
                            {
                                bw.Write($"{i.Data.Nghia[j]}");
                            }
                        }
                    }

                    bw.Close();
                }
            }
            catch { }
        }

        #endregion
    }
}
