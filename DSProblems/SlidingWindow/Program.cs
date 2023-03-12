using System;

namespace SlidingWindow
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input1 = { 2, 4, 8, 12, 5, 6, 21, 26, 20, 44, 5, 90 }; 
			int[] input2 = { 22, 23, 25, 32, 55, 66, 71, 96, 100, 144, 155, 900 };
			int[] input3 = { 200, 199, 198, 180, 175, 166, 150, 126, 120, 44, 32, 9 };
			//int[] input1 = { 2, 4, 8, 12, 5, 6, 21, 26, 20, 44, 5, 90 };
			//int[] input1 = { 2, 4, 8, 12, 5, 6, 21, 26, 20, 44, 5, 90 };

			//Console.WriteLine("Input1:2, 4, 8, 12, 5, 6, 21, 26, 20, 44, 5, 90 ");
			//Console.WriteLine("Expected output:8,8,12,12,12,21,26,26,44,44,90 ");
			//FindMaxInEachWindow.FindMax(input1,3);
			//Console.WriteLine("Input2:22, 23, 25, 32, 55, 66, 71, 96, 100, 144, 155, 900  ");
			//FindMaxInEachWindow.FindMax(input2, 3);
			Console.WriteLine("input3 = { 200, 199, 198, 180, 175, 166, 150, 126, 120, 44, 32, 9 };");
			FindMaxInEachWindow.FindMax(input3, 3);
			Console.ReadKey();
		}
	}
}
