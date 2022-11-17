namespace Algorithms.Graph.Binary;

public static class Includes
{
	/// <summary>
	/// Searches through binary tree and returns true if target value is found
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="root">Root element of the b tree</param>
	/// <param name="target">Target, which will be checked</param>
	/// <returns></returns>
	public static bool IsAvailable<T>(this Node<T>? root, T target)
	{
		if (root is null) return false;
		if (root.Val!.Equals(target)) return true;

		return IsAvailable(root.Left, target) || IsAvailable(root.Right, target);
	}

	public static bool IsAvailableBfsImpl<T>(this Node<T>? root, T target)
	{
		if (root is null) return false;
		if (root.Val!.Equals(target)) return true;

		var queue = new Queue<Node<T>>();
		queue.Enqueue(root);

		while (queue.Count > 0)
		{
			var current = queue.Dequeue();
			if (current.Val!.Equals(target)) return true;
			
			if(current.Left != null) queue.Enqueue(current.Left);
			if(current.Right!= null) queue.Enqueue(current.Right);
		}

		return false;
	}
}
