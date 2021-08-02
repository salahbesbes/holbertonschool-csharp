using System;

/// <summary> class Obj </summary>
internal class Obj
{
	/// <summary> check if the obj is an instance of Array </summary>
	/// <param name="obj"> any type </param>
	/// <returns> boolean </returns>
	public static bool IsInstanceOfArray(object obj)
	{
		return obj is Array;
	}
}