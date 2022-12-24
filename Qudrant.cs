Console.WriteLine("Please, input X coordinate");
double xcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input Y coordinate");
double ycoord = Convert.ToInt32(Console.ReadLine());
while (xcoord * ycoord == 0)
{
    Console.WriteLine("Please, input NON ZERO numbers!");
    Console.WriteLine("============> TRY AGAIN");
    Console.WriteLine("Please, input X coordinate");
    xcoord = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, input Y coordinate");
    ycoord = Convert.ToInt32(Console.ReadLine());
}
int x = MSign(xcoord);
int y = MSign(ycoord);
int answer = (2 - (x + y) / 2) + (2 + x - y) * (x - y) * (x - y) / 8;
Console.WriteLine($"Your coordinates belong to the {answer}-th quadrant.");

int MSign(double coord)
{
    int ans = Math.Sign(coord);
    return ans;
}