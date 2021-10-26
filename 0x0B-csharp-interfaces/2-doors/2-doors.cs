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
		System.Console.WriteLine($"ou try to open the {name}. It's locked.");
	}
}