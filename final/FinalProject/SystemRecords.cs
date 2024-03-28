public class SystemRecords
{
    //Define member variables.
    public List<OnRoadVehicle> _onRoadVehicles = new List<OnRoadVehicle>();
    public List<OffRoadVehicle> _offRoadVehicles = new List<OffRoadVehicle>();
    private List<Vehicle> _rentalList = new List<Vehicle>();
    private List<Vehicle> _returnList = new List<Vehicle>();

    //Define constructor.
    public SystemRecords()
    {

    }

    //Define methods.
    public void DisplayOnRoadVehicles()
    {
        int count = 0;
        foreach (OnRoadVehicle vehicle in _onRoadVehicles)
        {
            count += 1;
            Console.Write($"{count}. ");
            vehicle.DisplayInfo();
            
        }
    }

//#############Maybe these 2 can be combined with one method that inputs the list name???############

    
    public void DisplayOffRoadVehicles()
    {
        int count = 0;
        foreach (OffRoadVehicle vehicle in _offRoadVehicles)
        {
            count += 1;
            Console.Write($"{count}. ");
            vehicle.DisplayInfo();
            
        }
    }

    public void AddVehicleToReturnList(Vehicle vehicle)
    {
        _returnList.Add(vehicle);
    }
    public void AddVehicleToRentalList(Vehicle vehicle)
    {
        _rentalList.Add(vehicle);
    }

    public List<Vehicle> GetRentalList()
    {
        return _rentalList;
    } 

      public List<Vehicle> GetReturnList()
    {
        return _returnList;
    } 

}