public abstract class OnRoadVehicle : Vehicle
{
    //Define member variables.
    private int _miles = 0;
    private string _seats = "";

    //Define constructor.
    public OnRoadVehicle(string year, string color, string make, string model, int rentalRate, int miles, string seats) : base(year, color, make, model, rentalRate)
    {
        _miles = miles;
        _seats = seats;
    }

    //Define methods.
    public override void Rent()
    {
        
    }

    public override int Return()
    {

    int cost = (GetRentalRate() * _miles);
    return cost; 

    }

    public void SetMiles(int miles)
    {
        _miles = miles;
    }


    public override void DisplayInfo()
    {
        
    }

}