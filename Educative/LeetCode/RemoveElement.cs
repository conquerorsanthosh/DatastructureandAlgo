using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class RemoveElement
	{

		public static int RemoveElementFunction(int[] nums, int val)
		{
			if (nums.Length <= 0) return 0;

			if (nums.Length == 1)
			{
				if (val == nums[0])
				{
					return 1;
				}
				return 0;
			}

			int end = nums.Length - 1;
			int p1 = 0;
			int p2 = 1;
			int count = 0;

			while (p1 <= end  && p2<=end)
			{
				if (nums[p1] != val)
				{
					count++;
					p1++;
				}
				else
				{
					p2= p1+1; 
					while (p2 <= end)
					{
						if (nums[p2] == val)
						{
							p2++;
						}
						else
						{
							//swap 
							int temp = nums[p1];
							nums[p1] = nums[p2];
							nums[p2] = temp;
							p1++;
							count++;
							break;
						}

					}

				}


			}
			return count;

		}

		public static int RemoveElementFunction_1(int[] nums, int val) 
		{
			int p1= 0;
			int end= nums.Length - 1;
			for(int p2 = 0; p2 <= end; p2++) 
			{
				if (nums[p2] != val)
				{ 
					int temp = nums[p1];
					nums[p1] = nums[p2];
					nums[p2] = temp;
					p1++;
				}
	
			}
			return p1;
		}

		public static int  RemoveDuplicatesAtmostTwice(int[] nums) 
		{
			int p1 = 1;
			for (int p2 = 1; p2 < nums.Length;p2++)
			{
				if (p1 == 1 || nums[p2] != nums[p1 - 2])
				{
					nums[p1++] = nums[p2];
				}
			}
			return p1;
		}

		public static int MajorityElement(int[] nums) 
		{
			
			int res = 0;
			int majority = 0;
			
			string s="A man, a plan, a canal: Panama"; 

			foreach (int n in nums) 
			{
				if (majority == 0)
				{
					res = n;
				}

				if(n == res) 
				{
					majority++;
				}
				else 
				{
					majority--;
				}
				
			}

			return res;
	    }

	}
} 


