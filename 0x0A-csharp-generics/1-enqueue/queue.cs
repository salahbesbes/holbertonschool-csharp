/// <summary> Geric </summary>
/// <typeparam name="T"> Any Type </typeparam>
public class Queue<T>
{
	public static int count = 0;
	public Node head;
	public Node tail;

	/// <summary> return a type of </summary>
	/// <returns> string </returns>
	public string CheckType()
	{
		return $"{typeof(T)}";
	}

	/// <summary> return the number of nodes </summary>
	/// <returns> count var </returns>
	public int Count()
	{
		return count;
	}

	/// <summary> add new node to the tail of the queue </summary>
	/// <param name="value"> </param>
	public void Enqueue(T value)
	{
		Node newNode = new Node(value);
		if (count == 0) head = newNode;
		else if (count == 1) tail = newNode;
		else tail.next = newNode;
		count++;
	}

	/// <summary> Node encapsulate the data we want to work on </summary>
	public class Node
	{
		public Node next;
		public T value = default(T);

		public Node(T value)
		{
			this.value = value;
		}
	}
}