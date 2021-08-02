using System;


/// <summary>
/// Square Class inhirit from Rectangle
/// </summary>
class Square : Rectangle
{
    private int size;
    public int Size
    {
        get => size; set
        {
            if (value < 0) throw new ArgumentException("ArgumentException ");
            else size = value;
        }
    }
}



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

    /// <summary>
    /// calculate the areat of rectagle
    /// </summary>
    /// <returns></returns>
    public new int Area()
    {
        return height * width;

    }
    /// <summary>
    /// override ToString Method
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }

}
