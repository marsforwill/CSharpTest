using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class AppendKMinSum
    {
        //Input: nums = [1,4,25,10,25], k = 2
        // Output: 5
        public long MinimalKSum(int[] nums, int k)
        {
            var list = nums.ToList();
            list.Add(0); 
            list.Add(int.MaxValue);
            list.Sort();

            long sum = 0;
            for (int i = 0; i < list.Count()-1; i++)
            {
                var next = list[i+1];
                if (next == list[i] || next == list[i]+1)
                {
                    continue;
                }
                var delta = next - list[i] - 1;
                delta = Math.Min(delta, k);
                // add to sum
                sum += (long)(list[i] + list[i] + delta + 1) * (long)delta / (long)2;
                // 
                k -= delta;
                if (k <= 0)
                {
                    break;
                }
                
            }
            return sum;
        }
    }
}
