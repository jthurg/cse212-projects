public class Motorcycle : OnRoadVehicle
{
    //Define member variables.
    private bool _hasSideCar = false;

    //Define constructor.
    public Motorcycle(string year, string color, string make, string model, int rentalRate, int miles, string seats, bool hasSideCar) : base(year, color, make, model, rentalRate, miles, seats)
    {
        _hasSideCar = hasSideCar;
    }


    //Define methods.
    //(n/a)########

}