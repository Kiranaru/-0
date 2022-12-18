// Write a program that takes three numbers as input and outputs the maximum of them
Console.WriteLine("**********************************************");
Console.WriteLine("the First Number input here, please");
int FirstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the Second Number input here, please");
int SecondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the Third Number input here, please");
int ThirdNum = Convert.ToInt32(Console.ReadLine());
int MaxNum = FirstNum;
if (SecondNum > ThirdNum)
{
    MaxNum = SecondNum;
    if (FirstNum > SecondNum)
    { MaxNum = FirstNum; }
}
else
{
    if (ThirdNum > FirstNum)
    { MaxNum = ThirdNum; }
}
Console.WriteLine($" Maximum number is {MaxNum}");