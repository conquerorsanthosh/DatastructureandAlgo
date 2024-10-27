/*[1,2][3,5][6,7][8,10][12,16]

[4,8] [3,5] Overlapping Interval 1 starts after and Ends After
[4,8] [6,7] Interval 1 starts before and ends after.

 [1,2] [3,8]
 [1,2] [3,8]   
 [1,2] [3,10] [12,16]
 
 
 
 Online C# Editor for free
 Write, Edit and Run your C# code using C# Online Compiler
 */

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
    }
}

public class Interval
{
    public int start;
    public int end;
    
}

public class ManageIntervals
{
    private List<Interval>givenIntervals;
    private Interval insertInterval;
	private List<Interval> nonOverlappingIntervals=new List<Interval>();
    
    public ManageIntervals(List<Interval>Intervals,Interval interval)
    {
        if(interval==null) throw new ArgumentException();
        this.givenIntervals=intervals;
        this.insertInterval=interval
    }
    
    public List<Interval> InsertInterval()
    {
        
        if(givenIntervals.Count==0)
        {
            nonOverlappingIntervals.Add(insertInterval);
            return nonOverlappingIntervals;
        }
        
        foreach(Interval currentInterval in givenIntervals)
        {
            if(CheckIfOverlap(currentInterval))
            {
				
				MergeIntervals(currentInterval);
                    
            }
			else
			{
				nonOverlappingIntervals.Add(currentInterval);
			}
        }
    }
    
    private bool CheckIfOverlap(Interval currentInterval)
    {
        //Interval 1 starts after , but ends later
        if(insertInterval.start>currentInterval.start  && insertInterval.end>currentInterval.end)
        {
            return true;
            
        }
        
        //Interval 1 starts before , end after
        else if(insertInterval.start<currentInterval.start  && insertInterval.end>currentInterval.end)
        {
            return true;
            
        }
        
        //Interval 1 starts after , ends after
        else if(insertInterval.start>currentInterval.start  && insertInterval.end>currentInterval.end)
        {
            return true;
            
        }
        
        else
        {
            return false;    
            
        }
    }
    
    private void MergeIntervals(Interval currentInterval)
    {
		
		Interval newInterval= new Interval();
		nonOverlappingIntervals[]  

        
    }
    
}