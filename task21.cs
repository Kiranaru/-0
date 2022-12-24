Console.WriteLine("Input X coordinate for the First point A");
double ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate for the First point A");
double ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinate for the First point A");
double az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X coordinate for the Second point B");
double bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate for the Second point B");
double by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinate for the Second point B");
double bz = Convert.ToInt32(Console.ReadLine());

double distance = Distance(ax, ay, az, bx, by, bz);
Console.WriteLine($"AB section is {distance}");

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double pifagor = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2);
    double result = Math.Round(Math.Sqrt(pifagor), 2, MidpointRounding.ToZero);
    return result;
}