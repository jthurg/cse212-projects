public class Razor : OffRoadVehicle
{
    //Define member variables.
    private bool _hasWinch = false;

    //Define constructor.
    public Razor(string year, string color, string make, string model, int rentalRate, int hours, string trailerNumber, bool hasWinch) : base(year, color, make, model, rentalRate, hours, trailerNumber)
    {
        _hasWinch = hasWinch;

    }

    //Define methods.
    //(n/a)########

}