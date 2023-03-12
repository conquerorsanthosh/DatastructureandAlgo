using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindow
{
public static class FindMaxInEachWindow
{
	public static List<int> FindMax(int[] input,int windowsize)
	{
		List<int> dequeue = new List<int>();
		int startWindow = 0;
		int endWindow = 0;
		List<int> result = new List<int>();

			//2 4 8 12 5 6 21 26 20 44 5 7
			while (endWindow < input.Length)
			{
				//remove all the elements from the end of the list
				while (dequeue != null && dequeue.Count != 0 && input[dequeue[dequeue.Count - 1]] < input[endWindow])
				{
					dequeue.RemoveAt(dequeue.Count - 1);
				}
				dequeue.Add(endWindow);

				if (endWindow - startWindow + 1 == windowsize)
				{
					//choose the max element
					result.Add(input[dequeue[0]]);

					//remove the element from the Dequeue which will be going out of scope
					if ((endWindow - windowsize) + 1 == dequeue[0])
					{
						dequeue.RemoveAt(0);

					}
					startWindow++;

				}
				endWindow++;
			}

			result.ForEach(Console.WriteLine);
			return result;
	}
		
	}
}


//Algorithm

/*2 4 8 12 5 6 21 26 20 44 5 7
 * Approach 1
1.start = end; INIT ,wsize
2.Start the Loop (Check  if  end is within array limit)
3.Push input[end] to  dequeue , while pushing make sure all the elements small than input[end] is removed
4.end++
5.if the front of the deque contains outside window element , remove it from the front, before removing ,push the element to output since that should be max element
6.If the window size is about to exceed end+1 > 
 */

























