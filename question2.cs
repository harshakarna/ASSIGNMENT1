using System;
using System.Collections.Generic;
using System.Text;

namespace DIS_Summer_2021
{
    class question2
    {
        
		public static void Main(string[] args)
		{
			Console.WriteLine(" Q2 : Enter the string to check for pangram:");
			string s = Console.ReadLine();
			s = s.ToLower();//Converting all the letters to lowercase
			bool flag = CheckIfPangram(s);
			if (flag)
			{
				Console.WriteLine("Yes, the given string is a pangram");
			}
			else
			{
				Console.WriteLine("No, the given string is not a pangram");
			}
		}
		public static bool CheckIfPangram(String s)
		{
			try
			{
				int count = 0;
				String all_eng_alp = "abcdefghijklmnopqrstuvwxyz";
				String s_modified = new String(s.Distinct().ToArray());
				for (int i = 0; i < all_eng_alp.Length; i++)
				{
					for (int j = 0; j < s_modified.Length; j++)
					{
						if (all_eng_alp[i] == s_modified[j]) 
						{
							count++;
						}
					}
				}
				Console.WriteLine(count);
				if (count == 26) 				{
					return true;
				}
				return false;
			}

			catch (Exception e)
			{
				throw;
			}
		}
	}
}
    

