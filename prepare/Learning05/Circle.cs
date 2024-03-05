public class Circle: Shape
{
    //Define member variables.
    private int _radius = 0;

    //Define constructor.
    public Circle(string color, int radius) : base(color)
    {
        _radius = radius;
    }

    //Define methods.
    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;
    }


}