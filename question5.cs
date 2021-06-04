using System;
using System.Collections.Generic;
using System.Text;

namespace DIS_Summer_2021
{
    public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(" Q5 : ");
			Console.WriteLine("Enter the First Word:");
			String word1 = Console.ReadLine();
			Console.WriteLine("Enter the Second Word:");
			String word2 = Console.ReadLine();
			String merged = MergeAlternately(word1, word2);
			Console.WriteLine("The Merged Sentence formed by both words is {0}", merged);
		}
		public static String MergeAlternately(string word1, string word2)
		{
			try
			{
				string alt = "";
				int a = 0;
				int b = 0;
				while (a < word1.Length || b < word2.Length)
				{
					if (a < word1.Length)
					{
						alt = alt + word1[a];
						a = a + 1;
					}
					if (b < word2.Length)
					{
						alt = alt + word2[b];
						b = b + 1;
					}
				}

				return alt;

			}

			catch (Exception e)
			{
				throw;
			}
		}
	}
}
