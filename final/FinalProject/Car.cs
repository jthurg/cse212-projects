public class Car : OnRoadVehicle
{
    //Define member variables.
    private string _type = "";

    //Define constructor.
    public Car(string year, string color, string make, string model, int rentalRate, int miles, string seats, string type) : base(year, color, make, model, rentalRate, miles, seats)
    {
        _type = type;
    }


    //Define methods.
    //(n/a)########

}