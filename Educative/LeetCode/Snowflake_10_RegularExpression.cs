using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// not a correct solution please donot refer

namespace LeetCode
{
	public  class Snowflake_10_RegularExpression
	{
		private string source;
		private string pattern;
		public Snowflake_10_RegularExpression(string _source, string _pattern) 
		{
			this.source = _source;
			this.pattern = _pattern;
		
		}
		public bool IsMatch(string source,string pattern)
		{
			if (source.Length <= 0) return false;

			int count = 0;
			while (count < source.Length)
			{
				if (pattern[count] == '.') 
				{
					count++;
					continue;
				}
				else if (pattern[count] == '*')
				{
					count++;
					return true;
				}
				else if (source[count] == pattern[count]) 
				{
					count++;
					continue;
				}
				else 
				{
					return false;
				}

			}

			return true;

		}
	}
}
