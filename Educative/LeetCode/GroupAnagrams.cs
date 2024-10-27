using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class GroupAnagrams
	{		
			public IList<IList<string>> GetGroupAnagrams(string[] strs)
			{
				Dictionary<string, List<string>> asciiMap = new Dictionary<string, List<string>>();
				IList<IList<string>> results = new List<IList<string>>();

				 int value = 0;

				for (int i = 0; i < strs.Length; i++)
				{
					string str = strs[i];
					for (int j = 0; j < str.Length; j++)
					{
						char c= str[j];
						value += c;
					}

					if (asciiMap.ContainsKey(value.ToString()))
					{
						asciiMap[value.ToString()].Add(strs[i]);
					}
					else
					{
						asciiMap[value.ToString()] = new List<string>();
						asciiMap[value.ToString()].Add(strs[i]);
					}

				}


				foreach (KeyValuePair<string,List<string>> kvp in asciiMap)
				{

					results.Add(kvp.Value);

				}

				return results;

			}
		}
}
