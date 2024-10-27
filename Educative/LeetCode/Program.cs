// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Binary_Search;
using System.Security;
using Edge = LeetCode.UndirectedGraph.Edge;
//Console.WriteLine("Hello, World!");
//int[] nums1 = {  0 };
//int[] nums2 = { 1 };
//MergeArray.Merge(nums1, 0, nums2, 1);
//nums1.ToList().ForEach(i =>Console.WriteLine(i));int[]

int[,] meetings = new int[,] { { 1, 20 }, { 2, 10 }, {3, 5} ,{ 4, 9 },{ 6,8} };
//int[,] meetings = { { 1, 4 }, { 2, 6 }, { 3, 10 }, { 5, 8 }, { 9, 15 } };
//int[,] myarr = new int[4, 6]; //example 2d array with 4 rows 6 columns

//MeetingRooms meetingRooms = new MeetingRooms();
//meetingRooms.MostBooked(3, meetings);

//LCP lCP = new LCP();
//string[] source ={  "flower",  "flow", "flight"};
//string[] target =  { "dog", "racecar", "car"} ;
//Console.WriteLine(lCP.GetLCP(target));

//int[] dup = { 1, 2, 2, 2, 3, 3, 3, 4, 5, 6 };
////int[] dup = { 1, 1, 2};
////int[] dup = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
//RemoveDuplicates.RemoveDuplicatesFromArray(dup);
//dup.ToList().ForEach(x =>Console.WriteLine(x));
//int[] prices = { 9, 2, 4, 6, 8, 22, 2, 1 };
//BuySellStocks.MaxProfit(prices);

//int[,] matrix =
//{
//	{1,2,3 },
//	{ 4,5,6},
//	{ 7,8,9}
//};
//int[,] matrix = { { 1 }, { 2 }, { 3 } };
//SpiralMatrix.PrintSpiral(matrix);
//Console.ReadLine();
//List<Edge> edges = new List<Edge>();
//edges.Add(new Edge(1, 2));
//edges.Add(new Edge(1, 4));
//edges.Add(new Edge(2, 5));
//edges.Add(new Edge(5, 3));
//edges.Add(new Edge(4, 3));
//UndirectedGraph graph = new UndirectedGraph(5, edges);
//DFS dFS = new DFS(graph);
//dFS.ExploreByDFS(1);

//DFS dFS1 = new DFS(graph);
//dFS1.ExploreDFSRecurisvely(1);

//BFS bFS = new BFS(graph); 
//foreach (KeyValuePair<int,HashSet<int> > keyValuePair in graph.GetNeigbours()) 
//{
//	Console.WriteLine($"Vertex { keyValuePair.Key}");
//	keyValuePair.Value.ToList().ForEach(element=>Console.WriteLine(element));
//}
//bFS.ExploreBFS(1);

//int[,] islands =
//	{
//	{ 0,0,0,0,0,1 },
//	{ 0,0,0,0,0,0 },
//	{ 0,0,0,0,0,0 },
//	{ 1,0,0,0,0,0 }
//	};

//NumIslands numIslands = new NumIslands(islands);
//Console.WriteLine(numIslands.FindNumIslands());
//Console.ReadLine();

//int[,] board = { { -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1 }, { -1, 35, -1, -1, 13, -1 }, { -1, -1, -1, -1, -1, -1 }, { -1, 15, -1, -1, -1, -1 } };
//SnakesAndLadders snakesAndLadders = new SnakesAndLadders();
//Console.WriteLine(snakesAndLadders.GetMinumumMoves(board));

//int[] static_array = { 1, 2, 3, 4, 5 };
//int[] static_array_1;
//int[] dynamic_array = new int[4];
int[] dynamic_array_1 = new int[] { 3,6,2,3,8,3,9,2,3,1 };
//int[][] jaggedarray = new int[4][];
//jaggedarray[0] = new int[2] { 1,2};
//jaggedarray[1] = new int[3] { 2,3,4};
//jaggedarray[2] = new int[4] { 4,5,6,7};
//jaggedarray[3] = new int[5] { 1,2,3,4,5};
//RemoveElement.RemoveElementFunction(dynamic_array_1, 5);
//RemoveElement.RemoveElementFunction_1(dynamic_array_1, 3);
//int[] dynamic_array_3 = new int[] { 1, 1, 1, 2, 2, 3 };
//RemoveElement.RemoveDuplicatesAtmostTwice(dynamic_array_3);
//int[] dynamic_array_4 = new int[] { 1, 1, 1, 2, 2, 3,3 };
//RemoveElement.MajorityElement(dynamic_array_4);char[]

//char[][] BoardState = new char[4][]; //dynamic jagged array declaration
//char[,] BoardState1 = new char[4,4]; //dynamic 2D array declaration
//string s = new string(BoardState[0]);
//char[] chars_1 = new char[] { 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'b', 'b', 'c', 'c', 'd', 'e' };
//StringCompress.Compress(chars_1);

