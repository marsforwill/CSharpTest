using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
	class Program
	{
		// https://codingcompetitions.withgoogle.com/kickstart/round/00000000008cb33e/00000000009e7021 test for c# ocmmit
		/*
		 input
		    2
		    Ilovecoding
			IIllovecoding
			KickstartIsFun
			kkickstartiisfun
		output:
			Case #1: 2
			Case #2: IMPOSSIBLE
		 */
		static void Main(string[] args)
		{
			int T = Convert.ToInt32(Console.ReadLine());
			for (int j = 0; j < T; j++)
			{
				string result = $"Case #{j + 1}: ";

				string s = Console.ReadLine();
				string t = Console.ReadLine();
				int r = 0;
				int res = t.Length - s.Length;
				for (int i = 0; i < s.Length; i++)
                {
					while (r < t.Length && t[r] != s[i]) r++;
					if (r == t.Length)
					{
						res = -1;
						break;
					}
					r++;
				}
					
				Console.WriteLine(result + (res == -1 ? "IMPOSSIBLE" : res.ToString()));
			}
		}
	}
}
