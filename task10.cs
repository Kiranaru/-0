Console.WriteLine("Please, input three-digit number");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999 || number < 100)
{
    Console.WriteLine("Your number is not a three-digit number , Buddy! Try again");
    number = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Yeah! On position 2 of your number is value: {Num2Digit(number)}");

int Num2Digit(int numero)
{
    int num = ((numero - (numero % 10)) / 10) % 10;
    return num;
}
