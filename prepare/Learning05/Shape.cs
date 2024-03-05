public class Shape
{
    //Define member variables.
    private string _color = "";


    //Define constructor.
    public Shape(string color)
    {
        _color = color;
    }

    //Define methods.
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return 0;
    }
}