﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public  class Leet_26_RemoveDuplicates
	{
		public int RemoveDuplicates(int[] nums)
		{
			if (nums.Length == 0)
				return 0;

			int i = 0;
			for (int j = 1; j < nums.Length; j++)
			{
				if (nums[j] != nums[i])
				{
					nums[i + 1] = nums[j];
					i++;

				}

			}
			return i+1;
		}
	}
}
