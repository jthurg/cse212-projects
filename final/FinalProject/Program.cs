using System;
using System.Security.Permissions;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {

        //Instantiate the system records.
        SystemRecords systemRecords = new SystemRecords();

        //Instantiate all the vehicles that are available and add them to respective lists.


        



        //Define the menu text.
        string menuText = "Menu Options:\n" +
        "   1. Rent\n" +
        "   2. Return\n" +
        "   3. Estimate Rental Cost\n" +
        "   4. View Return Cart\n" +
        "   5. Checkout\n" +
        "Please select a choice from the menu: ";

        //Define the grand total cost.
        int grandTotal = 0;

        //Display program welcome message.
        Console.WriteLine("Welcome to Bob's Vehicle Rentals!");

        //Create a menu loop.
        string userChoice = "0";
        while (userChoice != "finished")
        {
            //Display menu.
            Console.Write(menuText);
            userChoice = Console.ReadLine();

            //If the user enters 1, display the rental menu.
            if (userChoice == "1")
            {
                string rentChoice = "0";
                string rentalMenuText = "Rental Menu:\n" +
                "   1. On-Road Vehicles\n" +
                "   2. Off-Road Vehicles\n" +
                "   3. Return\n" +
                "Please select a choice from the menu: ";

                while (rentChoice != "3")
                {
                    Console.Write(rentalMenuText);
                    rentChoice = Console.ReadLine();

                    if (rentChoice == "1")
                    {
                        //Code to display on road vehicles rental menu.
                        Console.WriteLine("Here are the on-road vehicles available for rent: ");
                        systemRecords.DisplayOnRoadVehicles();
                        Console.Write("What on-road vehicle are you renting?: ");
                        int rentNumber = int.Parse(Console.ReadLine());
                        systemRecords._onRoadVehicles[rentNumber - 1].Rent(); 
                        
                    }

                    else if (rentChoice == "2")
                    {
                        //Code to display off-road vehicles rental menu.
                        Console.WriteLine("Here are the off-road vehicles available for rent: ");
                        systemRecords.DisplayOffRoadVehicles();
                        Console.Write("What off-road vehicle are you renting?: ");
                        int rentNumber = int.Parse(Console.ReadLine());
                        systemRecords._offRoadVehicles[rentNumber - 1].Rent();

                    }

                    else if (rentChoice == "3")
                    {
                        //Code to return to the main menu.
                        //None needed.
                    }

                    else
                    {
                        //Code to display an error message.
                        Console.WriteLine("Invalid input. Please enter a number 1-3.");
                    }

                }
                
            }

            //If the user enters 2, display the return menu.
            else if (userChoice == "2")
            {
                string returnChoice = "0";
                string returnMenuText = "Return Menu:\n" +
                "   1. On-Road Vehicles\n" +
                "   2. Off-Road Vehicles\n" +
                "   3. Return\n" +
                "Please select a choice from the menu: ";

                //Code to display the return menu.
                while (returnChoice != "3")
                {
                    Console.Write(returnMenuText);
                    returnChoice = Console.ReadLine();

                    if (returnChoice == "1")
                    {
                        //Code to display on road vehicles return menu.
                        Console.WriteLine("Here are the on-road vehicles available for return: ");
                        systemRecords.DisplayOnRoadVehicles();
                        Console.Write("What on-road vehicle are you returning?: ");
                        int returnNumber = int.Parse(Console.ReadLine());
                        Console.Write("How many miles did you use this vehicle for? ");
                        int miles = int.Parse(Console.ReadLine());
                        systemRecords._onRoadVehicles[returnNumber - 1].SetMiles(miles);
                        int returnCost = systemRecords._onRoadVehicles[returnNumber - 1].Return();
                        systemRecords.AddVehicleToReturnList(systemRecords._onRoadVehicles[returnNumber - 1]);
                        grandTotal += returnCost;

                        //Can I avoid making the list a private member variable by RETURNING the _onRoadVehicles
                        //list instead with a method????#####################

                    }

                    else if (returnChoice == "2")
                    {
                        
                        //Code to display off road vehicles return menu.
                        Console.WriteLine("Here are the off-road vehicles available for return: ");
                        systemRecords.DisplayOffRoadVehicles();
                        Console.Write("What off-road vehicle are you returning?: ");
                        int returnNumber = int.Parse(Console.ReadLine());
                        Console.Write("How many hours did you use this vehicle for? ");
                        int hours = int.Parse(Console.ReadLine());
                        systemRecords._offRoadVehicles[returnNumber - 1].SetHours(hours);
                        int returnCost = systemRecords._offRoadVehicles[returnNumber - 1].Return();
                        systemRecords.AddVehicleToReturnList(systemRecords._offRoadVehicles[returnNumber - 1]);
                        grandTotal += returnCost;
                    }

                    else if (returnChoice == "3")
                    {
                        //Code to return to the main menu.
                        //None needed.
                    }

                    else
                    {
                        //Display an error message.
                        Console.WriteLine("Invalid input. Please enter a number 1-3.");
                    }

                }


            }

            //If the user enters 3, display the potential rental items and the estimated cost.
            else if (userChoice == "3")
            {
                //Code to display the list of items in the rentalList.
                int count = 0;
                float estimatedCost = 0;
                foreach (Vehicle vehicle in systemRecords.GetRentalList())
                {
                    count += 1;
                    Console.Write($"{count}. ");
                    vehicle.DisplayInfo();

                    //If the vehicle is an on-road vehicle, ask how many miles to get the estimated cost.
                    if (vehicle.GetType() == typeof(OnRoadVehicle))
                    {
                        Console.Write("How many miles do you plan on driving this vehicle? ");
                        int miles = int.Parse(Console.ReadLine());
                        estimatedCost += (vehicle.GetRentalRate() * miles);
                    }

                    //If the vehicle is an off-road vehicle, ask how many hours to get the estimated cost.
                    else 
                    {
                        Console.Write("How many hours do you plan on using this vehicle? ");
                        int hours = int.Parse(Console.ReadLine());
                        estimatedCost += (vehicle.GetRentalRate() * hours);
                    }

                }
                
                //Code to display the estimated cost.
                //#############May need code to convert this to a float for display reasons.
                Console.WriteLine();
                Console.WriteLine($"Your estimated cost is: ${estimatedCost}.00");

            }

            //If the user enters 4, display the items in the Return Cart, but not
            //an estimated cost like the rental list.
            else if (userChoice == "4")
            {
                //Code to display the list of items in the returnList.
                int count = 0;
                foreach (Vehicle vehicle in systemRecords.GetReturnList())
                {
                    count += 1;
                    Console.Write($"{count}. ");
                    vehicle.DisplayInfo();
        
                }  
                    
            }


            //If the user enters 5, execute the checkout function and then end the program.
            else if (userChoice == "5")
            {
    
                //Code if there is a checkout cost to be paid.
                if (grandTotal > 0)
                {
                    bool checkout = true;
                    int change = 0;
                    while (checkout == true)
                    {
                        Console.WriteLine($"Your total cost is: ${grandTotal}.00");
                        Console.Write("Enter the payment amount (whole bills only): ");
                        int payment = int.Parse(Console.ReadLine());
                        grandTotal = grandTotal - payment;
                        if (grandTotal > 0)
                        {
                            Console.WriteLine("Insufficient funds. Add more payment.");
                        }
                        
                        else if (grandTotal == 0)
                        {
                            change = 0;
                            checkout = false;
                        }
                        else 
                        {
                            change = -1 *grandTotal;
                            checkout = false;
                        }
                    }
                    
                    //Display change after successful payment.
                    Console.WriteLine($"Thank you! Your change is ${change}.00.");
                    
                }

                else
                {
                    //Code if there is no checkout cost to be paid.
                    Console.WriteLine("You have no payment due.");
                }

                //End system menu loop.
                userChoice = "finished";
            
            }

            //If the user enters anything other than 1, 2, 3, 4, or 5, display an error message.
            else
            {
                Console.WriteLine("Invalid input. Please enter a number 1-5.");
            }

        }

        //Code to display what trailers they will be picking up if renting something.
        Console.WriteLine("You will be picking up these trailers for your rentals: ");
        foreach (OffRoadVehicle vehicle in systemRecords.GetRentalList())
        {
            Console.WriteLine(vehicle.GetTrailerNumber());
        }

        //Display end program message.
        Console.WriteLine("Thank you for using the Vehicle Rental System at Bob's Vehicle Rentals. Goodbye!");

    }
}

