using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    internal static class Anagram
    {
        //Time Complexity is O(26+n): n is length os the string
        public static bool IsAnagram(string s, string t)
        {
            //Check length of both strings
            if (s.Length != t.Length) return false;
            //Create hash table for each string with length 26 (Alphabatics) key/idx will reperesent char and value will be its count.
            List<int> sHashTable = new List<int>(); sHashTable.AddRange(Enumerable.Repeat(0, 26));
            List<int> tHashTable = new List<int>(); tHashTable.AddRange(Enumerable.Repeat(0, 26));
            for (int i = 0; i < s.Length; i++)  //O(n)
            {
                sHashTable[s[i] - 'a']++;
                tHashTable[t[i] - 'a']++;
            }
            //Check that both hashtables have the same value for each key/char.
            for (int i = 0; i < 26; i++)  //O(26)
            {
                if (sHashTable[i] != tHashTable[i]) return false;
            }
            return true;
        }

    }
}
