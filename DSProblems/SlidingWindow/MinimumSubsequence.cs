using System;
using System.Collections.Generic;

namespace SlidingWindow
{
	public class MinimumSubsequence
	{
		private readonly string  _source;
		private readonly string _pattern;

		public MinimumSubsequence(string source,string pattern)
		{
			_source = source ?? throw new ArgumentNullException(nameof(source));
			_pattern = pattern ?? throw new ArgumentNullException(nameof(source));
		}

		public string FindMinimumSubSquence() 
		{
			int startWindow = 0;
			int endWindow = 0;
			int currentCount = 0;
			int needCount = _pattern.Length;
			Dictionary<char, int> needFrequencyMap = new Dictionary<char, int>();
			Dictionary<char, int> currentFrequencyMap = new Dictionary<char, int>();
			InitFrequencyMap(needFrequencyMap, _source);
			InitFrequencyMap(currentFrequencyMap, _source,0);
			
			while (endWindow <= _source.Length - 1) 
			{
				if (needFrequencyMap.ContainsKey( _source[endWindow])&&currentCount!=needCount) 
				{
					currentFrequencyMap[_source[endWindow]]++;
					currentCount++;
					endWindow++;

				}
				else
				{
					endWindow++;
				}
			}
		}

		private void InitFrequencyMap(Dictionary<char,int> frequencyMap, string inputStr, int value = -1) 
		{
			if (value == -1)
			{
				foreach (char c in inputStr)
				{
					if (frequencyMap.ContainsKey(c))
					{
						frequencyMap[c]++;
					}
					else
					{
						frequencyMap.Add(c, 1);
					}

				}
			}
			else 
			{
				foreach (char c in inputStr)
				{
					if (!frequencyMap.ContainsKey(c))
					{
						frequencyMap.Add(c, 0);
					}
				}
			}
		
		}
	}
}
