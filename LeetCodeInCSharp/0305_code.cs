using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class Solution
    {
        public int MostFrequent(int[] nums, int key)
        {
            var m = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == key && i + 1 < nums.Length)
                {
                    var target = nums[i + 1];
                    if (m.ContainsKey(target))
                    {
                        m[target]++;
                    }else
                    {
                        m[target] = 1;
                    }
                }
            }
            var count = 0;
            var ans = 0;
            foreach(var target in m.Keys)
            {
                if (m[target] > count)
                {
                    count = m[target];
                    ans = target;
                }
            }
            return ans;
        }

        public int[] SortJumbled(int[] mapping, int[] nums)
        {
            var length = nums.Length;
            var ans = new int[length];
            var list = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < length; i++)
            {
                list.Add(new KeyValuePair<int, int>(cvrt(mapping, nums[i]), nums[i]));
            }
            list.Sort((left, right) => {
                if (left.Key > right.Key)
                {
                    return 1;
                }
                if (left.Key < right.Key)
                {
                    return -1;
                }
                return -0;

            });
            for (int i = 0; i < length; i++)
            {
                ans[i] = list[i].Value;
            }
            return ans;
        }

        private int cvrt(int[] mapping, int v)
        {
            if (v == 0)
            {
                return mapping[0];
            }
            var ans = 0;
            var digit = 1;
            while (v != 0)
            {
                var d = v % 10;
                ans = ans + mapping[d] * digit;
                v = v / 10;
                digit = digit * 10;
            }
            return ans;
        }

        public IList<string> CellsInRange(string s)
        {
            var startx = s[0];
            var endx = s[3];
            var startd = int.Parse(s.Substring(1,1));
            var endd = int.Parse(s.Substring(4, 1)); ;
            var ans = new List<string>();
            for (var i = startx; i <= endx; i++)
            {
                for (var j = startd; j <= endd; j++)
                {
                    ans.Add(i.ToString() + j.ToString());
                }
            }
            return ans;
        }

        public long MinimalKSum(int[] nums, int k)
        {
            var l = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                l.Add(nums[i]);
            }
            l.Sort();
            Int64 ans = 0;
            var index = 0;
            // should not use O(n)
            for (int i = 1; k > 0; i++)
            {
                if (index < l.Count && i == l[index])
                {
                    index++;
                    while(l[index] == l[index-1])
                    {
                        index++;
                    }
                    continue;
                }
                if (index >= l.Count || i < l[index])
                {
                    ans += i;
                    k--;
                }
            }
            return ans;
        }
    }
}
