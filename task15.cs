Console.WriteLine("Please, input Week-day number");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1 || number > 7)
{
    Console.WriteLine("Your number doesn't fit to Week-number, try again.");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number < 6) Console.WriteLine("Wow - this day is Working day!");
else Console.WriteLine("Yeah! Today is Holyday!");