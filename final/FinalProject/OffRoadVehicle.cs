public abstract class OffRoadVehicle : Vehicle
{
    //Define member variables.
    private int _hours = 0;
    private string _trailerNumber = "";

    //Define constructor.
    public OffRoadVehicle(string year, string color, string make, string model, int rentalRate, int hours, string trailerNumber) : base(year, color, make, model, rentalRate)
    {
        _hours = hours;
        _trailerNumber = trailerNumber;
    }

    //Define methods.
    public override void Rent()
    {
        //#########The rental code might look like something similar to this #########
        // Console.WriteLine("How many hours do you expect to use this vehicle? ");
        // int hours = int.Parse(Console.ReadLine());
        // totalCost += ((OnRoadVehicle)vehicle).GetRentalRate();
    }

    public override int Return()
    {
        int cost = (GetRentalRate() * _hours);
        return cost;
    }
    public void SetHours(int hours)
    {
        _hours = hours;
    }

    public override void DisplayInfo()
    {
        
    }

    public string GetTrailerNumber()
    {
        return _trailerNumber;
    }

}