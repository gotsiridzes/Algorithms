namespace Algorithms.Graph.Binary;

public static class TreeSum
{
	public static int CalculateTreeSum(this Node<int>? root)
	{
		if(root == null) return 0;

		return root.Val + CalculateTreeSum(root.Left) + CalculateTreeSum(root.Right);
	}
}
