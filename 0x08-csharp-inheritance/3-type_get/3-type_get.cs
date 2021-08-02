using System;
using System.Reflection;

/// <summary> Class Obj </summary>
internal class Obj
{
	/// <summary> prints the names of the available properties and methods of an object. </summary>
	/// <param name="myObj"> any Type Obj </param>
	public static void Print(object myObj)
	{
		MethodInfo[] listMethods = myObj.GetType().GetMethods();
		PropertyInfo[] listproperties = myObj.GetType().GetProperties();

		Console.WriteLine($"{myObj.GetType().Name} Properties:");
		foreach (var item in listproperties)
		{
			Console.WriteLine(item.Name);
		}
		Console.WriteLine($"{myObj.GetType().Name} Methods:");
		foreach (var item in listMethods)
		{
			Console.WriteLine(item.Name);
		}
	}
}
