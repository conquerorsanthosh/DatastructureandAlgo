using System;

namespace SlidingWindow
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = { 2, 4, 8, 12, 5, 6, 21, 26, 20, 44, 5, 7 };
			FindMaxInEachWindow.FindMax(input,3);
		}
	}
}
