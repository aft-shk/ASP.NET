
using GDBLibrary;
try
{



    Line l1 = new Line(new Point(23, 45), new Point(90, 33), 8);
    Line l2 = new Line(new Point(24, 25), new Point(10, 23), 9);

    Console.WriteLine(l1);
    Console.WriteLine("Total no of Objects are :-" + Line.count);
    l1.Thickness = 10;
    Console.WriteLine(l2);
    Line l3 = new Line(new Point(23, 66), new Point(90, 77), 78);
    Console.WriteLine("Total Objects created:-" + Line.count);

    Point p1 = new Point();
    p1.X = 90;
    p1.Y = 89;
    Console.WriteLine(p1);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{

}

var p = new Line(new Point(90, 23), new Point(33, 44), 34);
Console.WriteLine(p);