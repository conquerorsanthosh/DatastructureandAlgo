namespace LeetCode
{
	public class UndirectedGraph
	{
		int numOfVertices;
		Dictionary<int, HashSet<int>> adjacencyList;
		public UndirectedGraph(int verices,List<Edge> edges) 
		{ 
			this.numOfVertices = verices;
			this.adjacencyList=ConvertToAdjacentList(edges);
		}

		public int GetnumOfVertices() 
		{
			return numOfVertices;
		
		}
		public Dictionary<int,HashSet<int >> GetNeigbours() 
		{
			return this.adjacencyList;
		}

		 public class Edge
		{
			public int vertex1;
			public int vertex2;
			
			public Edge(int vertex1, int vertex2) 
			{
				this.vertex1 = vertex1;
				this.vertex2 = vertex2;
			}
			public int GetStartVertex() { return vertex1; }
			public int GetEndVertex() { return vertex2; }
		}

		public  Dictionary<int, HashSet<int>> ConvertToAdjacentList(List<Edge> edges)
		{
			Dictionary<int, HashSet<int>> adjList = new Dictionary<int, HashSet<int>>();
			foreach (Edge e in edges)
			{
				if(!adjList.TryGetValue(e.vertex1,out HashSet<int> neighbours)) 
				{
					neighbours=new HashSet<int>();
					adjList[e.vertex1] = neighbours;
				}
				neighbours.Add(e.vertex2);

				if (!adjList.TryGetValue(e.vertex2, out HashSet<int> neighbours2))
				{
					neighbours2 = new HashSet<int>();
					adjList[e.vertex2] = neighbours2;
				}
				neighbours2.Add(e.vertex1);
			}
			return adjList;
		}
	}
		
	public  class DFS
	{
		 UndirectedGraph graph;
		HashSet<int> visitedVertex;	
		public DFS(UndirectedGraph graph) 
		{
			this.graph = graph;
			this.visitedVertex= new HashSet<int>();
		}
		public void ExploreByDFS(int startVertex) 
		{
			Console.WriteLine("ExploreByDFS");
			Stack<int>  vertexTobeProcessed= new Stack<int>();
			vertexTobeProcessed.Push(startVertex);
			Dictionary<int, HashSet<int>> neighbours = graph.GetNeigbours();
			while (vertexTobeProcessed.Count > 0) 
			{
				int vertex= vertexTobeProcessed.Pop();
				if (visitedVertex.Contains(vertex))
				{
					Console.WriteLine(vertex + "is already visited , will not be considered");
					continue;
				}
				if (!vertexTobeProcessed.Contains(vertex))
                {
					Console.WriteLine(vertex+"is visited");
					visitedVertex.Add(vertex);
					HashSet<int> vertexNeigbours = neighbours[vertex];
					foreach(int v in vertexNeigbours) 
					{
						vertexTobeProcessed.Push((int)v);
					}
				}
          	}
		
		}
		public void ExploreDFSRecurisvely(int startVertex) 
		{
			Console.WriteLine("ExploreDFSRecurisvely");
			DFSRecursively(startVertex);
		
		}
		public void DFSRecursively( int vertex) 
		{
			if (visitedVertex.Contains(vertex)) 
			{
				Console.WriteLine(vertex + "is already visited will be ignored");
				return;
			}
			Console.WriteLine(vertex + "is visited");
			visitedVertex.Add((int)vertex);
			HashSet<int> vertexNeighbours = graph.GetNeigbours()[vertex];
			foreach( int v in vertexNeighbours) 
			{
				DFSRecursively((int)v);
			}
		}
	}
}
