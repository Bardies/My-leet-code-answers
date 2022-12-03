using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    internal class Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.Length != nums.Distinct().Count();
        }
    }
}
