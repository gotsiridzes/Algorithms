namespace Algorithms.Graph.Binary;

public static class Bfs
{
	public static List<Node<T>> PerformBfs<T>(this Node<T> root)
	{
		if (root is null)
		{
			return new() { };
		}

		var result = new List<Node<T>>();

		var queue = new Queue<Node<T>>();
		queue.Enqueue(root);
		while (queue.Count > 0)
		{
			var current = queue.Dequeue();
			result.Add(current);
			if (current.Left != null) queue.Enqueue(current.Left);
			if (current.Right != null) queue.Enqueue(current.Right);
		}

		return result;
	}
}
