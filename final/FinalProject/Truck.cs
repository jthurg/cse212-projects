public class Truck : OnRoadVehicle
{
    //Define member variables.
    private bool _has4WD = false;

    //Define constructor.
    public Truck(string year, string color, string make, string model, int rentalRate, int miles, string seats, bool has4WD) : base(year, color, make, model, rentalRate, miles, seats)
    {
        _has4WD = has4WD;
    }


    //Define methods.
    //(n/a)########

    public override void DisplayInfo()
    {
        
    }
    
}