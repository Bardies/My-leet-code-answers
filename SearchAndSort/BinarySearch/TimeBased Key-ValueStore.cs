using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.SearchAndSort.BinarySearch
{
    public class TimeMap
    {
        public Dictionary<string, Dictionary<int, string>> timeMap;
        public TimeMap()
        {
            timeMap = new Dictionary<string, Dictionary<int, string>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!timeMap.ContainsKey(key)) timeMap.Add(key, new Dictionary<int, string>());
            timeMap[key].Add(timestamp, value);    
        }

        public string Get(string key, int timestamp)
        {
            
            if (timeMap.ContainsKey(key))
            {
                if(timeMap[key].ContainsKey(timestamp)) return timeMap[key][timestamp];
                List<int> timeStamps = timeMap[key].Keys.ToList();
                return Search(key, timeStamps, timestamp);
            }
            return string.Empty;
        }
        private string Search(string key, List<int> timeStamps, int timestamp)
        {
            //Binary search => sorted array, target
            int left = 0, right = timeStamps.Count - 1;
            int mid;
            string res = string.Empty;
            while (left <= right) // equal because if we have 1 element.
            {
                mid = left + ((right - left) / 2);
                if (timeStamps[mid] > timestamp)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                    res = timeMap[key][timeStamps[mid]];
                }
            }
            return res;
        }
    }
}
