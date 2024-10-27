using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class MergeArray
	{

		public static  void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			try
			{
				int p1 = m - 1;
				int p2 = n - 1;
				int p = m + n - 1;

				while (p >= 0)
				{
					if (p2 < 0) break;

					if (p1 >= 0 && nums1[p1] >= nums2[p2])
					{
						nums1[p] = nums1[p1];
						p--;
						p1--;

					}

					else
					{
						nums1[p] = nums2[p2];
						p2--;
						p--;
					}

				}

			}

			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}
	}
}
