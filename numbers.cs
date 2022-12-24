Console.WriteLine("Please, input integer number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input the place nuber of it, numeric value you would like to now");
int pos = Convert.ToInt32(Console.ReadLine());
int[] num = new int[32];
int index = 0;
int numozoid = 0;
int tens = 1;
while (number > numozoid)
{
    index++;
    num[index] = (number - numozoid) / tens % 10;
    numozoid = numozoid + num[index] * (tens);
    tens = tens * 10;
}
while (pos>index-1)
{
Console.WriteLine("No...your number is shorter, then your position chosen. Please, input the valuable place nuber of it");
Console.WriteLine("Please, input the place nuber of it, numeric value you would like to now");
pos = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Yeah! On position {pos} of your number is value: {num[pos]}");

// This part was for control...
// Console.WriteLine($"Your Nubber is {numozoid}");
// int position=0;
// while (position < index-1)
// {
//     position++;
//     Console.WriteLine($"On position {position} is number: {num[position]}");
// }
