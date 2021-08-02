/// <summary> Obj class </summary>
internal class Obj
{
	/// <summary> check if the element passed is int </summary>
	/// <param name="obj"> any type obj </param>
	/// <returns> true if its int else false </returns>
	public static bool IsOfTypeInt(object obj)
	{
		return obj.GetType() == typeof(int);
	}
}