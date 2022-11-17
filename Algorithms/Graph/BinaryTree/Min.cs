using Algorithms.Graph.Binary;

namespace Algorithms.Graph.BinaryTree;

public static class Min
{
	public static int SearchMin(this Node<int> root)
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
}
