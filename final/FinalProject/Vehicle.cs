public abstract class Vehicle
{
    //Define member variables.
    private string _year = "";
    private string _color = "";
    private string _make = "";
    private string _model = "";
    private int _rentalRate = 0;

    //Define constructor.
    public Vehicle(string year, string color, string make, string model, int rentalRate)
    {
        _year = year;
        _color = color;
        _make = make;
        _model = model;
        _rentalRate = rentalRate;
    }


    //Define methods.
    public abstract void Rent();
    public abstract int Return();
    public abstract void DisplayInfo();
    public int GetRentalRate()
    {
        return _rentalRate;
    }
    
}