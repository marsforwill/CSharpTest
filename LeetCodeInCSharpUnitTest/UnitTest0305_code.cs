using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest0305_code
    {
        [TestMethod]
        public void TestSolution()
        {
            var solution = new Solution();
            solution.MinimalKSum(new int[] { 5, 6 }, 6);
            // solution.MinimalKSum(new int[]{96, 44, 99, 25, 61, 84, 88, 18, 19, 33, 60, 86, 52, 19, 32, 47, 35, 50, 94, 17, 29, 98, 22, 21, 72, 100, 40, 84}, 35);
            // var ans = solution.SortJumbled(new int[] {8, 9, 4, 0, 2, 1, 3, 5, 7, 6}, new int[] { 991, 338, 38 });

        }
    }
}
