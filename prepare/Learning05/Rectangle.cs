public class Rectangle : Shape
{
    //Define member variables.
    private int _length = 0;
    private int _width = 0;
    //Define constructor.
    public Rectangle(string color, int length, int width) : base(color)
    {
        _length = length;
        _width = width;
    }

    //Define methods.
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}