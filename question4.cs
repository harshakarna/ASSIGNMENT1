using System;
using System.Collections.Generic;
using System.Text;

namespace DIS_Summer_2021
{
   public static void Main(string[] args)
		{
			Console.WriteLine(" Q4 : ");
			int[] arr = { 1, 7, 3, 6, 5, 6 };
			int pivot = PivotIndex(arr);
			if (pivot > 0)
			{
				Console.WriteLine("The Pivot index for the given array is {0}", pivot);
			}
			else
			{
				Console.WriteLine("The given array has no Pivot index");
			}
		}
		public static int PivotIndex(int[] arr)
		{
			try
			{
				using System;
				using System.Collections.Generic;
				using System.Linq;

namespace Assignment1_Summer2021
	{
		public class Program
		{
			public static void Main(string[] args)
			{
				Console.WriteLine(" Q4 : ");

				int[] arr = { 1, 7, 3, 6, 5, 6 };
				int pivot = PivotIndex(arr);
				if (pivot > 0)
				{
					Console.WriteLine("The Pivot index for the given array is {0}", pivot);
				}
				else
				{
					Console.WriteLine("The given array has no Pivot index");
				}
			}
			public static int PivotIndex(int[] nums)
			{
				try
				{
					int add = 0;
					foreach (int i in nums)
					{
						add = add + i;
					}

					int leftadd = 0;


					for (int j = 0; j < nums.Length; j++)
					{
						if (leftadd == (add - leftadd - nums[j]))
						{
							return j;
						}
						leftadd = leftadd + nums[j];

					}

					return -1;

				}

				catch (Exception e)
				{
					throw;
				}
			}
		}
	}

}
