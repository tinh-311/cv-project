using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    public class cons
    {
        public static int hash(char k)
        {
            if (k >= 65 && k <= 90)
            {
                return k % 65;
            }
            else if (k >= 97 && k <= 122)
            {
                return (k % 65) - 32;
            }
            else if (k >= 48 && k <= 57)
            {
                return 26;
            }
            else
                return 27;
        }

        public static String xuLyTen(String s)
        {
            String temp = "/=(";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == temp[0] && s[i - 1] == ' ' || s[i] == temp[1] || s[i] == temp[2])
                {
                    return s.Substring(0, i - 1);
                }
            }
            return s;
        }

        // Tìm tất cả vị trí xuất hiện chuỗi con
        public static List<int> AllIndexesOf(string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}
