using Algorithms.Graph.Binary;

//var a = new Node<char>('a');
//var b = new Node<char>('b');
//var c = new Node<char>('c');
//var d = new Node<char>('d');
//var e = new Node<char>('e');
//var f = new Node<char>('f');

//a.Left = c;			//		 a
//a.Right = b;			//		/\
//b.Right = f;			//	   c  b
//c.Left = d;			//    /\   \
//c.Right = e;			//   d  e   f

// var dfsIter = a.PerformDfsIterative();
// dfsIter.Print();

// var dfsRecur = a.PerformDfsRecursive();
// dfsRecur.Print();

//var bfs = a.PerformBfs();
//bfs.Print();

//var argsToCheck = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
//foreach (var item in argsToCheck)
//{
//	Console.Write($"{item} - IsAvailable ({a.IsAvailable(item)})\tIsAvailableBfsImpl({a.IsAvailableBfsImpl(item)})\n");
//}


//		  3
//		 /  \
//	   11    4
//    / \    /\
//   4   2	1  -1
// Total Sum = 3 + 11 + 4 + 2 + 4 + 1 + (-1) = 24
var a = new Node<int>(3);
var b = new Node<int>(11);
var c = new Node<int>(4);
var d = new Node<int>(4);
var e = new Node<int>(2);
var f = new Node<int>(1);
var g = new Node<int>(-1);


a.Left = b;
a.Right = c;
b.Left = d;
b.Right = e;
c.Right = f;
c.Left = g;

//g = null; // check edge case

Console.WriteLine(a.CalculateTreeSum());
Console.WriteLine(g.CalculateTreeSum());
Console.WriteLine(a.CalculateTreeSumIterativeDfs());
Console.WriteLine(g.CalculateTreeSumIterativeDfs());
Console.WriteLine(a.CalculateTreeSumIterativeBfs());
Console.WriteLine(g.CalculateTreeSumIterativeBfs());
