using Algorithms.Graph.Binary;

namespace Algorithms.Graph.BinaryTree;

public static class Min
{
	public static int SearchMinDfs(this Node<int> root)
	{
		if (root is null) return 0;
		var min = root.Val;
		var stack = new Stack<Node<int>>();
		stack.Push(root);
		
		while(stack.Count > 0)
		{
			var current = stack.Pop();

			min = current.Val < min ? current.Val : min;

			if (current.Left != null) stack.Push(current.Left);
			if (current.Right != null) stack.Push(current.Right);
		}

		return min;
	}

	public static int SearchMinBfs(this Node<int> root)
	{
		if (root is null) return 0;
		var min = root.Val;
		var queue = new Queue<Node<int>>();
		queue.Enqueue(root);

		while (queue.Count > 0)
		{
			var current = queue.Dequeue();

			min = current.Val < min ? current.Val : min;

			if (current.Left != null) queue.Enqueue(current.Left);
			if (current.Right != null) queue.Enqueue(current.Right);
		}

		return min;
	}

}
