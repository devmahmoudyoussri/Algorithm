using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 1, 2, 1, 2 };
            Console.WriteLine(SingleNumber(nums));
        }

        static int SingleNumber2(int[] nums)
        {
            List<int> nodplicated = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!nodplicated.Contains(nums[i]))
                {
                    nodplicated.Add(nums[i]);
                }
                else
                {
                    nodplicated.Remove(nums[i]);
                }
            }
            return nodplicated.First();
        }
        static int SingleNumber(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                int j;
                for (j = 0; j < nums.Length; j++)
                    if (i != j && nums[i] == nums[j])
                        break;
                if (j == nums.Length)
                    return nums[i];
            }
            return -1;

        }
    }
}
