/// <summary> Geric </summary>
/// <typeparam name="T"> Any Type </typeparam>
public class Queue<T>
{
	public Node head { get; set; }
	public Node tail { get; set; }
	public static int count { get; set; } = 0;

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
		public Node next { get; set; }
		public T value { get; set; } = default(T);

		public Node(T value)
		{
			this.value = value;
		}
	}
}