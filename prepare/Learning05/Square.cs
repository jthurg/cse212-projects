public class Square : Shape
{
    //Define member variables.
    private int _side = 0;

    //Define constructor.
    public Square(string color, int side) : base(color)
    {
        _side = side;
    }
    //Define methods.
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}