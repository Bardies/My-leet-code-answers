using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.HashTable
{
    public static class Verifying_an_Alien_Dictionary
    {
        //Time complexity = O(n-1)*O(m): n is length of words array, m is length of max length f words
        public static bool IsAlienSorted(string[] words, string order)//a, b
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();//abc
            for (int i = 0; i < 26; i++)
            {
                dic.Add(order[i], i);
            }
            for (int i = 0; i < words.Length-1; i++) 
            {
                int iterations = Math.Min(words[i].Length, words[i + 1].Length);
                bool isEqual = false;
                for (int j = 0; j < iterations; j++)
                {
                    if (dic[words[i][j]] > dic[words[i + 1][j]]) return false;
                    else if (dic[words[i][j]] == dic[words[i + 1][j]])
                    {
                        isEqual = true;
                        continue;
                    }
                    else //right order
                    {
                        isEqual = false;
                        break; //don't continue comapring the least of chars in the 2 words   
                    }

                }
                if (isEqual && words[i].Length > words[i + 1].Length) return false;
            }
            return true;
        }
    }
}
