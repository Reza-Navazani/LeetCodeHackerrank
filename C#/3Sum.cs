//Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> output = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; ++i)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            for (int j = i + 1; j < nums.Length; ++j)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                    continue;

                for (int k = j + 1; k < nums.Length; ++k)
                {
                    if (k > j + 1 && nums[k] == nums[k - 1])
                        continue;

                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        output.Add(new List<int> { nums[i], nums[j], nums[k] });
                    }
                }
            }
        }

        return output;
    }

    static void Main()
    {
        Solution solution = new Solution();
        int[] nums = { -1, 0, 1, 2, -1, -4 };
        IList<IList<int>> result = solution.ThreeSum(nums);

        foreach (var triplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }
    }
}

