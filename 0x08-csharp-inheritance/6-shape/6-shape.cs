using System;



/// <summary>
/// Class Shape
/// </summary>
class Shape
{
    /// <summary>
    /// calclate area of the shape else throw exception
    /// </summary>
    /// <returns> void </returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");

    }
}


/// <summary>
/// class Rectagle inhirit from Shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    {
        get => width; set
        {
            if (value < 0) throw new ArgumentException("Width must be greater than or equal to 0");
            else width = value;
        }
    }

    public int Height
    {
        get => height;
        set
        {
            if (value < 0) throw new ArgumentException("Height must be greater than or equal to 0");
            else height = value;
        }
    }

}
