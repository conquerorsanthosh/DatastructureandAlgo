using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public  static class Ransom_Note
	{
		public static  bool CanConstruct(string ransomNote, string magazine)
		{
			if (ransomNote == null || magazine == null)
			{
				return false;

			}

			Dictionary<char, int> source = new Dictionary<char, int>();
			foreach (char c in ransomNote)
			{
				if (source.ContainsKey(c)) 
				{
					source[c]++;	
				}
				else 
				{
					source[c] = 1;
				}
		
			}

			int length=magazine.Length;
			while(CheckAllKey(source)!=true || length > 0) 
			{
			
			
			}

			return false;

		}

		public static bool CheckAllKey(Dictionary<char,int> source) 
		{
			return true;
		}
	}
}
