using System;
using System.Collections.Generic;

namespace Educative
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			//List<Interval> intervals = new List<Interval>();
			//intervals.Add(new Interval(1, 2));
			//intervals.Add(new Interval(3, 5));
			//intervals.Add(new Interval(6,7));
			//intervals.Add(new Interval(8,10));
			//intervals.Add(new Interval(12, 16));

			
			//ManageIntervals manageIntervals = new ManageIntervals(intervals, new Interval(4, 8));
			//Console.WriteLine("# Input Start");
			//manageIntervals.PrintList(intervals);
			//Console.WriteLine("# Input end");

			//List<Interval> merged= manageIntervals.InsertAndMergeIntervals();
			//Console.WriteLine(merged);
			//Console.WriteLine("# Final Start");
			//manageIntervals.PrintList(merged);
			//Console.WriteLine("# Final end");
			

			int[] capitals = { 2, 3, 5, 6, 8, 12 };
			int[] profits = { 1, 2, 5, 6, 8, 9 };
			MaximizeCapital maximizeCapital = new MaximizeCapital(4,capitals, profits,2);
			Console.WriteLine(maximizeCapital.FindMaxCapital());
			Console.ReadLine();
		}
	}
}
