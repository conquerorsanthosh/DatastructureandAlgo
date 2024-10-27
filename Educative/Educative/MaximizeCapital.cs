using System;
using System.Collections.Generic;

namespace Educative
{
	public class CapitalDetails 
	{
		public int projectid;
		public int capital;

		public CapitalDetails(int projectid, int capital) 
		{
			this.projectid = projectid;
			this.capital = capital;
		}
	
	}

	public class ProfitDetails
	{
		public int projectid;
		public int profit;

		public ProfitDetails(int projectid, int profit)
		{
			this.projectid = projectid;
			this.profit = profit;
		}

	}

	public class CapitalComparer : IComparer<CapitalDetails>
	{
		public int Compare(CapitalDetails capital1, CapitalDetails capital2)
		{
			if (capital1.capital == capital2.capital) return 0;
			if (capital1.capital> capital2.capital) return 1;
			return -1;
		}
	}
	public class ProfitComparer : IComparer<ProfitDetails>
	{	
		public int Compare(ProfitDetails profit1, ProfitDetails profit2)
		{
			if (profit1.profit == profit2.profit) return 0;
			if (profit1.profit < profit2.profit) return 1; 
			return -1;
		}

	}

	public  class MaximizeCapital
	{
		private PriorityQueue<CapitalDetails,CapitalDetails> minCapital = new PriorityQueue<CapitalDetails,CapitalDetails>(new CapitalComparer());
		private PriorityQueue<ProfitDetails, ProfitDetails> maxProfit = new PriorityQueue<ProfitDetails, ProfitDetails>(new ProfitComparer());
		private int[] capitals;
		private int[] profits;
		private int attempts;
		private int seedCapital;

		public MaximizeCapital(int attempts, int[] capital,int[] profits,int seedCapital) 
		{
			this.attempts = attempts;
			this.capitals = capital;
			this.profits = profits;
			this.seedCapital = seedCapital;
			for (int i = 0; i < capitals.Length; i++)
			{
				CapitalDetails details = new CapitalDetails(i, capital[i]);
				minCapital.Enqueue(details,details);
			}

		}

		public int FindMaxCapital() 
		{
			int count = 0;
			int currentCapital = seedCapital;
			List<int> qualifiedCapitals = new List<int>();
			while (count < attempts) 
			{
				//Find the list of projects which is affordable with the capital.
				while (minCapital.Count > 0 && currentCapital >= minCapital.Peek().capital)  
				{
					CapitalDetails capitalDetails=minCapital.Dequeue();
					ProfitDetails profitDetails= new ProfitDetails(capitalDetails.projectid, profits[capitalDetails.projectid]);
					maxProfit.Enqueue(profitDetails,profitDetails);
				}

				//fom the list of projects select the project with highest profit,
				//add that profit to the captital
				if (maxProfit.Count <= 0) break;
				currentCapital += maxProfit.Dequeue().profit;
				count++;
		   	}
			return currentCapital;
		}
		

	}
}
