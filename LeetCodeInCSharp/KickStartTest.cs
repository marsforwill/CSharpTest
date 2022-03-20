using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			int cou = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < cou; i++)
			{
				string result = $"Case #{i + 1}: ";

				var line1 = Console.ReadLine().Split(' ');
				int budget = Convert.ToInt32(line1[1]);

				var housePrices = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).OrderBy(p => p).ToList();
				int buyCou = 0, total = 0;
				for (int j = 0; j < housePrices.Count(); j++)
				{
					total += housePrices[j];
					if (total <= budget)
						buyCou++;
					else
						break;
				}

				Console.WriteLine(result + buyCou);
			}
		}
	}
}