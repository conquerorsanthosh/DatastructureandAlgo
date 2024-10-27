using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
	public class BinarySearch
	{
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid = -1;

            while (left <= right)
            {
                mid = (right + left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

            }

            if (target > nums[mid])
            {
                return mid + 1;
            }
            else
            {
                return mid;
            }


        }
    }
}

