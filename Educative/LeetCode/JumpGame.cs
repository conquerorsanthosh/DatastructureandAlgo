using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class JumpGame
	{
		public static bool CanJump(int[] nums)
		{
			if (nums.Length < 0) return false;

			if (nums.Length == 1) return true;

			bool[] rechable = new bool[nums.Length];

			if (nums[0] > 0)
			{
				return CheckIfReachFinal(0, nums, rechable);
			}

			return false;


		}

		public static bool CheckIfReachFinal(int currentIndex, int[] nums, bool[] rechable)
		{
			if (rechable[currentIndex])
			{
				return true;

			}

			if (currentIndex == nums.Length - 1)
			{
				return true;
			}

			if (currentIndex > nums.Length - 1)
			{
				return false;

			}

			for (int j = 1; j <= nums[currentIndex]; j++)
			{
				int nextIndex = currentIndex + j;

				if (CheckIfReachFinal(nextIndex, nums, rechable))
				{
					rechable[currentIndex] = true;
					return true;

				}

			}

			return false;

		}


	}
}
