public class Boat : OffRoadVehicle
{
    //Define member variables.
    private string _type = "";

    //Define constructor.
    public Boat(string year, string color, string make, string model, int rentalRate, int hours, string trailerNumber, string type) : base(year, color, make, model, rentalRate, hours, trailerNumber)
    {
        _type = type;

    }

    //Define methods.
    //(n/a)########

}