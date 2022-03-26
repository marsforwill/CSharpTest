using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
	public class Program_chanllenge_nine
	{
		// https://codingcompetitions.withgoogle.com/kickstart/round/00000000008cb33e/00000000009e7997 chanllenge nine
		/*
		 能被9整除的数 各个数位加起来也能被9整除
		 */
		static void Main(string[] args)
		{
			int T = Convert.ToInt32(Console.ReadLine());
			for (int j = 0; j < T; j++)
			{
				string result = $"Case #{j + 1}: ";

				string str = Console.ReadLine();
				int rem = 0;
				foreach(char c in str)
                {
					rem = (rem + (c - '0')) % 9;
                }
				int d = (9 - rem) % 9;
				int pos = d == 0 ? 1 : 0;
				while ( pos < str.Length && str[pos] - '0' <= d)
                {
					pos++;
                }
				str = str.Insert(pos, d.ToString());
					
				Console.WriteLine(result + str);
			}
		}
	}
}
