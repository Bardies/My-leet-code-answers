using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leet_Code.HashTable;

namespace Leet_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _4Sum_II.FourSumCount(
                new int[] {-1,-1}, new int[] { -1, 1 }, new int[] { -1, 1 }, new int[] { 1, -1 }
                );
            Verifying_an_Alien_Dictionary.IsAlienSorted(new string[] { "apap", "app" },"abcdefghijklmnopqrstuvwxyz");
        }
    }
}
