// Напишите программу, котоая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.WriteLine("**********************************************");
Console.WriteLine("****** Введите Первое Натуральное Число ******");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("**********************************************");
Console.WriteLine("****** Введите Второе Натуральное Число ******");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("****************** EQUALITY ******************");
}
else if (a > b)
{
    Console.WriteLine($"The first number {a} is GREATER then the second one {b}");
}
else
{
    Console.WriteLine($"The first number {a} is LESS then the second one {b}");
}