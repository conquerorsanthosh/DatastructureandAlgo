using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class Solution
	{
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			Array.Sort(nums);
			List<List<int>> result = new List<List<int>>();
			int target = 0;

			for (int i = 0; i <= nums.Length - 1; i++)
			{
				if (i != 0 && nums[i] == nums[i - 1])
				{
					continue;
				}

				if (nums[i] > 0)
				{
					target = -nums[i];

				}
				else
				{
					target = nums[i];
				}
				int[] twoSumResult = FindTwoSum(nums, target, i);
				if (twoSumResult != null)
				{
					List<int> triplets = new List<int>();
					triplets.Add(nums[i]);
					triplets.Add(twoSumResult[i]);
					triplets.Add(twoSumResult[i + 1]);
					result.Add(triplets);

				}

			}

			return (IList<IList<int>>) result;

		}

		public int[] FindTwoSum(int[] nums, int target, int currentIndex)
		{
			int start = currentIndex + 1;
			int end = nums.Length - 1;

			while (start < end)
			{
				if (nums[start] + nums[end] > target)
				{
					end--;
				}
				else if (nums[start] + nums[end] < target)
				{
					start++;
				}
				else
				{
					return new int[] { nums[start], nums[end] };
				}

			}

			return null;
		}
	}
}
