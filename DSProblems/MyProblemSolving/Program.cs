using System;
using MyProblemSolving;

namespace MyProblemSolving
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] inputArray = { 1, 1, 9, 9, 9, 6, 6, 5, 6, 3, 4, 5, 9 };
			//MyProblemSolving.MyproblemSolvingClass.FindMajorityElement_1(inputArray, inputArray.Length);

			int[] histogram = { 1,5,4,3,2,5,6,8};
			//MyProblemSolving.MyproblemSolvingClass.FindMaxRectangleInHistogram(histogram, histogram.Length);

			int[,] binMatrix =
			{
				{ 1,1,1,1 }, //0,1,0,1
				{ 1,1,1,1 },//0,2,1,2
				{ 1,1,1,1 },//0,3,2,3
				{ 1,1,1,1 },//0,4,2,4
			};
			MyProblemSolving.MyproblemSolvingClass.FindMaxRectangleInBinaryMatrix(binMatrix, 4, 4);

			//int[,] binMatrix = new int[4,4]
			//{
			//	{ 0,1,0,1 },
			//	{ 0,1,1,1 },
			//	{ 0,1,1,1 },
			//	{ 0,1,0,1 },
			//};

		}
	}
}
