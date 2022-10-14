using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            float average = (float)total / nums.Length;
            return average;
        }
    }
}
