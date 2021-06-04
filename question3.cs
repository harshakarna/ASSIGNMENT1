using System;
using System.Collections.Generic;
using System.Linq;

namespace DIS_Summer_2021
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Q3 : ");
            int[] arr = { 1, 1, 1, 1 };
            int gp = NumIdenticalPairs(arr);
            Console.WriteLine("The number of IdenticalPairs in the array are {0}:", gp);
        }
        public static int NumIdenticalPairs(int[] nums)
        {
            try
            {
                int pairs = 0;
                Console.WriteLine(nums.Length);
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (i < j)
                        {
                            if (nums[i] == nums[j])
                            {

                                pairs++;
                            }
                        }
                    }
                }
                return pairs;
            }

            catch (Exception e)
            {
                throw;
            }
        }
    }
}