//  LetterCombination solution = new LetterCombination();
//string digits = "234";
//IList<string> combinations = solution.GetLetterCombinations(digits);
//foreach (string combination in combinations)
//{
//	Console.WriteLine(combination);
//}

//CombinationSum combinationSum = new CombinationSum();
//combinationSum.CombinationSum3(3, 12);
//string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
//GroupAnagrams groupAnagrams = new GroupAnagrams();
//groupAnagrams.GetGroupAnagrams(strs);

//MaxDepth maxDepth = new MaxDepth();
//TreeNode root = new TreeNode(3);
//root.left = new TreeNode(4);
//root.right = new TreeNode(20);
//root.left.left = new TreeNode(6);
//root.left.right = new TreeNode(5);
//root.left.right.left= new TreeNode(7);
//root.left.right.right = new TreeNode(9);
//root.left.right.right.right = new TreeNode(19);
//root.right.left= new TreeNode(26);
//root.right.right = new TreeNode(25);
//root.right.right.left= new TreeNode(27);
//root.right.right.right = new TreeNode(28);
//maxDepth.GetMaxDepth(root);

//SumToLeafNode sumToLeafNode = new SumToLeafNode();
//TreeNode rootsum = new TreeNode(3);
//rootsum.left = new TreeNode(4);
//rootsum.right = new TreeNode(2);
//rootsum.left.left = new TreeNode(6);
//rootsum.left.right = new TreeNode(5);
//rootsum.left.right.left = new TreeNode(7);
//rootsum.left.right.right = new TreeNode(9);
//rootsum.left.right.right.right = new TreeNode(1);
//rootsum.right.left = new TreeNode(6);
//rootsum.right.right = new TreeNode(5);
//rootsum.right.right.left = new TreeNode(7);
//rootsum.right.right.right = new TreeNode(8);
//sumToLeafNode.SumNumbers(rootsum);

//ConstructTreePreorder constructTreePreorder = new ConstructTreePreorder();
//int[] preorder = { 20, 26, 27, 28, 17, 16, 15, 14, 11 };
//int[] inorder = { 27, 26, 28, 20, 16, 17, 14, 11, 15 };
//constructTreePreorder.BuildTree(preorder, inorder);


//ListNode head= new ListNode(1);
//LinkedList mylis = new LinkedList();
//mylis.AddNode(head);

//for (int i = 2; i <= 5; i++)
//{
//	ListNode listNode = new ListNode(i);
//	mylis.AddNode(listNode);
//}
//RotateList rotateList = new RotateList();
//rotateList.RotateRight(head, 2);

//Reverse2 reverse2 = new Reverse2();
//ListNode newHead= reverse2.ReverseBetween(head, 1, 5);
//ListNode newHead=reverse2 .Reverse(head);
//RemoveNode removeNode = new RemoveNode();
//ListNode newHead = removeNode.RemoveNthFromEnd(head,1);
//ReverseNodeKgroup reverseNodeKgroup = new ReverseNodeKgroup();
//ListNode newHead = reverseNodeKgroup.ReverseKGroup(head, 3);

//ListNode current = newHead;
//while (current != null)
//{
//	Console.Write(current.val + "->");
//	current = current.next;
//}

//Console.Write("null");


char[][] grid = new char[][]
{
	new char []{ '1', '0' , '1' , '0','1', '0' , '1' , '0','1', '0' , '1' , '0','1', '0' , '1' , '0' ,'0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0'},
	new char []{ '0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0' ,'0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0'},
	new char []{ '1', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0' ,'0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0'},
	new char []{ '1', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0' ,'0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0','0', '0' , '1' , '0'},
	new char []{ '1', '0' , '1' , '0' , '0', '0', '1', '0' , '0', '0', '1', '0' , '0', '0', '1', '0' , '0', '0', '1', '0' , '0', '0', '1', '0' , '0', '0', '1', '0' , '0', '0', '1', '0' }
};

//NumberOfIslands numberOfIslands = new NumberOfIslands();
//Console.Write(numberOfIslands.NumIslands(grid));
//char[][] board = new char[][]
//{
//	new char []{ 'X', 'X' , 'X' , 'X'},
//	new char []{ 'X', 'O' , 'O' , 'X'},
//	new char []{ 'X', 'X' , 'O','X'},
//	new char []{ 'X', 'O' , 'X','X'}

//};
//SurroundedRegion surroundedRegion = new SurroundedRegion();
//surroundedRegion.Solve(board);
int[] nums = { 1, 3, 5, 6 };
BinarySearch binarySearch = new BinarySearch();
binarySearch.SearchInsert(nums, 5);
Console.ReadKey();

