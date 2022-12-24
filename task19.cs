Console.WriteLine("Please, input integer number");
int number = Convert.ToInt32(Console.ReadLine());

int[] num = new int[32];
int marker = 0;

int halflength = NumDataLength(number) / 2;
int length = NumDataLength(number);
int ind = 0;
while (ind < halflength)
{
    ind++;
    if (num[ind] != num[length - ind + 1]) marker++;
}
if (marker == 0) Console.WriteLine("Your number is POLYNDROMIC !");
else Console.WriteLine("Sorry, but your number is casual...");

int NumDataLength(int numero)
{
    int index = 0;
    int numozoid = 0;
    int tens = 1;
    while (numero > numozoid)
    {
        index++;
        num[index] = (number - numozoid) / tens % 10;
        numozoid = numozoid + num[index] * (tens);
        tens = tens * 10;
    }
    return index;
}