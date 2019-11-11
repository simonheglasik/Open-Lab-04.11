using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            List<char> list = str.ToList();
            list.Sort();
            return string.Concat(list);
        }
    }
}
