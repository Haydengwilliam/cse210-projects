using System;

class Program
{
    static void Main(string[] args)
    {
        Square NewSquare = new Square("Green", 5);
        Rectangle NewRectangle = new Rectangle("Red", 3, 4);
        Circle NewCircle = new Circle("Blue", 6);
        List<Shape> ShapeList = [NewSquare, NewRectangle, NewCircle];
        foreach (Shape item in ShapeList)
        {
            Console.WriteLine($"{item.GetType()}\nColor: {item.GetColor()}\nArea: {item.GetArea()}\n");
        }
    }
}