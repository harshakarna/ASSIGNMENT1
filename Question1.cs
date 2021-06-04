using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Q1 :Enter the Moves of Robot:");
		string moves = Console.ReadLine();
		//Console.WriteLine(moves.Length);
		bool pos = JudgeCircle(moves);
		if (pos)
		{
			Console.WriteLine("The Robot return’s to initial Position (0,0)");
		}
		else
		{
			Console.WriteLine("The Robot doesn’t return to the Initial Postion (0,0)");
		}
		//Console.WriteLine();
	}

	public static bool JudgeCircle(String moves)
	{
		try
		{


			int hor_mov = 0;
			int ver_mov = 0;

			foreach (char i in moves)
			{
				if (i == 'U')
				{
					ver_mov = ver_mov + 1;
				}
				if (i == 'D')
				{
					ver_mov = ver_mov - 1;
				}
				if (i == 'R')
				{
					hor_mov = hor_mov + 1;
				}
				if (i == 'L')
				{
					hor_mov = hor_mov - 1;
				}
			}

			if (hor_mov == 0 && ver_mov == 0)
			{
				return true;
			}
			else
			{
				return false;
			}


		}

		catch (Exception)
		{
			throw;
		}
	}

}