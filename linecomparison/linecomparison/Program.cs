// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
linecomparison.Line linecomparison = new linecomparison.Line();
double length = linecomparison.getLength(2, 3, 2, 8);
double length = linecomparison.getLength(2, 6, 2, 9);
Console.WriteLine("length of the given line is" + L1, L2);
Console.WriteLine(L1.Equals(L2));
Console.WriteLine(L1.CompareTo(L2));
if (L1.CompareTo(L2) > 0)
    Console.WriteLine("The line one is greater than line two");
else if (L1.CompareTo(L2) < 0)
    Console.WriteLine("The line 2 is greater than line 1");
else
    Console.WriteLine("Both lines are same");