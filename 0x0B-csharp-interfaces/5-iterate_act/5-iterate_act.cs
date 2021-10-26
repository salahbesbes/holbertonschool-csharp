using System;
using System.Collections.Generic;

/// <summary> interface </summary>
public interface IBreakable
{
	/// <summary> durability </summary>
	int durability { get; set; }

	/// <summary> break method </summary>
	void Break();
}

/// <summary> interface </summary>
public interface ICollectable
{
	/// <summary> status </summary>
	bool isCollected { get; set; }

	/// <summary> methode </summary>
	void Collect();
}

/// <summary> interface </summary>
public interface IInteractive
{
	/// <summary> interactable </summary>
	void Interact();
}

/// <summary> abstarct class </summary>
public abstract class Base
{
	/// <summary> name string </summary>
	public string name { get; set; }

	/// <summary> override to string methode </summary>
	/// <returns> </returns>
	public override string ToString()
	{
		return $"{name} is a {GetType()}";
	}
}

/// <summary> decoration class </summary>
public class Decoration : Base, IInteractive, IBreakable
{
	/// <summary> field </summary>
	public int _durability;

	/// <summary> constructor </summary>
	/// <param name="name"> </param>
	/// <param name="durability"> </param>
	/// <param name="isQuestItem"> </param>
	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		if (durability < 0) throw new System.Exception("Durability must be greater than 0");

		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}

	/// <summary> durability </summary>
	public int durability
	{
		get { return _durability; }
		set
		{
			_durability = value;
		}
	}

	/// <summary> isQuestItem </summary>
	public bool isQuestItem { get; set; }

	/// <summary> break methode </summary>
	public void Break()
	{
		durability--;
		if (durability > 0)
			System.Console.WriteLine($"You hit the {name}. It cracks.");
		if (durability == 0)
			System.Console.WriteLine($"You smash the {name}. What a mess.");
		if (durability < 0)
			System.Console.WriteLine($"The {name} is already broken.");
	}

	/// <summary> inteact methode </summary>
	public void Interact()
	{
		if (durability <= 0)
			System.Console.WriteLine($"The {name} has been broken.");
		else
		{
			if (isQuestItem)
				System.Console.WriteLine($"You look at the {name}. There's a key inside.");
			else
				System.Console.WriteLine($"You look at the {name}. Not much to see here.");
		}
	}
}

/// <summary> test Class inhirits 1 class an 3 inteface </summary>
public class Door : Base, IInteractive
{
	/// <summary> constructor </summary>
	/// <param name="door"> name of the door </param>
	public Door(string door = "Door")
	{
		name = door;
	}

	/// <summary> implement hte interact methode </summary>
	public void Interact()
	{
		System.Console.WriteLine($"You try to open the {name}. It's locked.");
	}
}

/// <summary> key class </summary>
public class Key : Base, ICollectable
{
	/// <summary> key constructor </summary>
	/// <param name="name"> </param>
	/// <param name="isCollected"> </param>
	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}

	/// <summary> iscollcted </summary>
	public bool isCollected { get; set; }

	/// <summary> Collect methode </summary>
	public void Collect()
	{
		if (isCollected == false)
		{
			isCollected = true;
			System.Console.WriteLine($"You pick up the {name}.");
		}
		else
		{
			System.Console.WriteLine($"You have already picked up the {name}.");
		}
	}
}

/// <summary> room </summary>
public class RoomObjects
{
	/// <summary>
	/// iterate through it, and execute methods depending on what interface that item implements.
	/// </summary>
	/// <param name="roomObjects"> </param>
	/// <param name="type"> </param>
	public static void IterateAction(List<Base> roomObjects, Type type)
	{
		foreach (var obj in roomObjects)
		{
			if (obj is IInteractive && type == typeof(IInteractive))
			{
				(obj as IInteractive).Interact();
			}
			if (obj is IBreakable && type == typeof(IBreakable))
			{
				(obj as IBreakable).Break();
			}
			if (obj is ICollectable && type == typeof(ICollectable))
			{
				(obj as ICollectable).Collect();
			}
		}
	}
}