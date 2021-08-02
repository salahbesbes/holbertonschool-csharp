using System;

/// <summary> Class Obj </summary>
internal class Obj
{
	/// <summary> check for instance of a class that inherits from the specified class </summary>
	/// <param name="derivedType"> obj instance </param>
	/// <param name="baseType"> obj base </param>
	/// <returns> booolean </returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
	{
		return derivedType.IsSubclassOf(baseType);
	}
}