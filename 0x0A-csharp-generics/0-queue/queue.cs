/// <summary> Geric </summary>
/// <typeparam name="T">Any Type</typeparam>
class Queue<T>
{
	/// <summary> return  a type of T  </summary>
	/// <returns> string  </returns>
	public string CheckType()
	{
		return $"{typeof(T)}";
	}
}