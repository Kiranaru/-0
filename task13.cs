Console.WriteLine("Please, input number");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) Console.WriteLine("Your number hasn't got any third number!");
else{
Console.WriteLine($"Yeah! On position 3 of your number is value: {Num3Digit(number)}");
}

int Num3Digit(int numero)
{
    int num = ((numero-((((numero-(numero%10))/10)%10)*10-numero%10))/100)% 10 ;
    return num;
}
