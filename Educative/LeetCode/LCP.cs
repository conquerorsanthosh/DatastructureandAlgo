using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public  class LCP
	{
		public string GetLCP(string[] input) 
		{
			if(input == null || input.Length == 0) 
			{
				return "";
			}
				
			string lcp = "";
			for(int i = 0; i < input.Length-1; i++) 
			{
				int k = 0;
				int index = 0;
				if (i == 0)
				{
					while (k < input[i].Length && k < input[i+1].Length)
					{
						if (input[i][k] == input[i + 1][k])
						{
							lcp += input[i][k];
						}
						k++;
					}

					if (string.IsNullOrWhiteSpace(lcp))
					{
						return "";
					}
				}

				else 
				{
					index = 0;
					if (String.IsNullOrWhiteSpace(lcp)) return "";
					while (index < lcp.Length &&lcp[index] == input[i+1][index])  
					{
						index++;			
					}

					if(index != 0) 
					{
						lcp=lcp.Substring(0, index);
					}
					
				}
			}
			return lcp;
		}
			
	}
}


