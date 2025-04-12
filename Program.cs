using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
	internal class Program
	{
		public static int recursiveSum(int n, int m)
		{
            if (m == n)
			{
				return n;
			} 
            return m + recursiveSum(n, m - 1);
		}
		public static int recursiveDiv(int num)
		{
			if (num % 2 == 0)
			{
				return 1 + recursiveDiv(num / 2);
			}
			return 0;
		}
		public static void Main(string[] args)
		{
			Console.WriteLine("Addition\nEnter number n:");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter number m:");
			int m = Convert.ToInt32(Console.ReadLine());
			
			int sum = recursiveSum(n, m);
			Console.WriteLine(sum);

			Console.WriteLine("Division\nEnter your number:");
			int num = Convert.ToInt32(Console.ReadLine());

			int numOfDiv = recursiveDiv(num);
			Console.WriteLine($"Total number of divisions: {numOfDiv}");

		}

	}
}
