Console.Clear();
Console.WriteLine("Input Left and right numbers for range you would like to find prime numbers in.\n");
Console.WriteLine("Input number for left range. Greater than 1");
int leftrange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number for left range. Greater than previous number.");
int rightrange = Convert.ToInt32(Console.ReadLine());
while (rightrange < leftrange && leftrange < 1)
{
    Console.WriteLine("Your Left number must be less then right one.\n");
    Console.WriteLine("Input Left and right numbers for range you would like to find prime numbers in.\n");
    leftrange = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input Left and right numbers for range you would like to find prime numbers in.\n");
    rightrange = Convert.ToInt32(Console.ReadLine());
}
int[] primenum = new int[rightrange];
int indexPrimeNumber = 1;
bool markerPrimeNumber = true;
int counter = -1;
int index = leftrange;
while (index < rightrange)
{
    if (PrimeNumber(index, leftrange))
    {
        counter++;
        primenum[counter] = index;
        Console.Write($"{(char)16} {index}  ,");        
    }
    index++;
}
Console.WriteLine(primenum.Length);        

bool PrimeNumber(int numPrimeNumber, int leftPrimeNumber)
{
    indexPrimeNumber = 1;
    markerPrimeNumber = true;
    while (markerPrimeNumber && indexPrimeNumber < numPrimeNumber-1 )
    {
        indexPrimeNumber++;
        if (numPrimeNumber % indexPrimeNumber == 0) markerPrimeNumber = false;
    }
    return markerPrimeNumber;
}

