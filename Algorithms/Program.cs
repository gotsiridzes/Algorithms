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
c.Right = e;		//   d  e   f

var result = a.PerformDfsIterative();
result.Print();

result = a.PerformDfsRecursive();
result.Print();
