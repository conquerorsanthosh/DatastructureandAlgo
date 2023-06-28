using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative
{
    /*
     * 
     Given a sorted list of nonoverlapping intervals and a new interval, your task is to insert the new interval into the correct position 
     while ensuring that the resulting list of intervals remains sorted and nonoverlapping. 
    Each interval is a pair of nonnegative numbers, the first being the start time and the second being the end time of the interval.
     Input=[1,2][3,5][6,7][8,10][12,16]
     Insert interval=[4,8]
     Expected output=[1,2] [3,10][12,16]
    
    [4,8] [3,5] Overlapping Interval 1 starts after and Ends After
    [4,8] [6,7] Interval 1 starts before and ends after.

     [1,2] [3,8]
     [1,2] [3,8]   
     [1,2] [3,10] [12,16]*/


    public class ManageIntervals
    {
        private List<Interval> givenIntervals;
        private Interval insertInterval;
        private List<Interval> nonOverlappingIntervals = new List<Interval>();

        public ManageIntervals(List<Interval> intervals, Interval interval)
        {
            if (interval == null) throw new ArgumentException();
            this.givenIntervals = intervals;
            this.insertInterval = interval;
        }

        public List<Interval> InsertAndMergeIntervals()
        {
            if (givenIntervals.Count == 0)
            {
                nonOverlappingIntervals.Add(insertInterval);
                return nonOverlappingIntervals;
            }

            bool inserted = false;

            foreach (Interval currentInterval in givenIntervals)
            {
				if (currentInterval.start < insertInterval.start) 
                {
                    nonOverlappingIntervals.Add(currentInterval);
                }

				if (currentInterval.start >= insertInterval.start) 
                {
					if (!inserted) 
                    {
                        //insert and merge
                        Interval lastElement = nonOverlappingIntervals.Last();
                        if(CheckIfOverlap(insertInterval, lastElement)) 
                        {
                            Interval merged = new Interval();
                            merged.start = Math.Min(lastElement.start, insertInterval.start);
                            merged.end = Math.Max(lastElement.end, insertInterval.end);
                            nonOverlappingIntervals.RemoveAt(nonOverlappingIntervals.Count - 1);
                            nonOverlappingIntervals.Add(merged);
                        }
						else 
                        {
                            nonOverlappingIntervals.Add(insertInterval);
                        }
                        inserted = true;
                         
                    }

					else 
                    {
                        Interval lastElement = nonOverlappingIntervals.Last();
                        if (CheckIfOverlap(lastElement,currentInterval))
                        {
                            Interval merged = new Interval();
                            merged.start = Math.Min(lastElement.start, currentInterval.start);
                            merged.end = Math.Max(lastElement.end, currentInterval.end);
                            nonOverlappingIntervals.RemoveAt(nonOverlappingIntervals.Count - 1);
                            nonOverlappingIntervals.Add(merged);
                        }
                        else
                        {
                            nonOverlappingIntervals.Add(currentInterval);
                        }

                    }
                
                }

                Console.WriteLine("#    Start");
                PrintList(nonOverlappingIntervals);
                Console.WriteLine("#    End");
            }
            return nonOverlappingIntervals;
        }

        public void PrintList(List<Interval> source) 
        {
            foreach (Interval i in source)
            {
                Console.Write("["+"{0},{1}"+"]", i.start.ToString(), i.end.ToString());
            }
            Console.WriteLine();

        }
        private bool CheckIfOverlap(Interval interval1, Interval interval2)
        {
            //Interval 1 starts after , but ends later
            if (interval1.start > interval2.start && interval1.end > interval2.end)
            {
                return true;

            }

            //Interval 1 ends at the same time when the interval 2 begins
            if (interval1.start < interval2.start && interval1.end == interval2.start)
            {
                return true;

            }

            //Interval 1 starts before , end after
            else if (interval1.start < interval2.start && interval1.end > interval2.end)
            {
                return true;

            }

           else
            {
                return false;
            }
        }

        //private void MergeIntervals(Interval currentInterval)
        //{
        //     Interval newInterval = new Interval();
        //    nonOverlappingIntervals[]
    


        //}

    }

    public class Interval
    {
        public int start;
        public int end;

        public Interval (int s,int e) 
        {
            start = s;end = e;
        }

        public Interval() { }

    }

}
