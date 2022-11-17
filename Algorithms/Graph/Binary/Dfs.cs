using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph.Binary;

public static class Dfs
{

	public static void Print<T>(this List<Node<T>> data)
	{
		Console.WriteLine("**********");
		foreach (var item in data)
		{
			Console.WriteLine(item.Val);
		}
		Console.WriteLine("**********");
	}

	public static List<Node<T>> PerformDfsIterative<T>(this Node<T> root)
	{
		var result = new List<Node<T>>();

		var stack = new Stack<Node<T>>();
		stack.Push(root);
		while (stack.Count > 0)
		{
			var current = stack.Pop(); // or stack.peek

			if(current.Left != null)
			{
				stack.Push((Node<T>)current.Left);
			}

			if(current.Right != null)
			{
				stack.Push(((Node<T>)current.Right));
			}

			result.Add(current);
		}


		return result;
	}

	//public static List<Node<T>> DfsRecursive<T>(this Node<T> root)
	//{
	//}
}
