namespace Algorithms.Graph.Binary;

public class Node<T>
{
	public T Val { get; set; }
	public Node<T>? Left { get; set; }
	public Node<T>? Right { get; set; }

	public Node(T val) => Val = val;
}
