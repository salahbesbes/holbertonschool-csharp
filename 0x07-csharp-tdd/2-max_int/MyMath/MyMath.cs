using System;
using System.Collections.Generic;


namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0 )
            {
                return 0;
            }

            int MinValue = int.MinValue;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > MinValue)
                {

                    MinValue = nums[i];
                }
            }

            return MinValue;
        }
    }
}
