using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.HashTable
{
     internal class Hand_of_Straights
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            //Check length
            if (hand.Length % groupSize != 0) return false;  //[1,2,3,6,2,3,4,7,8]
            //Create dictionary (key: number, value: count)
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int minNumber = 0;
            for (int i = 0; i < hand.Length; i++) // O(n)
            {
                if (!numbers.ContainsKey(hand[i])) numbers.Add(hand[i], 1); 
                else numbers[hand[i]]++;
            }
            int groups = hand.Length/groupSize;
            for (int i = 0; i < groups; i++)
            {
                //Count != 0
                minNumber = numbers.Keys.Where(key => numbers[key] != 0).Min();
                List<int> group = new List<int>();
                group.Add(minNumber);
                //Create the group from minimun value
                for (int j = 1; j < groupSize; j++)   //O(m: group size)
                {
                    group.Add(minNumber + j);
                }
                //Check if our dictionary contains the groups with value > 0
                for (int l = 0; l < group.Count; l++) //O(m-1: group size)
                {
                    if (numbers.ContainsKey(group[l]) && numbers[group[l]] != 0)
                    {
                        numbers[group[l]]--;
                    }
                    else
                    {
                        return false;
                    }
                }
               
            }
            return true;
        }
    }
}
