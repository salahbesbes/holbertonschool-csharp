﻿/// <summary> Geric </summary>
/// <typeparam name="T"> Any Type </typeparam>
public class Queue<T>
{
	/// <summary> head queque </summary>
	public Node head { get; set; }

	/// <summary> tail queque </summary>
	public Node tail { get; set; }

	/// <summary> static var of the count of element </summary>
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
	/// <param name="value"> any type </param>
	public void Enqueue(T value)
	{
		Node newNode = new Node(value);
		if (count == 0)
		{
			head = newNode;
			tail = newNode;
		}
		else
		{
			tail.next = newNode;
			tail = newNode;
		}
		count++;
	}

	/// <summary> remove the head node and return it </summary>
	/// <returns> old heal node </returns>
	public T Dequeue()
	{
		if (count == 0)
		{
			System.Console.WriteLine("Queue is empty");
			return default(T);
		}

		Node tmp = head;
		head = head.next;
		count--;
		return tmp.value;
	}

	/// <summary> take a look at the value of the first node </summary>
	/// <returns> value of the the head </returns>
	public T Peek()
	{
		if (count == 0)
		{
			System.Console.WriteLine("Queue is empty");
			return default(T);
		}
		return head.value;
	}

	/// <summary> print the queue </summary>
	public void Print()
	{
		if (count == 0)
		{
			System.Console.WriteLine("Queue is empty");
			return;
		}
		Node current = head;
		while (current != null)
		{
			System.Console.WriteLine($"{current.value}");
			current = current.next;
		}
	}

	/// <summary>
	/// concatenates all values in the queue only if the queue is of type String or Char
	/// </summary>
	/// <returns> string </returns>
	public string Concatenate()
	{
		if (typeof(T) == typeof(string) || typeof(T) == typeof(char))
		{
			if (count == 0)
			{
				System.Console.WriteLine("Queue is empty");
				return null;
			}
			Node current = head;
			string concat = "";
			while (current != null)
			{
				concat += current.value;
				current = current.next;
			}

			return concat;
		}
		else
		{
			System.Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
			return null;
		}
	}

	/// <summary> Node encapsulate the data we want to work on </summary>
	public class Node
	{
		/// <summary> next Node </summary>
		public Node next { get; set; }

		/// <summary> data to store </summary>
		public T value { get; set; } = default(T);

		/// <summary> Node Constructor </summary>
		/// <param name="value"> any type of value </param>
		public Node(T value)
		{
			this.value = value;
		}
	}
}