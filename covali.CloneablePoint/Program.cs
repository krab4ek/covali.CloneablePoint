using covali.CloneablePoint;


Console.WriteLine("****** Fun with Object Cloning *****\n");
Point p1 = new Point(50, 50);
Point p2 = p1;
p2.X = 0;

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine();