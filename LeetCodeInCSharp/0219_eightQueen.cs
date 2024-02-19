using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
	public class EightQueen
	{
		public static int N = 8;
		public static []int position = new int[N];
		static void Main(string[] args)
		{
			solve(0);
		}

		public static void solve(int k){
			if (k == N){
				Console.WriteLine(string.Join(", ", position));
				return;
			}

			for (int i = 0; i < N; i++){
				if (!conflict(k, i)){
					position[k] = i;
					solve(k+1)
				}
			}
		}

		// Check if placing a queen at column 'p' in row 'k' is safe
		// i: other
		// k: p
		public static bool conflict(int k, int p){
			for(int i = 0; i < k; i++){
				int other = position[i];
				if (other == p || (k-i == p-other) || (k-i == other-p) ){
					return true;
				}
			}
			return false;
		}
	}
}
