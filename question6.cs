using System;
using System.Collections.Generic;
using System.Text;

namespace DIS_Summer_2021
{
    public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Q6: Enter the sentence to convert:");
			string sentence = Console.ReadLine();
			string goatLatin = ToGoatLatin(sentence);
			Console.WriteLine("Goat Latin for the Given Sentence is {0}", goatLatin);
			Console.WriteLine();
		}
		public static string ToGoatLatin(string sentence)
		{
			try
			{
				
					StringBuilder goatlatin = new StringBuilder();
					string[] sen_array = sentence.Split(" ");
					int index = 1;

					foreach (string str in sen_array)
					{
						if ("aeiou".Contains(char.ToLower(str[0])))
							goatlatin.Append(str + "ma" + string.Concat(Enumerable.Repeat("a", index)).ToString() + " ");
						else if (!str.Contains("aeiouAEIOU"))
							goatlatin.Append(str.Substring(1, str.Length - 1) + str.Substring(0, 1) + "ma" + string.Concat(Enumerable.Repeat("a", index)) + " ");
						index++;
					}

					goatlatin.Length--;
					return goatlatin.ToString();

			}

			catch (Exception e)
			{
				throw;
			}
		}
	}
}
