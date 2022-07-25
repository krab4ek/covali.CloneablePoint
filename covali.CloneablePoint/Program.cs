using covali.CloneablePoint;


Console.WriteLine("****** Fun with Object Cloning *****\n");
Point p1 = new Point(50, 50);
Point p2 = p1;
p2.X = 0;

Console.WriteLine(p1);
Console.WriteLine(p2);

Point p3 = new Point(100, 100);
Point p4 = (Point)p3.Clone();
p4.X = 0;

Console.WriteLine(p3);
Console.WriteLine(p4);




Console.WriteLine();