using System.Net.Mime;
using System.Runtime.CompilerServices;
using StrategyPattern;

Sorter sorter = new Sorter();
int[] input = new int[] { 7, 1, 23, 22, 22, 11, 0, 21, 1, 2, 334, 45, 6, 11, 2 };
Speed speed;

Console.WriteLine("Choose sorting algorithm:\n[S]low Bubble Sort (default)\n[M]edium Insertion Sort\n[F]ast Quick Sort");

char auswahlSpeed = Console.ReadLine()[0];

if(auswahlSpeed == 'S')
{
    speed = Speed.Slow;
    Console.WriteLine("Bubble Sort");

}
else if(auswahlSpeed == 'M')
{
    speed = Speed.Medium;
    Console.WriteLine("Insertion Sort:");
}
else if (auswahlSpeed == 'F')
{
    speed = Speed.Fast;
    Console.WriteLine("Quick Sort:");
}
else
{
    speed = Speed.Slow;
    Console.WriteLine("Bubble Sort:");
}

Console.WriteLine("\nInput is : ");
foreach (int i in input)
{
    Console.WriteLine($"{i},");
}

sorter.Sort(input, speed);