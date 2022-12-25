Console.Clear();
Console.WriteLine("Input NUMBER you would like to know whether it is prime or not.");
int number = Convert.ToInt32(Console.ReadLine());
int indexPrimeNumber = 1;
bool markerPrimeNumber = true;

if (PrimeNumber(number)) Console.WriteLine($"YES, Your number {number} is PRIME!\n");
else
{
    Console.WriteLine($"Sorry, but Your number {number} is NOT prime...\n");
}


bool PrimeNumber(int numPrimeNumber)
{
    indexPrimeNumber = 1;
    markerPrimeNumber = true;
    while (markerPrimeNumber && indexPrimeNumber < numPrimeNumber - 1)
    {
        indexPrimeNumber++;
        if (numPrimeNumber % indexPrimeNumber == 0) markerPrimeNumber = false;
    }
            return markerPrimeNumber;    
}