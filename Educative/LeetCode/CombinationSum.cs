using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class CombinationSum
	{
		IList<IList<int>> results = new List<IList<int>>();

		public IList<IList<int>> CombinationSum3(int k, int n)
		{
			List<int> path = new List<int>();
			
			Backtrack(1, k, 0, n, path);
			return results;
		}

		public void Backtrack(int start, int k, int sum, int n, List<int> path)
		{
			if (path.Count == k)
			{
				if (sum == n)
				{
					results.Add(new List<int>(path));
				}
				return;
			}

			for (int i = start; i <= 9; i++)
			{
				path.Add(i);
				Backtrack(i + 1, k, sum + i, n, path);
				path.RemoveAt(path.Count - 1);
			}
		}
	}

}



/*
 * 
 * The below method will create duplicates
 * [2,6,1]  and [1,6,2]
  public class CombinationSum
{
	IList<IList<int>> results = new List<IList<int>>();
	public IList<IList<int>> CombinationSum3(int k, int n)
	{
		List<int> path = new List<int>();
		List<int> nums = new List<int>();
		for (int p = 1; p < 10; p++)
		{
			nums.Add(p);
		}
		nums.Sort();
		Backtrack(1, k, 0, n, path, nums);
		return results;

	}

	public void Backtrack(int currentLevel, int totalLevel, int sum, int n, List<int> path, List<int> nums)
	{
		if (currentLevel > totalLevel)
		{
			if (sum == n)
			{
				if (results.Contains(path))
				{
					results.Add(new List<int>(path));
				}
			}
			return;

		}

		for (int x = 0; x < nums.Count; x++)
		{
			sum = sum + nums[x];
			int value = nums[x];
			path.Add(value);
			nums.Remove(value);
			Backtrack(currentLevel+1, totalLevel, sum, n, path, nums);
			nums.Add(value);
			path.Remove(value);
			sum-=value;
		}

	}
}
 
 
 */