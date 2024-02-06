public class Fraction
{
    //Define member variables.
    private int _top;
    private int _bottom;

    //Define constructors.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }



    //Define methods.
    public int GetTopValue()
    {
        int topValue = _top;
        return topValue;
    }

    public void SetTopValue(int topInput)
    {
        _top = topInput;
    }

    public int GetBottomValue()
    {
        int bottomValue = _bottom;
        return bottomValue;
    }

    public void SetBottomValue(int bottomInput)
    {
        _bottom = bottomInput;
    }

    public string GetFractionString()
    {
        string topString = _top.ToString();
        string bottomString = _bottom.ToString();
        string fractionString = topString + "/" + bottomString;
        return fractionString;
    }

    public double GetDecimalValue()
    {
        
        return (double)_top / (double)_bottom;
    }
}

