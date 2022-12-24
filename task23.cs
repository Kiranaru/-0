Console.WriteLine("Input N");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index < num)
{
    Console.Write($"{index * index * index}, ");
    index++;
}
Console.Write($"{index * index * index}\n");