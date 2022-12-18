// Write a program that takes as input a number N and outputs a list of all even numbers from 2 to N
OnceMore:
Console.Clear();
int Num, Index;
ConsoleKeyInfo rep;
Console.WriteLine("Please, Input Integer Number >1");
Num = Convert.ToInt32(Console.ReadLine());
Index = 0;
if (Num > 1)
{
    int Volume = Num / 2 - 1;
    while (Index < Volume)
    {
        Index++;
        Console.Write($" {2 * Index}, ");
    }
    Index++;
    Console.WriteLine($" {2 * Index}");
    Console.WriteLine($" Done! Do You remember - Your number was {Num}");
}
else
{ Console.WriteLine("Hey! I told You not less then 2!"); }

Console.WriteLine("\n Would you like to do it again now? Press Y - if Yes, any other - if No");
rep = Console.ReadKey(true);
if (rep.Key == ConsoleKey.Y) goto OnceMore;
return;