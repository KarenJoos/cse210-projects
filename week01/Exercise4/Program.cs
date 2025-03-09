using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

List<int> numbers = new List<int>();
int userNumber = -1;
Console.WriteLine("Enter a list of numbers, type 0 when finished.");

while (userNumber != 0)
{
    Console.Write("Enter number: ");

    string userResponse = Console.ReadLine();
    userNumber = int.Parse(userResponse);

    // adding numbers to the list if the number is not a 0.
    if (userNumber != 0)
    {
        numbers.Add(userNumber);
    }
}
int sum = 0;
// finding the sum.
foreach(int number in numbers)
{
    sum += number;
}
Console.WriteLine($"The sum is: {sum}");

// finding the average.
float average = ((float)sum) / numbers.Count;
Console.WriteLine($"The average is: {average}");

int max = 0;
// finding the max
foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}
Console.WriteLine($"The largest number is: {max}");
