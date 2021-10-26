/// <summary> abstarct class </summary>
internal abstract class Base
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