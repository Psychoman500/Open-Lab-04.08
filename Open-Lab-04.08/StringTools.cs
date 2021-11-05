using System;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int u = 4;
            List<string> array = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == u)
                {
                    array.Add(strings[i]);
                }

            }
            return array.ToArray();
        }
    }
}
