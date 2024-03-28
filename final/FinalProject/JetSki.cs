public class JetSki : OffRoadVehicle
{
    //Define member variables.
    private bool _hasRoosterTail = false;

    //Define constructor.
    public JetSki(string year, string color, string make, string model, int rentalRate, int hours, string trailerNumber, bool hasRoosterTail) : base(year, color, make, model, rentalRate, hours, trailerNumber)
    {
        _hasRoosterTail = hasRoosterTail;

    }

    //Define methods.
    //(n/a)########

}