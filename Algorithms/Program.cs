using Algorithms.Graph.Binary;

var a = new Node<char>('a');
var b = new Node<char>('b');
var c = new Node<char>('c');
var d = new Node<char>('d');
var e = new Node<char>('e');
var f = new Node<char>('f');

a.Left = c;			//		 a
a.Right = b;		//		/\
b.Right = f;		//	   c  b
c.Left = d;			//    /\   \
c.Right = e;        //   d  e   f

// var dfsIter = a.PerformDfsIterative();
// dfsIter.Print();

// var dfsRecur = a.PerformDfsRecursive();
// dfsRecur.Print();

//var bfs = a.PerformBfs();
//bfs.Print();

var argsToCheck = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
foreach (var item in argsToCheck)
{
	Console.Write($"{item} - IsAvailable ({a.IsAvailable(item)})\tIsAvailableBfsImpl({a.IsAvailableBfsImpl(item)})\n");
}
