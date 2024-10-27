using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class RemoveDuplicates
	{
		public static int RemoveDuplicatesFromArray(int[] nums) 
		{

			/*
		  1. a=[1,2,2,2,3,3,3,4,5,6]   out=[1,2,3,4,5,6,2,2,3,3]
		  2. a=[1,2,3,4,5,6]               
		  3. a=[]                  
		  4. a=[1,2,3,4,5,6,7,7]
	   */
			try
			{
				if (nums.Length == 1)
				{
					return 1;
				}

				int p1 = 0;
				int p2 = 1;
				int k = nums[p1];
				while (p2 <= nums.Length - 1)
				{
					if (k == nums[p2])
					{
						while (p2 <= nums.Length - 1 && k == nums[p2])
						{
							p2++;
						}
						if (p2 <= nums.Length - 1 && nums[p2] != k)
						{
							k = nums[p2];
							nums[p1 +1] = nums[p2];
							p1++;
						}

					}
					else
					{
							p1++;
							p2++;
							k = nums[p1];
					}
			}

				return p1 + 1;
			}

			catch(Exception e) 
			{
				Console.WriteLine(e.ToString());
				throw;
			}

		}
	}
}
