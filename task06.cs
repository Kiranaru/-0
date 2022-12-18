// Write a program that takes a number as input and outputs whether it is even
Console.WriteLine("Please, do not hasitate to input any Integer Number, Sir!");
int Number = Convert.ToInt32(Console.ReadLine());
int DivNum = Number % 2;
if (DivNum == 0)
{ Console.WriteLine($"Yes, Sir! Your Numer {Number} is quite EVEN!"); }
else
{
    { Console.WriteLine($"Sorry, Sir! But Your Numer {Number} is a little bit differ from EVEN!"); }
}