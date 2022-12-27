Console.Clear();
Console.WriteLine("Input your NUMBER.\n");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 2)
{
    Console.WriteLine("Your number must be greater then one.\n");
    number = Convert.ToInt32(Console.ReadLine());
}
int[] primenum = new int[number];
int indexPrimeNumber = 1;
bool markerPrimeNumber = true;
int counter = -1;
int index = 1;
while (index < number)
{
    if (PrimeNumber(index))
    {
        counter++;
        primenum[counter] = index;
    }
    index++;
}
// Console.WriteLine($"\n COUNTER: {counter}");
int[] primes = new int[counter + 1];
int[] alphas = new int[counter + 1];
index = 0;
primes[index] = 1;
while (index < counter)
{
    index++;
    primes[index] = primenum[index];
    alphas[index]=Alphas(number, primes[index]);
    // Console.WriteLine($"{number % Math.Pow(primes[index], alphas[index] + 1)} {index}: {primes[index]} with a: {alphas[index]}");
}
index=0;
Console.Clear();
Console.Write($"{number}=");
while (index<counter)
{
if (alphas[index]!=0)Console.Write($"{primes[index]}^{alphas[index]} * ");
index++;
}
Console.Write(" <==== THAT'S UNIQUE FORM OF YOUR NUMBER \n");


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

int Alphas(int numberAlphas, int primeAlphas)
{
int IndexAlphas=0;
while (numberAlphas % Math.Pow(primeAlphas, IndexAlphas + 1) == 0) IndexAlphas++;
return IndexAlphas;
}