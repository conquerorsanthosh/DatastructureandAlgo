using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public  class BFS
	{
		UndirectedGraph graph;
		HashSet<int> visitedVertex;
		public BFS(UndirectedGraph graph) 
		{
			this.graph = graph;
			visitedVertex = new HashSet<int>();
		}
		public void ExploreBFS(int startVertex) 
		{
			Queue<int> verticesToProcess= new Queue<int>();
			ICollection<int> verticesCollection=graph.GetNeigbours().Keys;
			verticesToProcess.Enqueue(startVertex);

			while(verticesToProcess.Count > 0) 
			{
				int currentvertex=verticesToProcess.Dequeue();
				if(visitedVertex.Contains(currentvertex)) 
				{
					Console.WriteLine(currentvertex + "is already visited");
					continue;
				}
				else 
				{
					Console.WriteLine(currentvertex + "is  visited");
					visitedVertex.Add(currentvertex);
				}

				HashSet<int> neighbourOfCurrent = graph.GetNeigbours()[currentvertex];
				foreach(int neighbour in neighbourOfCurrent) 
				{
					verticesToProcess.Enqueue((int)neighbour);
				}
			}
        }
	}
}
