using FigureSquare;
try
{
    Figure Triangle;
    Figure Circle = new Figure();
    Console.WriteLine("Input sides of triangle");
    while (true)
    {
        Triangle = new Figure(uint.Parse(Console.ReadLine()), uint.Parse(Console.ReadLine()), uint.Parse(Console.ReadLine()));
        if (Triangle != null)
            break;
    }
    Console.WriteLine("Sqare of triangle is " + Triangle.Square());
    Console.WriteLine("Square of circle is " + Circle.Square());
    if (Triangle.RightTriangle())
        Console.WriteLine("This is right triangle");
    else
        Console.WriteLine("This isnt right triangle");
    if (Circle.RightTriangle())
        Console.WriteLine("This should not work");
    Console.ReadLine();
}
catch(Exception e) {Console.WriteLine(e.ToString());}