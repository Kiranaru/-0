Console.WriteLine("Please, input positive integer number (less than 9 millions)");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The length of your number is {NumLength(number)} digits!");


int NumLength(int numero)
{
    int index = 0;
    int numozoid = 0;
    int tens = 1;
    while (numero > numozoid)
    {
        index++;
        numozoid = numozoid + ((numero - numozoid) / tens % 10) * (tens);
        tens = tens * 10;
    }
    return index;
}