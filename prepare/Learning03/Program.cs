using System;
using System.Data.SqlTypes;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        //Note: I practiced using the different Setters and
        //Getters in the Fraction class.

        Fraction fraction1 = new Fraction();
        fraction1.SetTopValue(1);
        fraction1.SetBottomValue(3);

        Fraction fraction2 = new Fraction(3);
        fraction2.SetBottomValue(4);

        Fraction fraction3 = new Fraction(1, 10);

        Fraction fraction4 = new Fraction(1);
        int bottomFraction4 = fraction2.GetBottomValue();
        fraction4.SetBottomValue(bottomFraction4);

        //Get all the fraction strings by calling the GetFractionString() method.
        string fraction1String = fraction1.GetFractionString();
        string fraction2String = fraction2.GetFractionString();
        string fraction3String = fraction3.GetFractionString();
        string fraction4String = fraction4.GetFractionString();

        //Display all the fraction sttrings.
        Console.WriteLine(fraction1String);
        Console.WriteLine(fraction2String);
        Console.WriteLine(fraction3String);
        Console.WriteLine(fraction4String);

        //Get all the decimal values by calling the GetDecimalValue() method.
        double decimal1 = fraction1.GetDecimalValue();
        double decimal2 = fraction2.GetDecimalValue();
        double decimal3 = fraction3.GetDecimalValue();
        double decimal4 = fraction4.GetDecimalValue();

        //Display all the decimal values.
        Console.WriteLine(decimal1);
        Console.WriteLine(decimal2);
        Console.WriteLine(decimal3);
        Console.WriteLine(decimal4);

    }
}