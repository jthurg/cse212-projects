using System;

class Program
{
    static void Main(string[] args)
    {
        //Create shape objects.
        Square square = new Square("Green", 4);
        Rectangle rectangle = new Rectangle("Yellow", 4, 5);
        Circle circle = new Circle("Pink", 1);

        //Create shapes list and add each shape to the list.
        List<Shape> shapesList = new List<Shape>();
        shapesList.Add(square);
        shapesList.Add(rectangle);
        shapesList.Add(circle);

        //Iterate through each shape in the list and print its name, color, and area.
        foreach (Shape shape in shapesList)
        {
            Console.WriteLine(shape.GetType().Name);
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}