using LeetCodePractices.Impl;

namespace LeetCodePractices.Test;

public class _0001_TwoSums_Test
{

    [TestCase(new int[] { 2, 7, 11, 15 }, 9)]
    [TestCase(new int[] { 3, 2, 4 }, 6)]
    [TestCase(new int[] { 3 }, 6, typeof(ArgumentOutOfRangeException))]
    [TestCase(new int[] { -1, -2, -3, -4, -5 }, -8)]
    public void TwoSum(int[] nums, int target, Type expectedException = null)
    {
        _0001_TwoSums twoSumsCalculator = new _0001_TwoSums();
        if (expectedException is null)
        {
            var twoSums = twoSumsCalculator.TwoSum(nums, target);
            Assert.That(nums[twoSums[0]] + nums[twoSums[1]], Is.EqualTo(target));
        }
        else
        {
            Assert.Throws(Is.TypeOf(expectedException), () => twoSumsCalculator.TwoSum(nums, target));
        }

    }
}
