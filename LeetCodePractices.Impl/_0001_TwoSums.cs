namespace LeetCodePractices.Impl;

public class _0001_TwoSums
{
    //Link to the problem: https://leetcode.com/problems/two-sum/

    public int[] TwoSum(int[] nums, int target)
    {
        CheckConstraints(nums, target);
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }

        }

        throw new ArgumentException("Given array does not contain elements that will sum up to the target: " + target);
    }

    private void CheckConstraints(int[] nums, int target)
    {

        var maxArrayLength = (int)Math.Pow(10, 4);
        var upperBound = (int)Math.Pow(10, 9);
        var lowerBound = (int)Math.Pow(10, 9) * -1;

        if(nums.Length > upperBound || nums.Length < lowerBound || nums.Length <2 || nums.Length > maxArrayLength)
        {
            throw new ArgumentOutOfRangeException(nameof(nums));
        }

        if(target > upperBound || target < lowerBound)
        {
            throw new ArgumentOutOfRangeException(nameof(target));          
        }
    }
}

