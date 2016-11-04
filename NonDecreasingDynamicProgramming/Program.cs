using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonDecreasingDynamicProgramming
{
	class Program
	{
		static void Main(string[] args)
		{
			// 3, 5, 6, 1, 2
			int[] numbers = new int[5] { 3, 5, 6, 1, 2 };//TODO: remove
			Random rnd = new Random();
			String input = "";
			
			while (input != "exit" || input != "x") {
				/*for (int i = 0; i < numbers.Length; i++)
				{
					numbers[i] = rnd.Next(1, 10);
					Console.Write(numbers[i] + ", ");
				}*/
				Console.WriteLine("done");
				Console.WriteLine("largest non decreasing set is " + largestNonDecreasing(numbers, numbers.Length - 1, numbers.Max()) + " numbers long");
				input = Console.ReadLine();
			}
		}

		static private int largestNonDecreasing(int[] set, int k, int x)
		{
			if (k == 0)
			{
				return 1;
			}
			if (set[k] >= set[k-1])
			{
				return Math.Max(largestNonDecreasing(set, k - 1, set[k]) + 1, largestNonDecreasing(set, k - 1, x));
			}
			else
			{
				return largestNonDecreasing(set, k - 1, x);
			}
		}
	}
}
