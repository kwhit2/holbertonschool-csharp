using System;

///<summary>Class Shape</summary>
class Shape
{
    ///<summary>Area method: throws an exception</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary>Class Rectangle</summary>
class Rectangle : Shape
{
    private int _width;
    private int _height;

    ///<summary>Public Property Width</summary>
    public int Width
    {
        get
        {
            return _width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                _width = value;
        }
    }

    ///<summary>Public Property Height</summary>
    public int Height
    {
        get
        {
            return _height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                _height = value;
        }
    }
}
