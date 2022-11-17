namespace Algorithms.Graph.Binary;

public static class TreeSum
{
	public static int CalculateTreeSum(this Node<int>? root)
	{
		if (root == null) return 0;

		return root.Val + CalculateTreeSum(root.Left) + CalculateTreeSum(root.Right);
	}

	public static int CalculateTreeSumIterativeDfs(this Node<int>? root)
	{
		if (root == null) return 0;

		int sum = 0;

		var stack = new Stack<Node<int>>();
		stack.Push(root);

		while (stack.Count > 0)
		{
			var current = stack.Pop();

			sum += current.Val;

			if (current.Left != null) stack.Push(current.Left);
			if (current.Right != null) stack.Push(current.Right);
		}

		return sum;
	}

	public static int CalculateTreeSumIterativeBfs(this Node<int>? root)
	{
		if (root == null) return 0;

		int sum = 0;

		var queue = new Queue<Node<int>>();
		queue.Enqueue(root);

		while (queue.Count > 0)
		{
			var current = queue.Dequeue();

			sum += current.Val;

			if (current.Left != null) queue.Enqueue(current.Left);
			if (current.Right != null) queue.Enqueue(current.Right);
		}

		return sum;
	}
}
